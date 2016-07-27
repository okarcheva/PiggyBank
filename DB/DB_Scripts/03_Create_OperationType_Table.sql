USE [PiggyBank]
GO

CREATE TABLE OperationType
(
ID int IDENTITY(1,1) PRIMARY KEY,
Value varchar(20) NOT NULL,
)