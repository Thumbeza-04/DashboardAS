-- Database Initialization Script for Driving School Management System
-- Run this script to create the database and insert sample data
-- Updated: June 16, 2025 - PaymentMJ table uses StudentID directly (not BookingID)

-- Create Database (if using SQL Server)
-- CREATE DATABASE DrivingSchoolMJ;
-- USE DrivingSchoolMJ;

-- Table: VehicleMJ
CREATE TABLE VehicleMJ (
    LicensePlateID VARCHAR(20) PRIMARY KEY,
    TransmissionType VARCHAR(20),
    FuelType VARCHAR(20),
    Make VARCHAR(50),
    VehicleType VARCHAR(30)
);

-- Table: InstructorMJ
CREATE TABLE InstructorMJ (
    InstructorID INT IDENTITY(1,1) PRIMARY KEY,
    LicensePlateID VARCHAR(20),
    LicenseNumber VARCHAR(50),
    ExpertiseLevel VARCHAR(30),
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    Gender VARCHAR(10),
    ContactNumber VARCHAR(20),
    Email VARCHAR(100),
    FOREIGN KEY (LicensePlateID) REFERENCES VehicleMJ(LicensePlateID)
);

-- Table: StaffMJ
CREATE TABLE StaffMJ (
    StaffID INT IDENTITY(1,1) PRIMARY KEY,
    StaffName VARCHAR(50),
    StaffSurname VARCHAR(50),
    StaffEmail VARCHAR(100),
    StaffCellNumber VARCHAR(20),
    IDNo VARCHAR(20),
    Gender VARCHAR(10),
    StreetNumber VARCHAR(10),
    StreetName VARCHAR(50),
    City VARCHAR(50),
    PostalCode VARCHAR(10),
    Role VARCHAR(30),
    Status VARCHAR(20)
);

-- Table: StudentMJ
CREATE TABLE StudentMJ (
    StudentID INT IDENTITY(1,1) PRIMARY KEY,
    Name VARCHAR(50),
    Surname VARCHAR(50),
    Email VARCHAR(100),
    PhoneNumber VARCHAR(20),
    IDNo VARCHAR(20),
    Gender VARCHAR(10),
    StreetNumber VARCHAR(10),
    StreetName VARCHAR(50),
    City VARCHAR(50),
    PostalCode VARCHAR(10),
    Status VARCHAR(20),
    PackageName VARCHAR(50),
    FOREIGN KEY (PackageName) REFERENCES PackageMJ(PackageName)
);

-- Table: TimeSlotMJ
CREATE TABLE TimeSlotMJ (
    TimeSlotID INT IDENTITY(1,1) PRIMARY KEY,
    StartTime TIME,
    EndTime TIME,
);

-- Table: PackageMJ
CREATE TABLE PackageMJ (
    PackageName VARCHAR(50) PRIMARY KEY,
    Code VARCHAR(20),
    NoOfLessons INT,
    Price DECIMAL(10, 2)
);

-- Table: LessonBookingMJ
CREATE TABLE LessonBookingMJ (
    BookingID INT IDENTITY(1,1) PRIMARY KEY,
    StudentID INT,
    InstructorID INT,
    VehicleID VARCHAR(20),
    PackageID VARCHAR(50),
    TimeSlotID INT,
    Date DATE,
    Time TIME,
    Status VARCHAR(20),
    FOREIGN KEY (StudentID) REFERENCES StudentMJ(StudentID),
    FOREIGN KEY (InstructorID) REFERENCES InstructorMJ(InstructorID),
    FOREIGN KEY (VehicleID) REFERENCES VehicleMJ(LicensePlateID),
    FOREIGN KEY (PackageID) REFERENCES PackageMJ(PackageName),
    FOREIGN KEY (TimeSlotID) REFERENCES TimeSlotMJ(TimeSlotID)
);

-- Table: LessonAttendanceMJ
CREATE TABLE LessonAttendanceMJ (
    AttandanceID INT IDENTITY(1,1) PRIMARY KEY,
    InstructorID INT,
    StudentID INT,
    BookingID INT,
    Date DATE,
    AttendanceStatus VARCHAR(20),
    FOREIGN KEY (InstructorID) REFERENCES InstructorMJ(InstructorID),
    FOREIGN KEY (StudentID) REFERENCES StudentMJ(StudentID),
    FOREIGN KEY (BookingID) REFERENCES LessonBookingMJ(BookingID)
);

