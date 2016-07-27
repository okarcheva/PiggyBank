USE [PiggyBank]
GO

SET IDENTITY_INSERT OperationType ON;
GO

INSERT INTO OperationType (ID, Value)
VALUES 
(1, 'Planned'),
(2, 'Actual')
GO

SET IDENTITY_INSERT OperationType OFF;
GO