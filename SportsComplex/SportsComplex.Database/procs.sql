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
	@moneyChange NUMERIC(18, 4) OUT

AS
BEGIN
	SET NOCOUNT ON;

	SELECT @moneyChange = (Cost - DATEDIFF(HOUR, GETDATE(), r.DateEnd) * c.Rate)
	FROM tblRent r
	INNER JOIN tblClass c ON r.ClassId = c.Id
	WHERE r.id = @rentID;

	IF NOT EXISTS(SELECT 1 FROM tblRent WHERE Id = @rentID AND [Deleted] = 0)
	BEGIN
		;
		THROW 80001, 'Rent item was not found', 1; 
	END
	-- Set class status "Free"
	UPDATE c
	SET c.[Status] = 0
	from tblClass c
    INNER JOIN tblRent r ON c.Id = r.ClassId
	WHERE r.Id = @rentID;
	
	PRINT 'CLass status changed';

	-- Mark record as deleted
	UPDATE tblRent 
	SET Deleted = 1
	WHERE Id = @rentID;

	PRINT 'Rent marked as deleted';

END
GO

CREATE PROC spMakeRent
	@renterId INT,
	@sportsHallId INT,
	@dateStart DATETIME,
	@dateEnd DATETIME,
	@cost NUMERIC(18,4),

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
	END
	
	BEGIN TRAN MakeRentTran
    WITH MARK N'Making a new rent record';

	INSERT INTO tblRent
				(RenterId,
				ClassId,
				DateStart,
				DateEnd,
				Cost,
				Deleted)
			VALUES 
				(@renterId, 
				@sportsHallId,
				@dateStart,
				@dateEnd,
				@cost,
				0);

	SET @rentId = SCOPE_IDENTITY();

	COMMIT TRAN MakeRentTran;
END
GO