-- Table: ReviewMJ
CREATE TABLE ReviewMJ (
    ReviewID INT IDENTITY(1,1) PRIMARY KEY,
    BookingID INT,
    StudentID INT,
    Rating INT,
    Comment TEXT,
    ReviewDate DATE,
    FOREIGN KEY (BookingID) REFERENCES LessonBookingMJ(BookingID),
    FOREIGN KEY (StudentID) REFERENCES StudentMJ(StudentID)
);

-- Table: PaymentMJ
-- Payments are linked directly to students (not through bookings)
-- PackageName is retrieved from StudentMJ table when needed
CREATE TABLE PaymentMJ (
    PaymentID INT IDENTITY(1,1) PRIMARY KEY,
    StudentID INT NOT NULL,
    PaymentDate DATE,
    AmountPaid DECIMAL(10,2),
    AmountDue DECIMAL(10,2),
    PaymentMethod VARCHAR(30),
    FOREIGN KEY (StudentID) REFERENCES StudentMJ(StudentID)
);

-- Table: UserLoginMJ
CREATE TABLE UserLoginMJ (
    UserID INT IDENTITY(1,1) PRIMARY KEY,
    Username VARCHAR(50) UNIQUE,
    PasswordHash VARCHAR(255),
    Role VARCHAR(30) CHECK (Role IN ('Reception', 'Instructor', 'Manager')),
    StaffID INT,
    FOREIGN KEY (StaffID) REFERENCES StaffMJ(StaffID)
);

-- Insert Sample Data

-- Insert Vehicles
INSERT INTO VehicleMJ (LicensePlateID, TransmissionType, FuelType, Make, VehicleType) VALUES
('ABC123GP', 'Manual', 'Petrol', 'Toyota Corolla', 'Sedan'),
('DEF456GP', 'Automatic', 'Petrol', 'Honda Civic', 'Sedan'),
('GHI789GP', 'Manual', 'Diesel', 'Volkswagen Polo', 'Hatchback'),
('JKL012GP', 'Automatic', 'Petrol', 'Nissan Micra', 'Hatchback');

-- Insert Staff
INSERT INTO StaffMJ (StaffName, StaffSurname, StaffEmail, StaffCellNumber, IDNo, Gender, StreetNumber, StreetName, City, PostalCode, Role, Status) VALUES
('David', 'Mabuza', 'david.m@tlgdriving.com', '076-123-4567', '8001015009088', 'Male', '123', 'Main Street', 'Johannesburg', '2000', 'Instructor', 'Active'),
('Jessica', 'Nkosi', 'jessica.n@tlgdriving.com', '083-234-5678', '9002026008076', 'Female', '456', 'Oak Avenue', 'Pretoria', '0002', 'Instructor', 'Active'),
('Sibusiso', 'Thembeni', 'sbu.t@tlgdriving.com', '061-345-6789', '8503037009054', 'Male', '789', 'Pine Road', 'Durban', '4001', 'Instructor', 'Active'),
('Amanda', 'Black', 'amanda.b@tlgdriving.com', '060-456-7890', '9104048008032', 'Female', '321', 'Elm Street', 'Cape Town', '8001', 'Instructor', 'On Leave'),
('Sarah', 'Johnson', 'sarah.j@tlgdriving.com', '072-567-8901', '8705059009021', 'Female', '654', 'Maple Drive', 'Johannesburg', '2000', 'Reception', 'Active');

-- Insert Instructors
INSERT INTO InstructorMJ (LicensePlateID, LicenseNumber, ExpertiseLevel, FirstName, LastName, Gender, ContactNumber, Email) VALUES
('ABC123GP', 'DI4852', 'Senior', 'David', 'Mabuza', 'Male', '076-123-4567', 'david.m@tlgdriving.com'),
('DEF456GP', 'DI7834', 'Intermediate', 'Jessica', 'Nkosi', 'Female', '083-234-5678', 'jessica.n@tlgdriving.com'),
('GHI789GP', 'DI6721', 'Senior', 'Sibusiso', 'Thembeni', 'Male', '061-345-6789', 'sbu.t@tlgdriving.com'),
('JKL012GP', 'DI9023', 'Intermediate', 'Amanda', 'Black', 'Female', '060-456-7890', 'amanda.b@tlgdriving.com');

