USE [master]
GO

IF EXISTS (SELECT NAME FROM SYS.databases WHERE NAME = N'PiggyBank')
DROP DATABASE [PiggyBank]
GO

USE [master]
GO

--Creating Database [PiggyBank]
PRINT 'Creating Database...'
CREATE DATABASE [PiggyBank]
GO
PRINT 'Database created successfully...'
