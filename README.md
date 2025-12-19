# 🚗 Car Rental Management System

A comprehensive Windows Forms application for managing car rental operations, built with C# and SQL Server.

## 📋 Features

### Core Functionality
- **User Authentication** - Secure login with encrypted passwords (MD5)
- **Dashboard** - Real-time statistics and recent transactions
- **Vehicle Management** - Complete CRUD operations for vehicle inventory
- **Customer Management** - Manage customer information and profiles
- **Rental Operations** - Create new rentals with automatic calculations
- **Return Processing** - Handle vehicle returns with late fee calculations
- **Rental History** - View and filter past rental transactions
- **Maintenance Tracking** - Record and track vehicle maintenance
- **Settings** - User management and system configuration

### Security Features
- MD5 password encryption
- Role-based access control (Admin/Staff)
- SQL injection prevention using parameterized queries
- Input validation and sanitization
- Session management

### Database Features
- Complete relational database design
- Foreign key constraints
- Sample data included
- Optimized queries

## 🛠️ Technologies Used

- **Framework**: .NET Framework 4.7.2
- **UI**: Windows Forms
- **Database**: SQL Server (2014 or higher)
- **Language**: C# 7.3
- **IDE**: Visual Studio 2022

## 📦 Prerequisites

- Windows 10/11
- Visual Studio 2022 (Community, Professional, or Enterprise)
- SQL Server 2014 or higher (or SQL Server Express)
- .NET Framework 4.7.2 or higher

## 🚀 Installation Steps

### 1. Clone the Repository
```bash
git clone https://github.com/Zcrod199/CarRentalSystem.git
cd CarRentalSystem
```

### 2. Set Up Database
1. Open SQL Server Management Studio (SSMS)
2. Connect to your SQL Server instance
3. Open the file `Database/DatabaseSetup.sql`
4. Execute the script to create the database and tables
5. The script will automatically:
   - Create the `CarRentalDB` database
   - Create all required tables with proper relationships
   - Insert sample data including:
     - Default admin user (username: `admin`, password: `admin123`)
     - 10 sample vehicles
     - 5 sample customers

### 3. Configure Connection String
1. Open `App.config` in the project root
2. Update the connection string to match your SQL Server instance:
```xml
<connectionStrings>
  <add name="CarRentalDB" 
       connectionString="Data Source=YOUR_SERVER_NAME;Initial Catalog=CarRentalDB;Integrated Security=True;TrustServerCertificate=True" 
       providerName="System.Data.SqlClient" />
</connectionStrings>
```
Replace `YOUR_SERVER_NAME` with:
- `.` or `localhost` for local SQL Server
- `.\SQLEXPRESS` for SQL Server Express
- Your server name if using a remote server

### 4. Build and Run
1. Open `CarRentalSystem.sln` in Visual Studio 2022
2. Build the solution (Ctrl+Shift+B or Build → Build Solution)
3. Run the application (F5 or Debug → Start Debugging)

## 🔑 Default Login Credentials

```
Username: admin
Password: admin123
```

**Important**: Change the admin password after first login!

## 📊 Database Schema

### Tables Overview

#### Users
- Stores user accounts with encrypted passwords
- Supports role-based access (Admin/Staff)
- Fields: UserID, Username, Password, FullName, Role, IsActive, CreatedDate

#### Vehicles
- Complete vehicle inventory management
- Fields: VehicleID, PlateNumber, Brand, Model, Year, Color, Type, DailyRate, Status, Mileage, FuelType, TransmissionType, ImagePath

#### Customers
- Customer information and contact details
- Fields: CustomerID, FullName, IDCardNumber, DriverLicenseNumber, Phone, Email, Address, DateOfBirth, RegisterDate

#### Rentals
- Rental transaction records
- Auto-calculates fees and totals
- Fields: RentalID, CustomerID, VehicleID, RentalDate, StartDate, EndDate, ReturnDate, DailyRate, TotalDays, SubTotal, LateFee, DamageFee, TotalAmount, Status, Notes

#### Payments
- Payment history and tracking
- Fields: PaymentID, RentalID, PaymentDate, Amount, PaymentMethod, PaymentStatus

#### Maintenance
- Vehicle maintenance records
- Fields: MaintenanceID, VehicleID, MaintenanceDate, MaintenanceType, Description, Cost, NextMaintenanceDate

## 📁 Project Structure

```
CarRentalSystem/
├── Forms/                          # All Windows Forms
│   ├── FormLogin.cs               # User authentication
│   ├── FormDashboard.cs           # Main dashboard
│   ├── FormManageVehicles.cs      # Vehicle management
│   ├── FormManageCustomers.cs     # Customer management
│   ├── FormNewRental.cs           # Create new rentals
│   ├── FormReturnVehicle.cs       # Process returns
│   ├── FormRentalHistory.cs       # View rental history
│   ├── FormManageMaintenance.cs   # Maintenance tracking
│   └── FormSettings.cs            # Application settings
├── Classes/                        # Core business logic
│   ├── DatabaseConnection.cs      # Database operations
│   ├── UserSession.cs             # Session management
│   ├── SecurityHelper.cs          # Security utilities
│   ├── ValidationHelper.cs        # Input validation
│   └── ReportHelper.cs            # Reporting utilities
├── Database/                       # Database scripts
│   └── DatabaseSetup.sql          # Complete database setup
├── Properties/                     # Project properties
├── Resources/                      # Application resources
├── App.config                      # Application configuration
├── Program.cs                      # Entry point
└── README.md                       # This file
```

