USE [SportsComplex];
GO

CREATE PROC spCheckUser

	@Login VARCHAR(50),
	@Password VARCHAR(50),
	@UserId INT OUTPUT

AS
BEGIN
	SET NOCOUNT ON;

	IF EXISTS (SELECT 1 FROM tblUser WHERE tblUser.Login = @Login)	
	BEGIN
		DECLARE @UserDisabled BIT;
		SELECT @UserId = Id, @UserDisabled = [Disabled] FROM tblUser 
		WHERE tblUser.Login = @Login AND tblUser.Password = @Password;

		IF @UserDisabled = 1
		BEGIN
			DECLARE @msg VARCHAR(50) = FORMATMESSAGE(N'User <%s> is disabled.', @Login);
			THROW 70003, @msg, 1;
		END

		IF @UserId IS NULL
		BEGIN
			;
			THROW 70001, N'User password is incorrect.', 1;
		END
	END
	ELSE 
	BEGIN
		--RAISERROR (N'User <%s> is not registered.', -- Message text.
  --         16, -- Severity,
  --         1, -- State,
  --         @Login);
		SET @msg = FORMATMESSAGE(N'User <%s> is not registered.', @Login);
		THROW 70002, @msg, 1
	END	
	--PRINT 'User ID is ' + CAST(@UserId AS NVARCHAR(5));		
END
GO


CREATE PROC spRemoveRent

	@rentID INT,
	@moneyChange NUMERIC(18, 2) OUT

AS
BEGIN
	SET NOCOUNT ON;

	IF NOT EXISTS(SELECT 1 FROM tblRent WHERE Id = @rentID AND [Deleted] = 0)
	BEGIN
		;
		THROW 80001, 'Rent item was not found', 1; 
	END

	DECLARE @DateStart DATETIME;
	DECLARE @DateEnd DATETIME;
	DECLARE @Rate NUMERIC(18, 2);
	DECLARE @Cost NUMERIC(18, 2);

	SELECT @DateStart = r.DateStart, @DateEnd = r.DateEnd, @Rate = c.Rate, @Cost = r.Cost
	FROM tblRent r
	INNER JOIN tblClass c ON r.ClassId = c.Id
	WHERE r.id = @rentID;

	-- Calc money change
	IF (GETDATE() < @DateStart)
	BEGIN
		SET @moneyChange = @Cost;	
	END
	ELSE
	BEGIN
		SET @moneyChange = ROUND(@Cost - (@Cost - (DATEDIFF(MINUTE, GETDATE(), @DateEnd) * @Rate) / 60), 2);
	END

	
	-- Mark record as deleted
	UPDATE tblRent 
	SET Deleted = 1
	WHERE Id = @rentID;

	PRINT 'Rent marked as deleted';

END
GO

CREATE PROC spGetRents

	@Date DATETIME

AS
BEGIN
	SET NOCOUNT ON;
	
	-- Mark record as deleted
	UPDATE tblRent 
	SET Deleted = 1
	WHERE tblRent.DateEnd < GETDATE();

	PRINT 'Rents marked as deleted';

	SELECT 
	     rent.[Id]
        ,rent.[CustomerId]
	    ,renter.FirstName AS [CustomerFirstName]
	    ,renter.LastName AS [CustomerLastName]
	    ,renter.Phone AS [CustomerPhone]
        ,rent.[ClassId]
	    ,ct.Id AS [ClassTypeId]
	    ,ct.Name AS [ClassName]
	    ,c.Area AS [ClassArea]
	    ,c.Rate AS [ClassRate]
        ,rent.[DateStart]
        ,rent.[DateEnd]
        ,rent.[Cost]
        ,rent.[Deleted]
    FROM [tblRent] rent
        INNER JOIN [tblCustomer] renter ON rent.CustomerId = renter.Id
        INNER JOIN [tblClass] c ON rent.ClassId = c.Id
        INNER JOIN [tblClassType] ct ON c.ClassTypeId = ct.Id
    WHERE (@Date <= rent.DateEnd 
            AND DATEPART(DAY, @Date) = DATEPART(DAY, rent.DateStart))
        AND rent.Deleted = 0
	ORDER BY rent.DateStart;

END
GO

CREATE PROC [dbo].[spMakeRent]
	@customerId INT,
	@sportsHallId INT,
	@dateStart DATETIME,
	@dateEnd DATETIME,
	@cost NUMERIC(18,2),

	@rentId INT OUT

