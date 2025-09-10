
--FKs constraints

----Persons
ALTER TABLE Persons 
ADD CONSTRAINT FK_Persons_Nationalities FOREIGN KEY (NationalityID) REFERENCES Nationalities(ID);

----Licenses
ALTER TABLE Licenses 
ADD CONSTRAINT FK_Licenses_Drivers FOREIGN KEY (DriverID) REFERENCES Drivers(ID);

ALTER TABLE Licenses 
ADD CONSTRAINT FK_Licenses_Persons FOREIGN KEY (PersonID) REFERENCES Persons(ID);

ALTER TABLE Licenses 
ADD CONSTRAINT FK_Licenses_LicenseClasses FOREIGN KEY (LicenseClassID) REFERENCES LicenseClasses(ID);

ALTER TABLE Licenses 
ADD CONSTRAINT FK_Licenses_LicenseStatuses FOREIGN KEY (LicenseStatusID) REFERENCES LicenseStatuses(ID);

----Drivers
ALTER TABLE Drivers 
ADD CONSTRAINT FK_Drivers_Persons FOREIGN KEY (PersonID) REFERENCES Persons(ID);

----Users
ALTER TABLE Users 
ADD CONSTRAINT FK_Users_Persons FOREIGN KEY (PersonID) REFERENCES Persons(ID);

----LicenseDetentions
ALTER TABLE LicenseDetentions 
ADD CONSTRAINT FK_LicenseDetentions_Licenses FOREIGN KEY (LicenseID) REFERENCES Licenses(ID);

ALTER TABLE LicenseDetentions 
ADD CONSTRAINT FK_LicenseDetentions_Applications FOREIGN KEY (ApplicationID) REFERENCES Applications(ID);

----Applications
ALTER TABLE Applications 
ADD CONSTRAINT FK_Applications_Licenses FOREIGN KEY (LicenseID) REFERENCES Licenses(ID);

ALTER TABLE Applications 
ADD CONSTRAINT FK_Applications_Services FOREIGN KEY (ServiceID) REFERENCES Services(ID);

ALTER TABLE Applications 
ADD CONSTRAINT FK_Applications_Persons FOREIGN KEY (PersonID) REFERENCES Persons(ID);

ALTER TABLE Applications 
ADD CONSTRAINT FK_Applications_ApplicationStatuses FOREIGN KEY (ApplicationStatusID) REFERENCES ApplicationStatuses(ID);

ALTER TABLE Applications 
ADD CONSTRAINT FK_Applications_LicenseClasses FOREIGN KEY (RequestedLicenseClassID) REFERENCES LicenseClasses(ID);

----TestAppointments
ALTER TABLE TestAppointments 
ADD CONSTRAINT FK_TestAppointments_Tests FOREIGN KEY (TestID) REFERENCES Tests(ID);

ALTER TABLE TestAppointments 
ADD CONSTRAINT FK_TestAppointments_Applications FOREIGN KEY (ApplicationID) REFERENCES Applications(ID);

--CHECK constraints

----Licenses
ALTER TABLE Licenses ADD CONSTRAINT CK_Licenses_LicenseType CHECK (LicenseType IN ('I','L'));

ALTER TABLE Licenses ADD CONSTRAINT CK_Licenses_IssueDate CHECK (IssueDate < GETDATE());

ALTER TABLE Licenses ADD CONSTRAINT CK_Licenses_IssueDate_ExpiryDate CHECK (IssueDate < ExpiryDate);

----Persons
ALTER TABLE Persons ADD CONSTRAINT CK_Persons_DateOfBirth CHECK (DateOfBirth < GETDATE());

ALTER TABLE Persons ADD CONSTRAINT CK_Persons_Email CHECK ((Email LIKE '%_@_%._%') OR (Email IS NULL));

----Applications
ALTER TABLE Applications ADD CONSTRAINT CK_Applications_ApplicationDate CHECK (ApplicationDate <= GETDATE());

----TestAppointments
ALTER TABLE TestAppointments ADD CONSTRAINT CK_TestAppointments_ScheduledDate CHECK (ScheduledDate >= GETDATE());

ALTER TABLE TestAppointments ADD CONSTRAINT CK_TestAppointments_TakenDate CHECK ((TakenDate <= GETDATE()) OR TakenDate IS NULL);

ALTER TABLE TestAppointments ADD CONSTRAINT CK_TestAppointments_TestResult CHECK (TestResult IN ('P','F','N'));

ALTER TABLE TestAppointments ADD CONSTRAINT CK_TestAppointments_Score CHECK (Score BETWEEN 0 AND 100);

--LicenseDetentions
ALTER TABLE LicenseDetentions ADD CONSTRAINT CK_LicenseDetentions_DateOfDetention_ReleaseDate CHECK ((DateOfDetention <= ReleaseDate) OR ReleaseDate IS NULL);

--UNIQUE constraints

----LicenseStatuses
ALTER TABLE LicenseStatuses ADD CONSTRAINT UQ_LicenseStatuses_StatusName UNIQUE (StatusName);

----Licenses
ALTER TABLE Licenses ADD CONSTRAINT UQ_Licenses_LicenseNumber UNIQUE (LicenseNumber);

----Drivers
ALTER TABLE Drivers ADD CONSTRAINT UQ_Drivers_PersonID UNIQUE (PersonID);

----Users
ALTER TABLE Users ADD CONSTRAINT UQ_Users_PersonID UNIQUE (PersonID);

ALTER TABLE Users ADD CONSTRAINT UQ_Users_Username UNIQUE (Username);

----Nationalities
ALTER TABLE Nationalities ADD CONSTRAINT UQ_Nationalities_NationalityName UNIQUE (NationalityName);

----Persons
ALTER TABLE Persons ADD CONSTRAINT UQ_Persons_PersonalPhotoPath UNIQUE (PersonalPhotoPath);

ALTER TABLE Persons ADD CONSTRAINT UQ_Persons_NationalNumber UNIQUE (NationalNumber);

----LicenseClasses
ALTER TABLE LicenseClasses ADD CONSTRAINT UQ_LicenseClasses_LicenseClass UNIQUE (LicenseClass);

----LicenseDetentions
ALTER TABLE LicenseDetentions ADD CONSTRAINT UQ_LicenseDetentions_LicenseID_ApplicationID UNIQUE (LicenseID, ApplicationID);

----Applications
ALTER TABLE Applications ADD CONSTRAINT UQ_Applications_ApplicationNumber UNIQUE (ApplicationNumber);

----ApplicationStatuses
ALTER TABLE ApplicationStatuses ADD CONSTRAINT UQ_ApplicationStatuses_StatusName UNIQUE (StatusName);

----TestAppointments
ALTER TABLE TestAppointments ADD CONSTRAINT UQ_TestAppointments_ApplicationID_TestID UNIQUE (ApplicationID, TestID);

----Services
ALTER TABLE Services ADD CONSTRAINT UQ_Services_ServiceName UNIQUE (ServiceName);

----Tests
ALTER TABLE Tests ADD CONSTRAINT UQ_Tests_TestName UNIQUE (TestName);

--DEFAULT constraints

----TestAppointments
ALTER TABLE TestAppointments
ADD CONSTRAINT DF_TestAppointments_TestResult DEFAULT ('N') FOR TestResult;

ALTER TABLE Users
ADD CONSTRAINT DF_Users_IsActive DEFAULT (1) FOR IsActive;

--Applications
ALTER TABLE Applications
ADD CONSTRAINT DF_Applications_ApplicationFeePaid DEFAULT (0) FOR ApplicationFeePaid;