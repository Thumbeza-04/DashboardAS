using System;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace DashboardAS.Data
{
    public static class DatabaseInitializer
    {
        public static bool InitializeDatabase()
        {
            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                      // Check if tables exist
                    string checkTablesQuery = @"
                        SELECT COUNT(*) 
                        FROM INFORMATION_SCHEMA.TABLES 
                        WHERE TABLE_NAME IN ('StudentMJ', 'InstructorMJ', 'VehicleMJ', 'PackageMJ', 'UserLoginMJ')";
                    
                    SqlCommand checkCmd = new SqlCommand(checkTablesQuery, conn);
                    int tableCount = (int)checkCmd.ExecuteScalar();
                    
                    if (tableCount == 0)
                    {
                        // Tables don't exist, create them
                        MessageBox.Show("Database tables not found. Initializing database...", 
                                       "Database Setup", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        CreateTables(conn);
                        InsertSampleData(conn);
                        
                        MessageBox.Show("Database initialized successfully with sample data!", 
                                       "Database Setup", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error initializing database: {ex.Message}\n\n" +
                               "Please ensure SQL Server LocalDB is installed and running.", 
                               "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        
        private static void CreateTables(SqlConnection conn)
        {
            string[] createTableCommands = {
                @"CREATE TABLE VehicleMJ (
                    LicensePlateID VARCHAR(20) PRIMARY KEY,
                    TransmissionType VARCHAR(20),
                    FuelType VARCHAR(20),
                    Make VARCHAR(50),
                    VehicleType VARCHAR(30)
                )",
                
                @"CREATE TABLE StaffMJ (
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
                )",
                
                @"CREATE TABLE InstructorMJ (
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
                )",
                
                @"CREATE TABLE StudentMJ (
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
                    Status VARCHAR(20)
                )",
                
                @"CREATE TABLE PackageMJ (
                    PackageName VARCHAR(50) PRIMARY KEY,
                    Code VARCHAR(20),
                    NoOfLessons INT,
                    Price DECIMAL(10, 2)
                )",
                
                @"CREATE TABLE TimeSlotMJ (
                    TimeSlotID INT IDENTITY(1,1) PRIMARY KEY,
                    StaffID INT,
                    StudentID INT,
                    TimeSlotLabel VARCHAR(50),
                    StartTime TIME,
                    EndTime TIME,
                    FOREIGN KEY (StaffID) REFERENCES StaffMJ(StaffID),
                    FOREIGN KEY (StudentID) REFERENCES StudentMJ(StudentID)
                )",
                  @"CREATE TABLE LessonBookingMJ (
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
                )",
                  @"CREATE TABLE PaymentMJ (
                    PaymentID INT IDENTITY(1,1) PRIMARY KEY,
                    BookingID INT,
                    PaymentDate DATE,
                    AmountPaid DECIMAL(10,2),
                    AmountDue DECIMAL(10,2),
                    PaymentMethod VARCHAR(30),
                    FOREIGN KEY (BookingID) REFERENCES LessonBookingMJ(BookingID)
                )",
                
                @"CREATE TABLE UserLoginMJ (
                    UserID INT IDENTITY(1,1) PRIMARY KEY,
                    Username VARCHAR(50) UNIQUE,
                    PasswordHash VARCHAR(255),
                    Role VARCHAR(30) CHECK (Role IN ('Reception', 'Instructor', 'Manager')),
                    StaffID INT,
                    FOREIGN KEY (StaffID) REFERENCES StaffMJ(StaffID)
                )"
            };
            
            foreach (string command in createTableCommands)
            {
                using (SqlCommand cmd = new SqlCommand(command, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }
        
        private static void InsertSampleData(SqlConnection conn)
        {
            string[] insertCommands = {
                // Insert Vehicles
                @"INSERT INTO VehicleMJ VALUES
                ('ABC123GP', 'Manual', 'Petrol', 'Toyota Corolla', 'Sedan'),
                ('DEF456GP', 'Automatic', 'Petrol', 'Honda Civic', 'Sedan'),
                ('GHI789GP', 'Manual', 'Diesel', 'Volkswagen Polo', 'Hatchback')",
                  // Insert Staff
                @"INSERT INTO StaffMJ VALUES
                ('David', 'Mabuza', 'david.m@tlgdriving.com', '076-123-4567', '8001015009088', 'Male', '123', 'Main Street', 'Johannesburg', '2000', 'Instructor', 'Active'),
                ('Jessica', 'Nkosi', 'jessica.n@tlgdriving.com', '083-234-5678', '9002026008076', 'Female', '456', 'Oak Avenue', 'Pretoria', '0002', 'Instructor', 'Active'),
                ('Sibusiso', 'Thembeni', 'sbu.t@tlgdriving.com', '061-345-6789', '8503037009054', 'Male', '789', 'Pine Road', 'Durban', '4001', 'Instructor', 'Active'),
                ('Sarah', 'Johnson', 'sarah.j@tlgdriving.com', '072-567-8901', '8705059009021', 'Female', '654', 'Maple Drive', 'Johannesburg', '2000', 'Reception', 'Active'),
                ('Admin', 'User', 'admin@tlgdriving.com', '011-123-4567', '8001015001088', 'Male', '1', 'Admin Street', 'Johannesburg', '2000', 'Manager', 'Active')",
                
                // Insert Instructors
                @"INSERT INTO InstructorMJ VALUES
                ('ABC123GP', 'DI4852', 'Senior', 'David', 'Mabuza', 'Male', '076-123-4567', 'david.m@tlgdriving.com'),
                ('DEF456GP', 'DI7834', 'Intermediate', 'Jessica', 'Nkosi', 'Female', '083-234-5678', 'jessica.n@tlgdriving.com'),
                ('GHI789GP', 'DI6721', 'Senior', 'Sibusiso', 'Thembeni', 'Male', '061-345-6789', 'sbu.t@tlgdriving.com')",
                
                // Insert Students
                @"INSERT INTO StudentMJ VALUES
                ('Aphelele', 'Shabane', 'aphelele.s@email.com', '061-555-1234', '0001015009088', 'Male', '12', 'Victoria Street', 'Johannesburg', '2000', 'Active'),
                ('Siya', 'Kolisi', 'siya.k@email.com', '083-555-2345', '0102026008076', 'Male', '34', 'Church Street', 'Cape Town', '8001', 'Active'),
                ('Zintle', 'Kwayimani', 'zintle.k@email.com', '060-555-3456', '9903037008054', 'Female', '56', 'Market Street', 'Durban', '4001', 'Active'),
                ('Thuthuka', 'Thukzin', 'thuthuka.t@email.com', '076-232-4567', '0204048009032', 'Female', '78', 'Long Street', 'Pretoria', '0002', 'Active'),
                ('Makazole', 'Mapimpi', 'makazole.m@email.com', '073-341-5678', '9805059008021', 'Male', '90', 'Hope Street', 'Port Elizabeth', '6001', 'New')",
                
                // Insert Packages
                @"INSERT INTO PackageMJ VALUES
                ('Basic Package', '8', 10, 1500.00),
                ('Standard Package', '8', 15, 2000.00),
                ('Premium Package', '10', 20, 2500.00)",
                
                // Insert Time Slots
                @"INSERT INTO TimeSlotMJ VALUES
                (1, NULL, 'Morning Slot 1', '09:00:00', '10:00:00'),
                (1, NULL, 'Morning Slot 2', '10:30:00', '11:30:00'),
                (2, NULL, 'Afternoon Slot 1', '13:00:00', '14:00:00'),
                (3, NULL, 'Late Afternoon', '16:00:00', '17:00:00')",
                  // Insert Sample Bookings
                @"INSERT INTO LessonBookingMJ (StudentID, InstructorID, VehicleID, PackageID, TimeSlotID, Date, Time, Status) VALUES
                (1, 1, 'ABC123GP', 'Basic Package', 1, '2025-06-16', '09:00:00', 'Confirmed'),
                (2, 2, 'DEF456GP', 'Standard Package', 3, '2025-06-16', '13:00:00', 'Confirmed'),
                (3, 3, 'GHI789GP', 'Premium Package', 4, '2025-06-17', '16:00:00', 'Scheduled')",
                  // Insert Sample Payments
                @"INSERT INTO PaymentMJ VALUES
                (1, '2025-06-15', 1500.00, 0.00, 'Credit Card'),
                (2, '2025-06-15', 1000.00, 1000.00, 'Cash'),
                (3, '2025-06-15', 2500.00, 0.00, 'Bank Transfer')",
                  // Insert User Logins
                @"INSERT INTO UserLoginMJ (Username, PasswordHash, Role, StaffID) VALUES
                ('admin', 'admin123', 'Manager', 5),
                ('reception', 'reception123', 'Reception', 4),
                ('david.instructor', 'instructor123', 'Instructor', 1),
                ('jessica.instructor', 'instructor123', 'Instructor', 2)"
            };
            
            foreach (string command in insertCommands)
            {
                using (SqlCommand cmd = new SqlCommand(command, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
