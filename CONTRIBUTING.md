# Contributing to Car Rental Management System

Thank you for your interest in contributing! This guide will help you get started with extending and improving the system.

## 🚀 Getting Started

### Prerequisites
- Visual Studio 2022 (Community or higher)
- SQL Server 2014+ or SQL Server Express
- .NET Framework 4.7.2 SDK
- Git for version control

### Setup Development Environment
1. Fork the repository
2. Clone your fork: `git clone https://github.com/YOUR_USERNAME/CarRentalSystem.git`
3. Open `CarRentalSystem.sln` in Visual Studio
4. Run `Database/DatabaseSetup.sql` in SQL Server Management Studio
5. Update connection string in `App.config`
6. Build and run (F5)

## 📋 What Needs Implementation

### High Priority
1. **FormManageCustomers.cs** - Customer CRUD operations
2. **FormNewRental.cs** - Rental creation workflow
3. **FormReturnVehicle.cs** - Vehicle return processing
4. **FormRentalHistory.cs** - History viewing and filtering

### Medium Priority
5. **FormManageMaintenance.cs** - Maintenance tracking
6. **FormSettings.cs** - User management and settings

### Enhancements
- Export to Excel functionality
- Print reports
- Dashboard charts
- Email notifications
- Advanced search filters
- Multi-language support

## 🎯 Implementation Guidelines

### 1. Use Existing Patterns

#### Copy the Vehicle Management Pattern
The `FormManageVehicles.cs` is fully implemented and serves as the template:

```csharp
// 1. DataGridView for listing
private void LoadData()
{
    string query = "SELECT * FROM TableName";
    DataTable dt = DatabaseConnection.ExecuteReader(query);
    dgvData.DataSource = dt;
}

// 2. Add/Edit modes
private void SetEditMode() { /* Enable fields */ }
private void SetReadOnlyMode() { /* Disable fields */ }

// 3. CRUD operations with validation
private void btnSave_Click(object sender, EventArgs e)
{
    if (!ValidateInputs()) return;
    
    // Use parameterized queries
    string query = "INSERT INTO ... VALUES (@Param1, @Param2)";
    SqlParameter[] parameters = {
        new SqlParameter("@Param1", value1),
        new SqlParameter("@Param2", value2)
    };
    
    DatabaseConnection.ExecuteQuery(query, parameters);
    LoadData();
}
```

### 2. Follow Coding Standards

#### Naming Conventions
```csharp
// Classes: PascalCase
public class CustomerManager { }

// Methods: PascalCase
public void LoadCustomers() { }

// Private fields: camelCase
private int selectedCustomerID;

// Controls: prefix + PascalCase
private TextBox txtCustomerName;
private Button btnSave;
private DataGridView dgvCustomers;
```

#### Code Structure
```csharp
// 1. Fields at top
private int selectedID;
private bool isEditMode;

// 2. Constructor
public FormName() { InitializeComponent(); }

// 3. Event handlers
private void FormName_Load(object sender, EventArgs e) { }

// 4. Helper methods
private void LoadData() { }
private bool ValidateInputs() { }
```

### 3. Use Helper Classes

```csharp
// Database operations
DataTable dt = DatabaseConnection.ExecuteReader(query, parameters);
int rows = DatabaseConnection.ExecuteQuery(query, parameters);
object result = DatabaseConnection.ExecuteScalar(query, parameters);

// Validation
if (!ValidationHelper.IsNotEmpty(txtName.Text)) return false;
if (!ValidationHelper.IsValidEmail(txtEmail.Text)) return false;
if (!ValidationHelper.IsValidDecimal(txtRate.Text, out decimal rate)) return false;

// Security
string hash = SecurityHelper.EncryptPassword(password);
if (SecurityHelper.VerifyPassword(entered, stored)) { }

// Session
if (!UserSession.IsLoggedIn()) return;
if (UserSession.IsAdmin()) { /* Admin only features */ }
```

### 4. Error Handling

Always use try-catch with meaningful messages:

```csharp
try
{
    // Database or file operations
}
catch (SqlException ex)
{
    MessageBox.Show("Database error: " + ex.Message, "Error", 
        MessageBoxButtons.OK, MessageBoxIcon.Error);
}
catch (Exception ex)
{
    MessageBox.Show("An error occurred: " + ex.Message, "Error", 
        MessageBoxButtons.OK, MessageBoxIcon.Error);
}
```

### 5. Input Validation

Validate before database operations:

```csharp
private bool ValidateInputs()
{
    if (!ValidationHelper.IsNotEmpty(txtField.Text))
    {
        MessageBox.Show("Please enter field value.", "Validation Error", 
            MessageBoxButtons.OK, MessageBoxIcon.Warning);
        txtField.Focus();
        return false;
    }
    
    // More validations...
    return true;
}
```

### 6. SQL Queries

**ALWAYS use parameterized queries:**

```csharp
// ✅ CORRECT - Parameterized
string query = "SELECT * FROM Users WHERE Username = @Username";
SqlParameter[] parameters = {
    new SqlParameter("@Username", username)
};

// ❌ WRONG - SQL Injection vulnerable
string query = "SELECT * FROM Users WHERE Username = '" + username + "'";
```

### 7. UI Guidelines

#### Form Layout
- Use GroupBoxes for logical sections
- Consistent spacing (30-35px between controls)
- Label width: ~100px, TextBox width: 150-200px
- Button sizes: 90-100px width, 30px height

