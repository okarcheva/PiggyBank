USE [PiggyBank]
GO

INSERT INTO Operation(Amount, ID_OperationType, Operation_Date, ID_Category, ID_FamilyMember)
VALUES	(100, 2, GETDATE(), -1, -1),
		(-1000, 1, GETDATE(), -1, -1),
		(2000, 1, GETDATE(), -1, -1)