## 💡 Usage Guide

### Dashboard
- View real-time statistics (vehicles, customers, rentals, revenue)
- Monitor recent transactions
- Quick access to all modules via navigation menu

### Vehicle Management
1. Click "Vehicles" from the dashboard menu
2. View all vehicles in the grid
3. Use "Add New" to register a new vehicle
4. Select a vehicle and click "Edit" to modify details
5. Click "Delete" to remove a vehicle (with confirmation)
6. Use search bar to find specific vehicles

### Customer Management
1. Click "Customers" from the dashboard menu
2. View all customers in the grid
3. Add, edit, or delete customer records
4. Search customers by name, ID, or license number

### Creating a New Rental
1. Click "New Rental" from the dashboard menu
2. Select or create a customer
3. Choose an available vehicle
4. Set start and end dates
5. System automatically calculates:
   - Total rental days
   - Daily rate × days
   - Total amount
6. Select payment method
7. Click "Process Rental" to complete

### Returning a Vehicle
1. Click "Return Vehicle" from the dashboard menu
2. Search for rental by plate number or rental ID
3. Set actual return date
4. System calculates late fees if applicable
5. Enter damage fees if needed
6. Click "Process Return" to complete

### Viewing Rental History
1. Click "Rental History" from the dashboard menu
2. Filter by date range or status
3. Export data to Excel (if implemented)
4. Print reports (if implemented)

## 🔧 Troubleshooting

### Database Connection Issues
**Error**: Cannot connect to database
**Solution**:
1. Verify SQL Server is running
2. Check connection string in App.config
3. Ensure SQL Server allows remote connections (if remote)
4. Verify firewall settings
5. Try using SQL Server Configuration Manager

### Login Issues
**Error**: Cannot login with default credentials
**Solution**:
1. Verify DatabaseSetup.sql was executed successfully
2. Check if Users table has data: `SELECT * FROM Users`
3. Ensure password is encrypted correctly
4. Try resetting the admin password in the database

### Build Errors
**Error**: Missing references
**Solution**:
1. Restore NuGet packages
2. Verify .NET Framework 4.7.2 is installed
3. Clean and rebuild solution
4. Check all required assemblies are referenced

### Runtime Errors
**Error**: Object reference not set
**Solution**:
1. Check database connections
2. Verify all required tables exist
3. Ensure sample data is loaded
4. Check for null values in queries

## 🔒 Security Considerations

- Change default admin password immediately
- Use strong passwords (min 6 characters)
- Regularly backup the database
- Review user permissions periodically
- Keep SQL Server updated
- Use environment variables for sensitive configuration (production)

## 📈 Future Enhancements

- Advanced reporting with charts
- Email notifications for overdue rentals
- Vehicle reservation system
- Mobile-responsive web interface
- Integration with payment gateways
- Document management (license, insurance scans)
- GPS tracking integration
- Multi-branch support
- Advanced analytics dashboard
- Export reports to PDF

## 🐛 Known Issues

- Forms are currently stubs and need full implementation (except Login, Dashboard, and Manage Vehicles)
- Chart visualization not yet implemented on dashboard
- Export to Excel functionality pending
- Print report functionality pending
- Image upload for vehicles pending

## 📝 Development Notes

### Code Conventions
- Use meaningful variable names
- Add XML comments for public methods
- Follow C# naming conventions
- Implement proper error handling
- Use `using` statements for IDisposable objects

### Database Best Practices
- Always use parameterized queries
- Never store plain text passwords
- Implement proper transaction handling
- Regular database backups
- Index frequently queried columns

## 👥 Contributing

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

## 📄 License

This project is available for educational and commercial use.

## 📞 Support

For issues, questions, or contributions, please open an issue on GitHub.

## ✅ Testing Checklist

- [x] Login with valid credentials
- [x] Login with invalid credentials
- [x] Dashboard statistics load correctly
- [x] Vehicle management (Add/Edit/Delete)
- [ ] Customer management (Add/Edit/Delete)
- [ ] Create new rental
- [ ] Return vehicle on time
- [ ] Return vehicle late (late fee calculation)
- [ ] Return vehicle with damage fee
- [ ] View rental history
- [ ] Filter rentals by date/status
- [ ] Maintenance tracking
- [ ] User management
- [ ] Password change

## 🎯 Version History

### Version 1.0.0 (Current)
- Initial release
- Core functionality implemented
- Login and authentication
- Dashboard with statistics
- Vehicle management (full CRUD)
- Database setup script
- Sample data included

---

**Built with ❤️ for efficient car rental management**