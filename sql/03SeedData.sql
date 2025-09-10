INSERT INTO Services (ServiceName, ServiceFee)
VALUES 
('First-time driving license issuance',0),
('Retake test service',5),
('Driving license renewal',10),
('Replacement of lost license',20),
('Replacement of damaged license',20),
('Release of detained license',0),
('International driving license issuance',20);

INSERT INTO Tests (TestName, TestFee)
VALUES
('Medical / Vision Test',10),
('Theoretical Test',20),
('Practical Driving Test',0);

INSERT INTO ApplicationStatuses (StatusName)
VALUES 
('New'),
('Canceled'),
('Completed');

INSERT INTO LicenseStatuses (StatusName)
VALUES 
('New'),
('Renewal'),
('Replacement Lost'),
('Replacement Damaged');

INSERT INTO LicenseClasses (LicenseClass, ClassDescription, ValidityLengthInYears, MinimumAllowedAge, ClassFees)
VALUES 
('Class 1 – Small Motorcycle License','Allows driving small motorcycles.',5,18,15),
('Class 2 – Heavy Motorcycle License','Allows driving heavy and powerful motorcycles',5,21,30),
('Class 3 – Regular Driving License','Allows driving light vehicles and personal cars',10,18,20),
('Class 4 – Commercial Driving License','Allows driving taxis and limousines.',10,21,200),
('Class 5 – Agricultural Vehicles License','Allows driving all agricultural vehicles (Tractors, etc.).',10,21,50),
('Class 6 – Small and Medium Bus License','Allows driving small and medium buses.',10,21,250),
('Class 7 – Trucks and Heavy Vehicles License','Allows driving trucks and heavy vehicles (buses, large trucks).',10,21,300);

INSERT INTO Nationalities (NationalityName)
VALUES
('Turkish'),
('Syrian'),
('Egyptian'),
('Jordanian'),
('Saudi'),
('Iraqi'),
('Lebanese'),
('Palestinian'),
('Yemeni'),
('Kuwaiti');