AS
BEGIN
	SET NOCOUNT ON;

	IF (@dateStart >= @dateEnd)
	BEGIN
		RAISERROR ('Start date of rent cannot be greater or equal, than end date one.', -- Message text.
           16, -- Severity,
           1
		);
		RETURN;
	END

	--IF (DATEPART(DAY, @dateStart) < DATEPART(DAY, GETDATE()))
	IF (@dateStart < GETDATE())
	BEGIN
		RAISERROR ('Date of rent cannot be in the past!', -- Message text.
			   16, -- Severity,
			   1
			);
			RETURN;
	END
	
	BEGIN TRAN MakeRentTran
    WITH MARK N'Making a new rent record';

	IF EXISTS (SELECT 1
				FROM [SportsComplex].[dbo].[tblRent]
				WHERE [ClassId] = @sportsHallId 
				AND
				(@dateStart <= [DateEnd] and @dateEnd >= [DateStart])
				AND [Deleted] = 0)
	BEGIN
		;THROW 70004, N'Class is rented.', 1;
	END

	INSERT INTO tblRent
				(CustomerId,
				ClassId,
				DateStart,
				DateEnd,
				Cost,
				Deleted)
			VALUES 
				(@customerId, 
				@sportsHallId,
				@dateStart,
				@dateEnd,
				@cost,
				0);

	SET @rentId = SCOPE_IDENTITY();

	COMMIT TRAN MakeRentTran;
END
GO

CREATE PROC spExtendRent
	@rentId INT,
	@newDateEnd DATETIME,
	@overpay NUMERIC(18,2)

AS	
BEGIN
	SET NOCOUNT ON;

	DECLARE @dateStart DATETIME;
	DECLARE @sportsHallId INT;

	-- Check
	IF NOT EXISTS(SELECT 1 FROM tblRent WHERE Id = @rentId AND [Deleted] = 0)
	BEGIN
		;
		THROW 80001, 'Rent item was not found', 1; 
	END

	-- Get current DateEnd of rent by @rentId
	SELECT @dateStart = DATEADD(MINUTE, 1, r.DateEnd), @sportsHallId = c.Id
	FROM tblRent r
	INNER JOIN tblClass c ON r.ClassId = c.Id
	WHERE r.Id = @rentId;

	IF (@newDateEnd <= @dateStart)
	BEGIN
		RAISERROR ('Extended date of rent cannot be less or equal than current end date.', -- Message text.
           16, -- Severity,
           1
		);
		RETURN;
	END

	IF EXISTS (SELECT 1
				FROM [tblRent]
				WHERE [ClassId] = @sportsHallId 
				AND
				(@dateStart <= [DateEnd] and @newDateEnd >= [DateStart])
				AND [Deleted] = 0)
	BEGIN
		;THROW 70004, N'Cannot extend rent. Time period is used by another rent item.', 1;
	END

	-- Update rent info(new end date)
	UPDATE tblRent
	SET 
		DateEnd = @newDateEnd,
		Cost = Cost + @overpay
	WHERE Id = @rentId
END 
GO

CREATE PROC spAddCustomer
	@firstName NVARCHAR(50),
	@lastName NVARCHAR(50),
	@phone NVARCHAR(30),

	@customerId INT OUT

AS
BEGIN
	SET NOCOUNT ON;

	IF EXISTS(SELECT 1 FROM tblCustomer WHERE Phone = @phone)
	BEGIN
		;THROW 90001, N'Customer''s phone is already used.', 1;
	END
	
	INSERT INTO tblCustomer (FirstName, LastName, Phone)
	VALUES (@firstName, @lastName, @phone);

	SET @customerId = SCOPE_IDENTITY();
END
GO

CREATE PROC spAddSportsHall
	@hallTypeId INT,
	@area INT,
	@rate NUMERIC(18,2),

	@sportsHallId INT OUT

AS
BEGIN
	SET NOCOUNT ON;
	
	INSERT INTO tblClass(ClassTypeId, Area, Rate) 
	VALUES (@hallTypeId, @area, @rate);

	SET @sportsHallId = SCOPE_IDENTITY();
END
GO

CREATE PROC spAddSportsHallType
	@name NVARCHAR(50),

	@hallTypeId INT OUT
AS
BEGIN
	SET NOCOUNT ON;

	IF EXISTS(SELECT 1 FROM tblClassType WHERE Name = @name)
	BEGIN
		;THROW 90001, N'Sports hall type with this name is already exists.', 1;
	END
	
	INSERT INTO tblClassType(Name) 
	VALUES (@name);

	SET @hallTypeId = SCOPE_IDENTITY();
END


