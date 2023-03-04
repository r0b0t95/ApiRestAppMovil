# Castro Carazo Progra6 Proyecto Final

### Authors
- Robert H. Chaves Perez: https://github.com/r0b0t95
- Steven Gabriel Carrillo Jimenez: https://github.com/stevenkart
---


## `Database`

CREATE DATABASE P620231_AutoAppo;
GO

USE P620231_AutoAppo;
GO

CREATE TABLE [User] (UserID int IDENTITY NOT NULL, [Name] varchar(255) NOT NULL, Email varchar(255) NOT NULL, PhoneNumber varchar(255) NOT NULL, LoginPassword varchar(255) NOT NULL, CardID varchar(255) NULL, [Address] varchar(255) NULL, UserRoleID int NOT NULL, UserStatusID int NOT NULL, PRIMARY KEY (UserID));

CREATE TABLE UserRole (UserRoleID int IDENTITY NOT NULL, UserRoleDescription varchar(255) NOT NULL, PRIMARY KEY (UserRoleID));

CREATE TABLE Schedule (ScheduleID int IDENTITY NOT NULL, ScheduleDateStart date NOT NULL, ScheduleDateEnd date NOT NULL, InitialTime int NOT NULL, FinalTime int NOT NULL, Notes varchar(5000) NULL, PromoDay bit DEFAULT '0' NULL, Active bit DEFAULT '1' NOT NULL, PRIMARY KEY (ScheduleID));

CREATE TABLE Appointment (AppointmentID int IDENTITY NOT NULL, AppoDate date NOT NULL, AppoStart int NOT NULL, AppoEnd int NOT NULL, CreationDate date DEFAULT GETDATE() NOT NULL, Notes varchar(5000) NULL, UserID int NOT NULL, ServiceID int NOT NULL, ScheduleID int NOT NULL, AppoStatusID int NOT NULL, PRIMARY KEY (AppointmentID));

CREATE TABLE [Service] (ServiceID int IDENTITY NOT NULL, ServiceDescription varchar(255) NOT NULL, ServiceTimeSpan int NOT NULL, ServiceEstimatedCost decimal(18, 2) DEFAULT 0 NOT NULL, Active bit DEFAULT '1' NOT NULL, PRIMARY KEY (ServiceID));

CREATE TABLE UserStatus (UserStatusID int IDENTITY NOT NULL, UserStatuDescription varchar(255) NOT NULL, PRIMARY KEY (UserStatusID));

CREATE TABLE [Appointment Status] (AppoStatusID int IDENTITY NOT NULL, AppoStatusDescription varchar(255) NOT NULL, PRIMARY KEY (AppoStatusID));

ALTER TABLE [User] ADD CONSTRAINT FKUser854768 FOREIGN KEY (UserRoleID) REFERENCES UserRole (UserRoleID);

ALTER TABLE [User] ADD CONSTRAINT FKUser943402 FOREIGN KEY (UserStatusID) REFERENCES UserStatus (UserStatusID);

ALTER TABLE Appointment ADD CONSTRAINT FKAppointmen160080 FOREIGN KEY (UserID) REFERENCES [User] (UserID);

ALTER TABLE Appointment ADD CONSTRAINT FKAppointmen691060 FOREIGN KEY (ServiceID) REFERENCES Service (ServiceID);

ALTER TABLE Appointment ADD CONSTRAINT FKAppointmen559984 FOREIGN KEY (ScheduleID) REFERENCES Schedule (ScheduleID);

ALTER TABLE Appointment ADD CONSTRAINT FKAppointmen475052 FOREIGN KEY (AppoStatusID) REFERENCES [Appointment Status] (AppoStatusID);

