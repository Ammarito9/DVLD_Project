
--FKs constraints

----Persons
ALTER TABLE Persons 
ADD CONSTRAINT FK_Persons_Countries FOREIGN KEY (NationalityCountryID) REFERENCES Countries(ID);

----LocalDrivingLinceseApplications
ALTER TABLE LocalDrivingLinceseApplications 
ADD CONSTRAINT FK_LocalDrivingLinceseApplications_LicenseClasses FOREIGN KEY (LicenseClassID) REFERENCES LicenseClasses(ID);

ALTER TABLE LocalDrivingLinceseApplications 
ADD CONSTRAINT FK_LocalDrivingLinceseApplications_Applications FOREIGN KEY (ApplicationID) REFERENCES Applications(ID);

----InternationalLicenses
ALTER TABLE InternationalLicenses 
ADD CONSTRAINT FK_InternationalLicenses_Drivers FOREIGN KEY (DriverID) REFERENCES Drivers(ID);

ALTER TABLE InternationalLicenses 
ADD CONSTRAINT FK_InternationalLicenses_Applications FOREIGN KEY (ApplicationID) REFERENCES Applications(ID);

ALTER TABLE InternationalLicenses 
ADD CONSTRAINT FK_InternationalLicenses_Linceses FOREIGN KEY (IssuedUsingLocalLicenseID) REFERENCES Licenses(ID);

ALTER TABLE InternationalLicenses 
ADD CONSTRAINT FK_InternationalLicenses_Users FOREIGN KEY (CreatedByUserID) REFERENCES Users(ID);
----Licenses
ALTER TABLE Licenses 
ADD CONSTRAINT FK_Licenses_Applications FOREIGN KEY (ApplicationID) REFERENCES Applications(ID);

ALTER TABLE Licenses 
ADD CONSTRAINT FK_Licenses_Drivers FOREIGN KEY (DriverID) REFERENCES Drivers(ID);

ALTER TABLE Licenses 
ADD CONSTRAINT FK_Licenses_LicenseClasses FOREIGN KEY (LicenseClassID) REFERENCES LicenseClasses(ID);

ALTER TABLE Licenses 
ADD CONSTRAINT FK_Licenses_Users FOREIGN KEY (CreatedByUserID) REFERENCES Users(ID);

----Drivers
ALTER TABLE Drivers 
ADD CONSTRAINT FK_Drivers_Persons FOREIGN KEY (PersonID) REFERENCES Persons(ID);

ALTER TABLE Drivers 
ADD CONSTRAINT FK_Drivers_Users FOREIGN KEY (CreatedByUserID) REFERENCES Users(ID);

----Users
ALTER TABLE Users 
ADD CONSTRAINT FK_Users_Persons FOREIGN KEY (PersonID) REFERENCES Persons(ID);

ALTER TABLE Users DROP FK_Users_Persons;

----DetenedLicenses
ALTER TABLE DetenedLicenses 
ADD CONSTRAINT FK_DetenedLicenses_Licenses FOREIGN KEY (LicenseID) REFERENCES Licenses(ID);

ALTER TABLE DetenedLicenses 
ADD CONSTRAINT FK_DetenedLicenses_Applications FOREIGN KEY (ReleaseApplicationID) REFERENCES Applications(ID);

ALTER TABLE DetenedLicenses 
ADD CONSTRAINT FK_DetenedLicenses_Users_Create FOREIGN KEY (CreatedByUserID) REFERENCES Users(ID);

ALTER TABLE DetenedLicenses 
ADD CONSTRAINT FK_DetenedLicenses_Users_Released FOREIGN KEY (ReleasedByUserID) REFERENCES Users(ID);

----Applications
ALTER TABLE Applications 
ADD CONSTRAINT FK_Applications_Services FOREIGN KEY (ServiceID) REFERENCES Services(ID);

ALTER TABLE Applications 
ADD CONSTRAINT FK_Applications_Persons FOREIGN KEY (PersonID) REFERENCES Persons(ID);

ALTER TABLE Applications 
ADD CONSTRAINT FK_Applications_ApplicationStatuses FOREIGN KEY (ApplicationStatusID) REFERENCES ApplicationStatuses(ID);

ALTER TABLE Applications 
ADD CONSTRAINT FK_Applications_Users FOREIGN KEY (CreatedByUserID) REFERENCES Users(ID);

----Tests
ALTER TABLE Tests 
ADD CONSTRAINT FK_Tests_TestAppointments FOREIGN KEY (TestAppointmentID) REFERENCES TestAppointments(ID);

ALTER TABLE Tests 
ADD CONSTRAINT FK_Tests_Users FOREIGN KEY (CreatedByUserID) REFERENCES Users(ID);

----TestAppointments
ALTER TABLE TestAppointments 
ADD CONSTRAINT FK_TestAppointments_Users FOREIGN KEY (CreatedByUserID) REFERENCES Users(ID);

ALTER TABLE TestAppointments 
ADD CONSTRAINT FK_TestAppointments_TestTypes FOREIGN KEY (TestTypeID) REFERENCES TestTypes(ID);

