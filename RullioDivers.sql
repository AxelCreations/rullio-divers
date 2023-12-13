/*=========	AxelCreations - Reynel Axel Perdomo   =============
--	Created:		05th - July - 2022
--  Last Modified:  13th - December - 2023
--	Description:	Database creation Script
--	Project:		RullioDivers
===============================================================*/


/*================== DATABASE CREATION ==========================*/
CREATE DATABASE RullioDiversDB
----------------------------------------------------------------*/

/*=================  DROP ORDER OF TABLES  =======================

DROP TABLE Logs;
DROP TABLE Users;
DROP TABLE UserProfiles;
DROP TABLE DiverSchools;
DROP TABLE HomePageInformation;
*/
------------------------------------------------------------------

/*=================  CREATION OF TABLES  =======================*/

use RullioDiversDB;

------------------------------------------------------------------

CREATE TABLE DiverSchools
(
	[ID] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	[Name] NVARCHAR(50) NOT NULL,
);

CREATE TABLE Users
(
	[ID] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	[Names] NVARCHAR(50) NOT NULL,
	[LastNames] NVARCHAR(50) NOT NULL,
	[Email] NVARCHAR(50) NOT NULL UNIQUE,
	[DiverSchoolID] INT NOT NULL UNIQUE FOREIGN KEY REFERENCES DiverSchools(ID),
	[License] NVARCHAR(50) NOT NULL,
	[LicenseImage] NVARCHAR(MAX) NOT NULL,
	[Role] INT NOT NULL DEFAULT 1, --0 Admin, 1 Customer, 2 Guest
	[Locked]  BIT NOT NULL DEFAULT 1,
	[PasswordSalt] VARBINARY(MAX) NOT NULL,
	[PasswordHash] VARBINARY(MAX) NOT NULL,
	[AuthToken] NVARCHAR(50) NOT NULL UNIQUE,
	[CreationDate] DATETIME NOT NULL DEFAULT GETDATE(),
	[LastUpdateDate] DATETIME,
);

CREATE TABLE Logs
(
	[ID] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	[UserID] INT NOT NULL FOREIGN KEY REFERENCES Users(ID),
	[Role] INT NOT NULL DEFAULT 1, --0 Admin, 1 Customer, 2 Guest
	[ExecutionDate] DATETIME NOT NULL DEFAULT GETDATE(),
	[Module] NVARCHAR(25) NOT NULL,
	[ActionRequested] NVARCHAR(25) NOT NULL,
	[AfectedField] NVARCHAR(25),
	[PreviousValue] NVARCHAR(100),
	[NewValue] NVARCHAR(100)
);

CREATE TABLE HomePageInformation
(
	[ID] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	[HeroTitle] NVARCHAR(60) NOT NULL,
	[HeroDescription] NVARCHAR(160) NOT NULL,
	[HeroBackground] NVARCHAR(512),
)

