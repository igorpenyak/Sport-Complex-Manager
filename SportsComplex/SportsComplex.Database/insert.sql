USE [SportsComplex];

SET IDENTITY_INSERT tblClassType ON
INSERT INTO tblClassType (Id, Name) VALUES
		(1, 'BasketBall'),
		(2, 'Football'),
		(3, 'Swimming pool'),
		(4, 'Tennis'),
		(5, 'Boxing'),
		(6, 'Judo'),
		(7, 'Karate'),
		(8, 'Sambo'),
		(9, 'Gym'),
		(10, 'Volleyball')
SET IDENTITY_INSERT tblClassType OFF

SET IDENTITY_INSERT tblClass ON
INSERT INTO tblClass(Id, ClassTypeId, Area, Rate) VALUES
		(1, 1, 250, 15),
		(2, 1, 225, 12),
		(3, 9, 60, 10),
		(4, 10, 180, 20),
		(5, 8, 80, 20),
		(6, 5, 100, 23),
		(7, 4, 200, 40),
		(8, 3, 855, 30),
		(9, 6, 120, 25),
		(10, 2, 250, 15),
		(11, 2, 225, 12),
		(12, 7, 115, 35)
SET IDENTITY_INSERT tblClass OFF

SET IDENTITY_INSERT tblCustomer ON
INSERT INTO tblCustomer (Id, LastName, FirstName, Phone) VALUES
		(1, 'Smith', 'Jonh', '754-3010'),
		(2, 'Depp', 'Johnny', '854-1234'),
		(3, 'Crowe', 'Russel', '123-567'),
		(4, 'Pitt', 'Brad', '798-790'),
		(5, 'DiCaprio', 'Leonardo', '777-111'),
		(6, 'Cruise', 'Tom', '911-119')
SET IDENTITY_INSERT tblCustomer OFF

SET IDENTITY_INSERT tblRent ON
INSERT INTO tblRent (Id, CustomerId, ClassId, DateStart, DateEnd, Cost) VALUES
		(1, 4, 3, GetDate(), DateAdd(hour, 3, GetDate()), 1000),
		(2, 1, 5, GetDate(), DateAdd(hour, 2, GetDate()), 300),
		(3, 2, 8, GetDate(), DateAdd(hour, 8, GetDate()), 800),
		(4, 4, 7, GetDate(), DateAdd(hour, 3, GetDate()), 150),
		(5, 3, 9, GetDate(), DateAdd(hour, 5, GetDate()), 250)
SET IDENTITY_INSERT tblRent OFF

SET IDENTITY_INSERT tblUser ON
INSERT INTO tblUser (Id, LastName, FirstName, [Login], [Password], [Disabled]) VALUES
-- User: admin, Password: superuser
	(1, 'Surname', 'Name', 'admin', '0baea2f0ae20150db78f58cddac442a9', 0)
SET IDENTITY_INSERT tblUser OFF
