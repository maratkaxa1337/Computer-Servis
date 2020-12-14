CREATE DATABASE [dbcomp]

USE [dbcomp]

GO

CREATE TABLE [Role] (

[RoleID]	NCHAR(1)			NOT NULL,
[Title]		NVARCHAR(30)		NOT NULL,
CONSTRAINT PK_Role_RoleID PRIMARY KEY ([RoleID])

)

GO
INSERT INTO [Role] ([RoleID],[Title]) VALUES ('A', 'Администратор')
INSERT INTo [Role] ([RoleID],[Title]) VALUES ('U','Пользователь')

CREATE TABLE [SignIn] (

[ID]	INT IDENTITY (0 ,1),
[Username]	NVARCHAR(50)			NOT NULL,
[Password]	NVARCHAR(50)			NOT NULL,
[IDRole] NCHAR(1) CONSTRAINT FK_SignIn_IDRole_Role_RoleID FOREIGN KEY REFERENCES [Role] ([RoleID])
CONSTRAINT PK_SignIn_ID PRIMARY KEY ([ID])

)

GO
INSERT INTO [SignIn] ([Username],[Password],[IDRole]) VALUES ('maratkaxa','1234','A')
INSERT INTO [SignIn] ([Username],[Password],[IDRole]) VALUES ('maratkaxa1','4321','U')