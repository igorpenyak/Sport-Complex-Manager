USE [SportsComplex];
GO

CREATE VIEW vPriceList 
AS
	SELECT c.Id, c.ClassTypeId as [TypeId], ct.Name as [TypeName], c.Area, c.Rate
	FROM [tblClass] c
	INNER JOIN [tblClassType] ct  ON c.ClassTypeId = ct.Id;
GO

CREATE VIEW vFreeSportsHalls
AS
	SELECT c.Id, c.ClassTypeId as [TypeId], ct.Name as [TypeName], c.Area, c.Rate, c.[Status]
	FROM [tblClass] c
	INNER JOIN [tblClassType] ct  ON c.ClassTypeId = ct.Id
	WHERE c.[Status] = 0
GO