ALTER TABLE TestAppointments 
ADD CONSTRAINT FK_TestAppointments_Applications FOREIGN KEY (RetakeTestApplicationID) REFERENCES Applications(ID);

ALTER TABLE TestAppointments 
ADD CONSTRAINT FK_TestAppointments_LocalDrivingLinceseApplications FOREIGN KEY (LocalDrivingLinceseApplicationID) REFERENCES LocalDrivingLinceseApplications(ID);

--CHECK constraints

----InternationalLicenses
ALTER TABLE InternationalLicenses ADD CONSTRAINT CK_InternationalLicenses_IssueDate CHECK (IssueDate < GETDATE());

ALTER TABLE InternationalLicenses ADD CONSTRAINT CK_InternationalLicenses_IssueDate_ExpiryDate CHECK (IssueDate < ExpiryDate);

----Licenses
ALTER TABLE Licenses ADD CONSTRAINT CK_Licenses_IssueDate CHECK (IssueDate < GETDATE());

ALTER TABLE Licenses ADD CONSTRAINT CK_Licenses_IssueDate_ExpiryDate CHECK (IssueDate < ExpiryDate);

ALTER TABLE Licenses ADD CONSTRAINT CK_Licenses_LicenseIssueReson CHECK (LicenseIssueReson BETWEEN 1 AND 4);

----Drivers
ALTER TABLE Drivers ADD CONSTRAINT CK_Drivers_CreateDate CHECK (CreateDate >= GETDATE());

----Persons
ALTER TABLE Persons ADD CONSTRAINT CK_Persons_DateOfBirth CHECK (DateOfBirth < GETDATE());

ALTER TABLE Persons ADD CONSTRAINT CK_Persons_Email CHECK ((Email LIKE '%_@_%._%') OR (Email IS NULL));

ALTER TABLE Persons ADD CONSTRAINT CK_Persons_Gender CHECK (Gender IN ('M','F'));

----Applications
ALTER TABLE Applications ADD CONSTRAINT CK_Applications_ApplicationDate CHECK (ApplicationDate <= GETDATE());

----TestAppointments
ALTER TABLE TestAppointments ADD CONSTRAINT CK_TestAppointments_ScheduledDate CHECK (ScheduledDate >= GETDATE());


--DetenedLicenses
ALTER TABLE DetenedLicenses ADD CONSTRAINT CK_DetenedLicenses_DateOfDetain_ReleaseDate CHECK ((DateOfDetain <= ReleaseDate) OR ReleaseDate IS NULL);

ALTER TABLE DetenedLicenses ADD CONSTRAINT CK_DetenedLicenses_DetainFees CHECK (DetainFees >= 0);

----Tests
ALTER TABLE Tests ADD CONSTRAINT CK_Tests_TestResult CHECK (TestResult IN ('P','F','N'));

--UNIQUE constraints

----Licenses
ALTER TABLE Licenses ADD CONSTRAINT UQ_Licenses_LicenseNumber UNIQUE (LicenseNumber);

----Drivers
ALTER TABLE Drivers ADD CONSTRAINT UQ_Drivers_PersonID UNIQUE (PersonID);

----Users
ALTER TABLE Users ADD CONSTRAINT UQ_Users_PersonID UNIQUE (PersonID);

ALTER TABLE Users ADD CONSTRAINT UQ_Users_Username UNIQUE (Username);

----Countries
ALTER TABLE Countries ADD CONSTRAINT UQ_Countries_CountryName UNIQUE (CountryName);

----Persons
ALTER TABLE Persons ADD CONSTRAINT UQ_Persons_NationalNumber UNIQUE (NationalNumber);

----LicenseClasses
ALTER TABLE LicenseClasses ADD CONSTRAINT UQ_LicenseClasses_ClassName UNIQUE (ClassName);

----ApplicationStatuses
ALTER TABLE ApplicationStatuses ADD CONSTRAINT UQ_ApplicationStatuses_StatusName UNIQUE (StatusName);

----Services
ALTER TABLE Services ADD CONSTRAINT UQ_Services_ServiceName UNIQUE (ServiceName);

----TestTypes
ALTER TABLE TestTypes ADD CONSTRAINT UQ_TestTypes_TestTypeName UNIQUE (TestTypeName);

--DEFAULT constraints

----TestAppointments
ALTER TABLE TestAppointments
ADD CONSTRAINT DF_TestAppointments_IsLocked DEFAULT (0) FOR IsLocked;

----Users
ALTER TABLE Users
ADD CONSTRAINT DF_Users_IsActive DEFAULT (1) FOR IsActive;

--DetenedLicenses
ALTER TABLE DetenedLicenses
ADD CONSTRAINT DF_DetenedLicenses_IsReleased DEFAULT (0) FOR IsReleased;

--InternationalLicenses
ALTER TABLE InternationalLicenses
ADD CONSTRAINT DF_InternationalLicenses_IsActive DEFAULT (1) FOR IsActive;

--Licenses
ALTER TABLE Licenses
ADD CONSTRAINT DF_Licenses_IsActive DEFAULT (1) FOR IsActive;