USE [SportsComplex];

DROP VIEW vPriceList;
GO

DROP PROC spCheckUser;
DROP PROC spMakeRent;
DROP PROC spRemoveRent;
DROP PROC spGetRents;
DROP PROC spAddRenter;
DROP PROC spAddSportsHall;
DROP PROC spExtendRent;

GO

DROP TABLE [tblRent];
DROP TABLE [tblClass];
DROP TABLE [tblClassType];
DROP TABLE [tblRenter];
DROP TABLE [tblUser];
GO
--DROP DATABASE SportsComplex;