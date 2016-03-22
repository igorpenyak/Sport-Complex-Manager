USE [SportsComplex];

DROP VIEW vPriceList;
GO
DROP PROC spCheckUser;
DROP PROC spRemoveRent;
DROP PROC spMakeRent;
GO

DROP TABLE [tblRent];
DROP TABLE [tblClass];
DROP TABLE [tblClassType];
DROP TABLE [tblRenter];
DROP TABLE [tblUser];
GO
--DROP DATABASE SportsComplex;