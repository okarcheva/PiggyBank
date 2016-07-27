USE [PiggyBank]
GO

CREATE TABLE Operation
(
ID int IDENTITY(1,1) PRIMARY KEY,
Amount decimal(15,2) NOT NULL,
ID_OperationType int FOREIGN KEY REFERENCES OperationType(ID) NOT NULL,
Operation_Date date NOT NULL,
ID_Category int FOREIGN KEY REFERENCES Category(ID) NOT NULL,
ID_FamilyMember int FOREIGN KEY REFERENCES FamilyMember (ID) NOT NULL,
Notes varchar(1000) 
)

