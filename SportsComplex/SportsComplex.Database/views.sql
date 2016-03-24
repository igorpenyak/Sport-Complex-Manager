USE [SportsComplex];
GO

CREATE VIEW vPriceList 
AS
	SELECT c.Id, c.ClassTypeId as [TypeId], ct.Name as [TypeName], c.Area, c.Rate
	FROM [tblClass] c
	INNER JOIN [tblClassType] ct  ON c.ClassTypeId = ct.Id;
GO