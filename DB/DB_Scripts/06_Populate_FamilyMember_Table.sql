USE [PiggyBank]
GO

SET IDENTITY_INSERT FamilyMember ON;
GO

INSERT INTO FamilyMember(ID, Name)
VALUES(-1, 'Me')
GO

SET IDENTITY_INSERT FamilyMember OFF;
GO

INSERT INTO FamilyMember(Name)
VALUES	('Cat'),
		('Wife'),
		('Mother')

