# Quick Start Guide - Car Rental Management System

## 🚀 Get Started in 5 Minutes

### Step 1: Database Setup (2 minutes)
1. Open **SQL Server Management Studio (SSMS)**
2. Press `Ctrl+O` and open `Database/DatabaseSetup.sql`
3. Click **Execute** (or press `F5`)
4. You should see: "Database setup completed successfully!"

### Step 2: Configure Connection (1 minute)
1. Open `App.config`
2. Find the `<connectionStrings>` section
3. Update `Data Source=.` if needed:
   - Use `.` for local SQL Server
   - Use `.\SQLEXPRESS` for SQL Server Express
   - Use your server name for remote server

### Step 3: Build & Run (2 minutes)
1. Open `CarRentalSystem.sln` in Visual Studio 2022
2. Press `Ctrl+Shift+B` to build
3. Press `F5` to run

### Step 4: Login
```
Username: admin
Password: admin123
```

## ✅ What Works Right Now

### Fully Functional
- ✅ **Login System** - Secure authentication with encrypted passwords
- ✅ **Dashboard** - Real-time statistics and recent rentals
- ✅ **Vehicle Management** - Complete CRUD operations
  - Add new vehicles
  - Edit existing vehicles
  - Delete vehicles (with confirmation)
  - Search vehicles by plate, brand, or model

### Stub Forms (Ready for Implementation)
- 🔄 Customer Management
- 🔄 New Rental
- 🔄 Return Vehicle
- 🔄 Rental History
- 🔄 Maintenance Tracking
- 🔄 Settings

## 🎯 Test the System

### Test Scenario 1: Login
1. Run the application
2. Enter: `admin` / `admin123`
3. Click Login
4. ✅ You should see the Dashboard

### Test Scenario 2: View Dashboard
1. After login, observe the statistics:
   - Total Vehicles: 10
   - Available: 10
   - Total Customers: 5
2. Scroll down to see recent transactions grid

### Test Scenario 3: Manage Vehicles
1. Click "Vehicles" in the left menu
2. You'll see 10 sample vehicles
3. Click any vehicle to see details
4. Try searching: type "Toyota" and click Search

### Test Scenario 4: Add New Vehicle
1. In Vehicle Management, click "Add New"
2. Fill in the form:
   - Plate Number: TEST-001
   - Brand: Honda
   - Model: Civic
   - Year: 2024
   - Color: Blue
   - Type: Sedan
   - Daily Rate: 45.00
   - Status: Available
   - Mileage: 0
   - Fuel Type: Gasoline
   - Transmission: Automatic
3. Click "Save"
4. ✅ Vehicle added successfully!

### Test Scenario 5: Edit Vehicle
1. Select a vehicle from the grid
2. Click "Edit"
3. Change the daily rate
4. Click "Save"
5. ✅ Changes saved!

### Test Scenario 6: Delete Vehicle
1. Select a vehicle
2. Click "Delete"
3. Confirm deletion
4. ✅ Vehicle removed!

## 📊 Sample Data Included

### Vehicles (10 total)
- Toyota Camry 2022
- Honda CR-V 2023
- Ford Mustang 2021
- Tesla Model 3 2023
- Nissan Altima 2022
- Chevrolet Tahoe 2023
- BMW 3 Series 2022
- Mercedes GLE 2023
- Hyundai Elantra 2022
- Kia Sportage 2023

### Customers (5 total)
- John Smith
- Sarah Johnson
- Michael Brown
- Emily Davis
- David Wilson

## 🐛 Troubleshooting

### Problem: "Cannot open database"
**Solution**: Make sure you ran `DatabaseSetup.sql` in SSMS

### Problem: "Login failed"
**Solution**: 
1. Check if SQL Server is running
2. Verify connection string in App.config
3. Try using `Integrated Security=True`

### Problem: "Object reference not set"
**Solution**: Ensure the database has data by running:
```sql
USE CarRentalDB;
SELECT * FROM Users;
SELECT * FROM Vehicles;
```

## 📝 Next Steps

After testing the working features:

1. **Implement Customer Management**
   - Copy the pattern from Vehicle Management
   - Adapt for Customer fields

2. **Implement New Rental**
   - Create customer selection
   - Add vehicle selection dropdown
   - Implement date calculations

3. **Implement Return Vehicle**
   - Create rental lookup
   - Add late fee calculation
   - Update vehicle status

## 💡 Code Patterns to Follow

### CRUD Operations Pattern (see FormManageVehicles.cs)
```csharp
// Load Data
private void LoadData()
{
    string query = "SELECT * FROM TableName";
    DataTable dt = DatabaseConnection.ExecuteReader(query);
    dataGridView.DataSource = dt;
}

// Add/Update
private void Save()
{
    string query = "INSERT INTO ... or UPDATE ...";
    SqlParameter[] parameters = { ... };
    DatabaseConnection.ExecuteQuery(query, parameters);
}

// Delete
private void Delete()
{
    string query = "DELETE FROM TableName WHERE ID = @ID";
    SqlParameter[] parameters = {
        new SqlParameter("@ID", selectedID)
    };
    DatabaseConnection.ExecuteQuery(query, parameters);
}
```

## 🎓 Learning Resources

### Understanding the Code
- **DatabaseConnection.cs** - All database operations
- **SecurityHelper.cs** - Password encryption
- **ValidationHelper.cs** - Input validation
- **FormLogin.cs** - Authentication example
- **FormManageVehicles.cs** - Full CRUD example

### Key Concepts Used
- Windows Forms UI design
- SQL Server parameterized queries
- MD5 password hashing
- Session management
- DataGridView binding
- Form validation

## 🔒 Security Notes

⚠️ **Change the default password immediately in production!**

Update password in database:
```sql
USE CarRentalDB;
UPDATE Users 
SET Password = '0192023A7BBD73250516F069DF18B500' -- This is MD5('admin123')
WHERE Username = 'admin';
```

Or use the SecurityHelper class to generate new hash:
```csharp
string newPasswordHash = SecurityHelper.EncryptPassword("YourNewPassword");
```

## 📞 Need Help?

1. Check the main **README.md** for detailed documentation
2. Review **DatabaseSetup.sql** for database structure
3. Look at working examples in **FormManageVehicles.cs**
4. Check error messages for clues
5. Open an issue on GitHub if stuck

---

**Happy Coding! 🚗💨**
