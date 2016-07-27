USE [PiggyBank]
GO

SET IDENTITY_INSERT Category ON
GO

INSERT INTO Category(ID, Name, Colour)
VALUES(-1, 'All', 'LightGray')
GO

SET IDENTITY_INSERT Category OFF
GO

INSERT INTO Category (Name, Colour)
VALUES	('Supermarket','ForestGreen'),
		('Electronics','Yellow'),
		('Vacation','LightSeaGreen'),
		('Utilities','OrangeRed'),
		('Apartment','PaleGoldenrod')