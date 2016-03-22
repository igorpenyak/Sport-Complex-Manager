USE [SportsComplex];
GO

ALTER VIEW vPriceList 
AS
	SELECT c.Id, c.ClassTypeId as [TypeId], ct.Name as [TypeName], c.Area, c.Rate
	FROM [tblClass] c
	INNER JOIN [tblClassType] ct  ON c.ClassTypeId = ct.Id;
GO

ALTER VIEW vFreeSportsHalls
AS
	SELECT c.Id, c.ClassTypeId as [TypeId], ct.Name as [TypeName], c.Area, c.Rate, c.[Status]
	FROM [tblClass] c
	INNER JOIN [tblClassType] ct  ON c.ClassTypeId = ct.Id
	WHERE c.[Status] = 0
GO