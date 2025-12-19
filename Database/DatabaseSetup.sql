-- =============================================
-- Car Rental Management System - Database Setup
-- =============================================

-- Create Database
IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'CarRentalDB')
BEGIN
    CREATE DATABASE CarRentalDB;
END
GO

USE CarRentalDB;
GO

-- =============================================
-- Table: Users
-- =============================================
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Users')
BEGIN
    CREATE TABLE Users (
        UserID INT PRIMARY KEY IDENTITY(1,1),
        Username NVARCHAR(50) UNIQUE NOT NULL,
        Password NVARCHAR(255) NOT NULL,
        FullName NVARCHAR(100) NOT NULL,
        Role NVARCHAR(20) NOT NULL DEFAULT 'Staff',
        IsActive BIT NOT NULL DEFAULT 1,
        CreatedDate DATETIME NOT NULL DEFAULT GETDATE()
    );
END
GO

-- =============================================
-- Table: Vehicles
-- =============================================
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Vehicles')
BEGIN
    CREATE TABLE Vehicles (
        VehicleID INT PRIMARY KEY IDENTITY(1,1),
        PlateNumber NVARCHAR(20) UNIQUE NOT NULL,
        Brand NVARCHAR(50) NOT NULL,
        Model NVARCHAR(50) NOT NULL,
        Year INT NOT NULL,
        Color NVARCHAR(30) NOT NULL,
        Type NVARCHAR(30) NOT NULL,
        DailyRate DECIMAL(10,2) NOT NULL,
        Status NVARCHAR(20) NOT NULL DEFAULT 'Available',
        Mileage INT NOT NULL DEFAULT 0,
        FuelType NVARCHAR(20) NOT NULL,
        TransmissionType NVARCHAR(20) NOT NULL,
        ImagePath NVARCHAR(500) NULL
    );
END
GO

-- =============================================
-- Table: Customers
-- =============================================
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Customers')
BEGIN
    CREATE TABLE Customers (
        CustomerID INT PRIMARY KEY IDENTITY(1,1),
        FullName NVARCHAR(100) NOT NULL,
        IDCardNumber NVARCHAR(20) UNIQUE NOT NULL,
        DriverLicenseNumber NVARCHAR(30) UNIQUE NOT NULL,
        Phone NVARCHAR(20) NOT NULL,
        Email NVARCHAR(100) NULL,
        Address NVARCHAR(200) NULL,
        DateOfBirth DATE NOT NULL,
        RegisterDate DATETIME NOT NULL DEFAULT GETDATE()
    );
END
GO

-- =============================================
-- Table: Rentals
-- =============================================
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Rentals')
BEGIN
    CREATE TABLE Rentals (
        RentalID INT PRIMARY KEY IDENTITY(1,1),
        CustomerID INT NOT NULL,
        VehicleID INT NOT NULL,
        RentalDate DATETIME NOT NULL DEFAULT GETDATE(),
        StartDate DATE NOT NULL,
        EndDate DATE NOT NULL,
        ReturnDate DATE NULL,
        DailyRate DECIMAL(10,2) NOT NULL,
        TotalDays INT NOT NULL,
        SubTotal DECIMAL(10,2) NOT NULL,
        LateFee DECIMAL(10,2) NOT NULL DEFAULT 0,
        DamageFee DECIMAL(10,2) NOT NULL DEFAULT 0,
        TotalAmount DECIMAL(10,2) NOT NULL,
        Status NVARCHAR(20) NOT NULL DEFAULT 'Active',
        Notes NVARCHAR(500) NULL,
        FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID),
        FOREIGN KEY (VehicleID) REFERENCES Vehicles(VehicleID)
    );
END
GO

-- =============================================
-- Table: Payments
-- =============================================
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Payments')
BEGIN
    CREATE TABLE Payments (
        PaymentID INT PRIMARY KEY IDENTITY(1,1),
        RentalID INT NOT NULL,
        PaymentDate DATETIME NOT NULL DEFAULT GETDATE(),
        Amount DECIMAL(10,2) NOT NULL,
        PaymentMethod NVARCHAR(20) NOT NULL,
        PaymentStatus NVARCHAR(20) NOT NULL DEFAULT 'Completed',
        FOREIGN KEY (RentalID) REFERENCES Rentals(RentalID)
    );
END
GO