-- Insert Students
INSERT INTO StudentMJ (Name, Surname, Email, PhoneNumber, IDNo, Gender, StreetNumber, StreetName, City, PostalCode, Status, PackageName) VALUES
('Aphelele', 'Shabane', 'aphelele.s@email.com', '061-555-1234', '0001015009088', 'Male', '12', 'Victoria Street', 'Johannesburg', '2000', 'Active', 'Basic Package'),
('Siya', 'Kolisi', 'siya.k@email.com', '083-555-2345', '0102026008076', 'Male', '34', 'Church Street', 'Cape Town', '8001', 'Active', 'Standard Package'),
('Zintle', 'Kwayimani', 'zintle.k@email.com', '060-555-3456', '9903037008054', 'Female', '56', 'Market Street', 'Durban', '4001', 'Active', 'Premium Package'),
('Thuthuka', 'Thukzin', 'thuthuka.t@email.com', '076-232-4567', '0204048009032', 'Female', '78', 'Long Street', 'Pretoria', '0002', 'Active', 'Standard Package'),
('Makazole', 'Mapimpi', 'makazole.m@email.com', '073-341-5678', '9805059008021', 'Male', '90', 'Hope Street', 'Port Elizabeth', '6001', 'New', 'Basic Package');

-- Insert Packages
INSERT INTO PackageMJ (PackageName, Code, NoOfLessons, Price) VALUES
('FULL COURSE', '8', 30, 3200.00),
('PRINCE''S PACKAGE', '8', 20, 2000.00),
('ROYALTY PACKAGE', '8', 10, 2500.00),
('STEWARD''S PACKAGE', '8', 10, 1300.00);


-- Insert Time Slots
INSERT INTO TimeSlotMJ ( StartTime, EndTime) VALUES
('08:00:00', '09:00:00'),
('09:00:00', '10:00:00'),
('10:00:00', '11:00:00'),
('13:00:00', '14:00:00'),
('11:00:00', '12:00:00'),
('12:00:00', '13:00:00'),
('13:00:00', '14:00:00'),
('14:00:00', '15:00:00'),
('15:00:00', '16:00:00'),
( '16:00:00', '17:00:00');

-- Insert Sample Bookings
INSERT INTO LessonBookingMJ (StudentID, InstructorID, VehicleID, PackageID, TimeSlotID, Date, Time, Status) VALUES
(1, 1, 'ABC123GP', 'Basic Package', 1, '2025-06-16', '09:00:00', 'Confirmed'),
(2, 2, 'DEF456GP', 'Standard Package', 3, '2025-06-16', '13:00:00', 'Confirmed'),
(3, 3, 'GHI789GP', 'Premium Package', 5, '2025-06-17', '16:00:00', 'Scheduled'),
(4, 1, 'ABC123GP', 'Basic Package', 2, '2025-06-18', '10:30:00', 'Pending');

-- Insert Sample Payments
INSERT INTO PaymentMJ (StudentID, PaymentDate, AmountPaid, AmountDue, PaymentMethod) VALUES
(1, '2025-06-15', 1500.00, 0.00, 'Credit Card'),
(2, '2025-06-15', 1000.00, 1000.00, 'Cash'),
(3, '2025-06-15', 2500.00, 0.00, 'Bank Transfer'),
(1, '2025-06-15', 500.00, 1000.00, 'Cash');

-- Insert User Logins
INSERT INTO UserLoginMJ (Username, PasswordHash, Role, StaffID) VALUES
('admin', 'admin123', 'Manager', 5),
('reception', 'reception123', 'Reception', 5),
('david.instructor', 'instructor123', 'Instructor', 1),
('jessica.instructor', 'instructor123', 'Instructor', 2);

PRINT 'Database initialization completed successfully!';

-- Verification: Check PaymentMJ table structure
PRINT 'PaymentMJ table structure:';
SELECT 
    COLUMN_NAME,
    DATA_TYPE,
    IS_NULLABLE,
    COLUMN_DEFAULT
FROM INFORMATION_SCHEMA.COLUMNS 
WHERE TABLE_NAME = 'PaymentMJ'
ORDER BY ORDINAL_POSITION;

-- Verification: Sample query to show payments with student info
PRINT 'Sample payments with student information:';
SELECT 
    p.PaymentID,
    s.Name + ' ' + s.Surname AS StudentName,
    s.PackageName,
    p.PaymentDate,
    p.AmountPaid,
    p.AmountDue,
    p.PaymentMethod
FROM PaymentMJ p
LEFT JOIN StudentMJ s ON p.StudentID = s.StudentID
ORDER BY p.PaymentDate DESC;
