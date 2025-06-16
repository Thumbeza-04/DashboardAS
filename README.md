# Driving School Management System - Database Integration

## Overview

This C# Windows Forms application has been successfully integrated with a SQL Server database to manage a driving school's operations. 

## Database Schema

The application uses the following tables:

### Core Tables
- **VehicleMJ**: Stores vehicle information (license plates, make, type, transmission)
- **StudentMJ**: Student information and contact details
- **InstructorMJ**: Instructor details and certifications
- **StaffMJ**: Staff members and their roles
- **PackageMJ**: Lesson packages and pricing
- **LessonBookingMJ**: Lesson bookings and scheduling
- **PaymentMJ**: Payment records and financial transactions
- **TimeSlotMJ**: Available time slots for lessons

### Features Implemented

1. **Students Management**
   - View all students with lesson count
   - Database-driven student list
   - Real-time data from StudentMJ table

2. **Instructors Management**
   - View instructors with vehicle assignments
   - Expertise levels and contact information
   - Linked to VehicleMJ for assigned vehicles

3. **Payments Dashboard**
   - Real revenue calculations
   - Outstanding payment tracking
   - Payment history from database

4. **Home Dashboard**
   - Live statistics (upcoming lessons, total students, revenue)
   - Real upcoming lessons from database
   - Dynamic dashboard updates

5. **Book Lesson Feature**
   - Dropdown lists populated from database
   - Student, instructor, and package selection
   - Time slot management

## Database Connection

The application uses SQL Server LocalDB with the following connection string:
```
Server=(localdb)\MyServer;Database=MajorProject;Integrated Security=true;AttachDbFilename=|DataDirectory|\DrivingSchoolMJ.mdf
```

## Auto-Initialization

The application automatically:
1. Checks if database tables exist on startup
2. Creates tables if they don't exist
3. Populates with sample data for testing
4. Shows appropriate error messages if database connection fails

## Project Structure

### Models (`Models/` folder)
- `Student.cs` - Student entity
- `Instructor.cs` - Instructor entity
- `Vehicle.cs` - Vehicle entity
- `Package.cs` - Package entity
- `LessonBooking.cs` - Booking entity
- `Payment.cs` - Payment entity
- `Staff.cs` - Staff entity
- `TimeSlot.cs` - Time slot entity

### Data Access Layer (`Data/` folder)
- `DatabaseConnection.cs` - Connection management
- `DatabaseInitializer.cs` - Database setup and sample data
- `StudentDAO.cs` - Student data operations
- `InstructorDAO.cs` - Instructor data operations
- `LessonBookingDAO.cs` - Booking data operations
- `PaymentDAO.cs` - Payment data operations
- `VehicleDAO.cs` - Vehicle data operations
- `PackageDAO.cs` - Package data operations

### Updated User Controls
- `StudentsUserControl.cs` - Now uses StudentDAO
- `InstructorsUserControl.cs` - Now uses InstructorDAO
- `PaymentUserControl.cs` - Now uses PaymentDAO
- `HomeUserControl.cs` - Now uses multiple DAOs for dashboard
- `BookLessonUserControl.cs` - Now uses multiple DAOs for dropdowns

## Sample Data

The system comes with sample data including:
- 5 students (Aphelele Shabane, Siya Kolisi, etc.)
- 3 instructors with vehicles assigned
- 4 lesson packages (Basic, Standard, Premium, Intensive)
- 3 vehicles (Toyota Corolla, Honda Civic, VW Polo)
- Sample bookings and payments

## Error Handling

All database operations include proper error handling:
- Connection failures show informative messages
- Missing data falls back to empty displays
- Database initialization errors prevent application startup

## Usage Instructions

1. **First Run**: The application will automatically create the database and tables
2. **Data Display**: All grids now show real data from the database
3. **Dashboard**: Live statistics update from the database
4. **Booking**: Dropdown lists are populated from database tables

## Technical Requirements

- .NET Framework 4.7.2
- SQL Server LocalDB (or full SQL Server)
- Visual Studio 2019 or later
- System.Data.SqlClient for database connectivity
- System.Configuration for connection strings

## Configuration

Database connection can be modified in `App.config`:
```xml
<connectionStrings>
    <add name="DrivingSchoolDB" 
         connectionString="Server=(localdb)\MSSQLLocalDB;Database=DrivingSchoolMJ;Integrated Security=true;AttachDbFilename=|DataDirectory|\DrivingSchoolMJ.mdf" 
         providerName="System.Data.SqlClient" />
</connectionStrings>
```

## Future Enhancements

The database integration provides a foundation for:
- User authentication and authorization
- Advanced reporting and analytics
- Lesson scheduling optimization
- Mobile app integration
- Payment processing integration
- Student progress tracking
- Instructor performance metrics