-- =============================================
-- Table: Maintenance
-- =============================================
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Maintenance')
BEGIN
    CREATE TABLE Maintenance (
        MaintenanceID INT PRIMARY KEY IDENTITY(1,1),
        VehicleID INT NOT NULL,
        MaintenanceDate DATE NOT NULL,
        MaintenanceType NVARCHAR(50) NOT NULL,
        Description NVARCHAR(500) NULL,
        Cost DECIMAL(10,2) NOT NULL,
        NextMaintenanceDate DATE NULL,
        FOREIGN KEY (VehicleID) REFERENCES Vehicles(VehicleID)
    );
END
GO

-- =============================================
-- Insert Sample Data
-- =============================================

-- Insert Default Admin User (Password: admin123 - MD5 Hash)
IF NOT EXISTS (SELECT * FROM Users WHERE Username = 'admin')
BEGIN
    INSERT INTO Users (Username, Password, FullName, Role, IsActive)
    VALUES ('admin', '0192023A7BBD73250516F069DF18B500', 'System Administrator', 'Admin', 1);
END
GO

-- Insert Sample Vehicles
IF NOT EXISTS (SELECT * FROM Vehicles WHERE PlateNumber = 'ABC-123')
BEGIN
    INSERT INTO Vehicles (PlateNumber, Brand, Model, Year, Color, Type, DailyRate, Status, Mileage, FuelType, TransmissionType)
    VALUES 
    ('ABC-123', 'Toyota', 'Camry', 2022, 'Silver', 'Sedan', 50.00, 'Available', 15000, 'Gasoline', 'Automatic'),
    ('XYZ-456', 'Honda', 'CR-V', 2023, 'Black', 'SUV', 75.00, 'Available', 8000, 'Gasoline', 'Automatic'),
    ('DEF-789', 'Ford', 'Mustang', 2021, 'Red', 'Sports', 120.00, 'Available', 12000, 'Gasoline', 'Manual'),
    ('GHI-101', 'Tesla', 'Model 3', 2023, 'White', 'Sedan', 95.00, 'Available', 5000, 'Electric', 'Automatic'),
    ('JKL-202', 'Nissan', 'Altima', 2022, 'Blue', 'Sedan', 55.00, 'Available', 18000, 'Gasoline', 'Automatic'),
    ('MNO-303', 'Chevrolet', 'Tahoe', 2023, 'Gray', 'SUV', 85.00, 'Available', 10000, 'Gasoline', 'Automatic'),
    ('PQR-404', 'BMW', '3 Series', 2022, 'Black', 'Sedan', 110.00, 'Available', 9000, 'Gasoline', 'Automatic'),
    ('STU-505', 'Mercedes', 'GLE', 2023, 'Silver', 'SUV', 130.00, 'Available', 6000, 'Diesel', 'Automatic'),
    ('VWX-606', 'Hyundai', 'Elantra', 2022, 'White', 'Sedan', 45.00, 'Available', 20000, 'Gasoline', 'Automatic'),
    ('YZA-707', 'Kia', 'Sportage', 2023, 'Green', 'SUV', 65.00, 'Available', 7000, 'Gasoline', 'Automatic');
END
GO

-- Insert Sample Customers
IF NOT EXISTS (SELECT * FROM Customers WHERE IDCardNumber = 'ID001')
BEGIN
    INSERT INTO Customers (FullName, IDCardNumber, DriverLicenseNumber, Phone, Email, Address, DateOfBirth)
    VALUES 
    ('John Smith', 'ID001', 'DL123456', '555-0101', 'john.smith@email.com', '123 Main St, City', '1985-03-15'),
    ('Sarah Johnson', 'ID002', 'DL234567', '555-0102', 'sarah.j@email.com', '456 Oak Ave, City', '1990-07-22'),
    ('Michael Brown', 'ID003', 'DL345678', '555-0103', 'mbrown@email.com', '789 Pine Rd, City', '1988-11-30'),
    ('Emily Davis', 'ID004', 'DL456789', '555-0104', 'emily.d@email.com', '321 Elm St, City', '1992-05-18'),
    ('David Wilson', 'ID005', 'DL567890', '555-0105', 'dwilson@email.com', '654 Maple Dr, City', '1987-09-25');
END
GO

PRINT 'Database setup completed successfully!';
GO