#### Colors (Consistent Theme)
```csharp
// Primary Blue
Color.FromArgb(41, 128, 185)

// Success Green  
Color.FromArgb(46, 204, 113)

// Danger Red
Color.FromArgb(231, 76, 60)

// Dark Background
Color.FromArgb(52, 73, 94)

// Light Background
Color.FromArgb(236, 240, 241)
```

## 🔍 Code Review Checklist

Before submitting a pull request:

- [ ] Code follows naming conventions
- [ ] All database queries are parameterized
- [ ] Input validation is implemented
- [ ] Error handling with try-catch
- [ ] No hard-coded values (use constants/config)
- [ ] Using statements for IDisposable objects
- [ ] XML documentation comments on public methods
- [ ] Form has proper Close/Cancel functionality
- [ ] No compiler warnings
- [ ] Tested with sample data
- [ ] README updated if needed

## 🧪 Testing Guidelines

### Manual Testing
1. Test with valid data
2. Test with invalid data (empty fields, wrong formats)
3. Test boundary conditions (min/max values)
4. Test navigation (back buttons, closing forms)
5. Test with database disconnected (error handling)

### Database Testing
```sql
-- Test data insertion
SELECT * FROM TableName WHERE ID = @NewID;

-- Test data update
SELECT * FROM TableName WHERE ID = @UpdatedID;

-- Test deletion
SELECT COUNT(*) FROM TableName WHERE ID = @DeletedID; -- Should be 0
```

## 📝 Pull Request Process

1. **Create a feature branch**
   ```bash
   git checkout -b feature/customer-management
   ```

2. **Make your changes**
   - Follow the patterns and guidelines above
   - Test thoroughly

3. **Commit with clear messages**
   ```bash
   git add .
   git commit -m "Implement customer management CRUD operations"
   ```

4. **Push to your fork**
   ```bash
   git push origin feature/customer-management
   ```

5. **Create Pull Request**
   - Clear title describing the feature
   - Description of changes made
   - Screenshots if UI changes
   - List any testing done

## 🎓 Learning Resources

### Understanding the Codebase
- Start with `FormLogin.cs` - Simple authentication flow
- Study `FormManageVehicles.cs` - Complete CRUD example
- Review `DatabaseConnection.cs` - Database patterns
- Check `ValidationHelper.cs` - Input validation patterns

### External Resources
- [C# Coding Conventions](https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/coding-conventions)
- [Windows Forms Best Practices](https://docs.microsoft.com/en-us/dotnet/desktop/winforms/advanced/best-practices)
- [ADO.NET Tutorial](https://docs.microsoft.com/en-us/dotnet/framework/data/adonet/)
- [SQL Server T-SQL](https://docs.microsoft.com/en-us/sql/t-sql/language-reference)

## 🐛 Bug Reports

When reporting bugs, include:
- **Description**: What happened vs. what you expected
- **Steps to Reproduce**: Detailed steps to reproduce the issue
- **Environment**: Windows version, VS version, SQL Server version
- **Screenshots**: If applicable
- **Error Messages**: Complete error message and stack trace

Example:
```
**Bug**: Vehicle search not working

**Steps**:
1. Open Vehicle Management
2. Enter "Toyota" in search box
3. Click Search button

**Expected**: Show Toyota vehicles
**Actual**: Shows all vehicles

**Error Message**: None

**Environment**: 
- Windows 11
- Visual Studio 2022
- SQL Server 2019 Express
```

## 💡 Feature Requests

When suggesting features:
- Describe the feature clearly
- Explain the use case
- Suggest implementation approach (if you have ideas)
- Consider existing patterns in the codebase

## 🔒 Security Guidelines

### Password Security
- Never store plain text passwords
- Use Argon2, bcrypt, or PBKDF2 (not MD5 in production)
- Implement password complexity requirements
- Add account lockout after failed attempts

### Input Validation
- Validate all user inputs
- Sanitize data before display
- Use parameterized queries
- Check file uploads (if implemented)

### Error Messages
- Don't expose sensitive information
- No database connection strings in errors
- No stack traces to end users
- Log detailed errors server-side

## 📞 Getting Help

- **Questions**: Open a GitHub Discussion
- **Bugs**: Create an Issue with bug template
- **Features**: Create an Issue with feature template
- **Security**: Email maintainers directly (don't create public issue)

## 🎯 Good First Issues

Looking to contribute? Start with these:

1. **Add Export to Excel**
   - File: `FormRentalHistory.cs`
   - Use `ReportHelper.ExportToCSV()` as reference

2. **Implement Customer Management**
   - File: `FormManageCustomers.cs`
   - Copy pattern from `FormManageVehicles.cs`

3. **Add Input Validation Messages**
   - Improve validation messages in existing forms
   - Make them more user-friendly

4. **Improve UI Consistency**
   - Standardize button sizes
   - Align controls properly
   - Use consistent colors

5. **Add Unit Tests**
   - Create test project
   - Test validation methods
   - Test calculations

## 📜 License

By contributing, you agree that your contributions will be licensed under the same license as the project.

## 🙏 Thank You!

Every contribution helps make this project better. Whether it's code, documentation, bug reports, or feature ideas - we appreciate your effort!

---

**Happy Coding! 🚗💨**
