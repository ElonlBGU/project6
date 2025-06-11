using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project6
{
    public partial class ManageEmployees : Form
    {
        public ManageEmployees()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        

        private void ManageEmployees_Load_1(object sender, EventArgs e)
        {
            comboBoxStatus.Items.Add("Active");
            comboBoxStatus.Items.Add("Resigned");
            comboBoxStatus.Items.Add("Fired");
            comboBoxStatus.Items.Add("Unpaid Leave");
            SQL_CON sql = new SQL_CON();
            SqlCommand cmd = new SqlCommand("SELECT name FROM sys.tables WHERE name LIKE '%Employee' AND name != 'Employees'");
            SqlDataReader reader = sql.execute_query(cmd);

            comboBoxType.Items.Clear();
            while (reader.Read())
            {
                string tableName = reader["name"].ToString();
                if (tableName.EndsWith("Employee"))
                {
                    string typeName = tableName.Replace("Employee", "").Trim();
                    comboBoxType.Items.Add(typeName);
                }
            }
            reader.Close();
        }
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnBrows_Click(object sender, EventArgs e)
        {
            // Create a window that lets the user pick a file
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Only show .pdf files in that window
            openFileDialog.Filter = "PDF files (*.pdf)|*.pdf";

            // Show a title on the window
            openFileDialog.Title = "Select a Contract PDF";

            // If the user clicks OK (and selects a file)
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Show the file path in the TextBox
                txtContractPath.Text = openFileDialog.FileName;
            }
        }

        private void btnAddDay_Click(object sender, EventArgs e)
        {
            string employeeId = txtEmployeeIdDate.Text.Trim();

            if (string.IsNullOrWhiteSpace(employeeId))
            {
                MessageBox.Show("Please enter an Employee ID.", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!EmployeeExists(employeeId))
            {
                MessageBox.Show("Employee ID does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string dayType = radioVacation.Checked ? "Vacation Day" :
                             radioSick.Checked ? "Sickness Day" : "";

            if (dayType == "")
            {
                MessageBox.Show("Please select a type (Vacation Day or Sickness Day).", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime start = monthCalendar1.SelectionStart;
            DateTime end = monthCalendar1.SelectionEnd;

            int addedCount = 0;

            for (DateTime date = start; date <= end; date = date.AddDays(1))
            {
                string existingType;
                if (!CanInsertDayOff(employeeId, date, dayType, out existingType))
                {
                    if (existingType == dayType)
                        continue; // Skip duplicate

                    MessageBox.Show($"Cannot add {dayType} on {date.ToShortDateString()}. Employee already has a {existingType} on that day.",
                                    "Conflict", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    continue;
                }

                InsertDayOff(employeeId, date, dayType);
                addedCount++;
            }

            if (addedCount > 0)
            {
                AddUsedDays(employeeId, dayType, addedCount);
                MessageBox.Show($"{addedCount} {dayType}(s) were added for employee {employeeId}.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No new days were added (possibly due to conflicts or duplicates).", "No Changes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private bool EmployeeExists(string employeeId)
        {
            SQL_CON sql = new SQL_CON();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Employees WHERE employeeId = @id");
            cmd.Parameters.AddWithValue("@id", employeeId);

            SqlDataReader reader = sql.execute_query(cmd);
            if (reader != null && reader.Read())
            {
                int count = Convert.ToInt32(reader[0]);
                reader.Close();
                return count > 0;
            }

            return false;
        }

        private bool CanInsertDayOff(string employeeId, DateTime date, string newDayType, out string existingDayType)
        {
            existingDayType = null;

            SQL_CON sql = new SQL_CON();
            SqlCommand cmd = new SqlCommand(
                "SELECT dayOffType FROM EmployeeDayOff WHERE employeeId = @id AND dayOffDate = @date");
            cmd.Parameters.AddWithValue("@id", employeeId);
            cmd.Parameters.AddWithValue("@date", date.Date);

            SqlDataReader reader = sql.execute_query(cmd);
            if (reader != null && reader.Read())
            {
                existingDayType = reader["dayOffType"].ToString();
                reader.Close();
                return existingDayType == newDayType; // same type → skip silently
            }

            return true; // no entry yet → safe to insert
        }

        private void InsertDayOff(string employeeId, DateTime date, string dayType)
        {
            SQL_CON sql = new SQL_CON();
            SqlCommand cmd = new SqlCommand(
                "INSERT INTO EmployeeDayOff (employeeId, dayOffDate, dayOffType) VALUES (@id, @date, @type)");
            cmd.Parameters.AddWithValue("@id", employeeId);
            cmd.Parameters.AddWithValue("@date", date.Date);
            cmd.Parameters.AddWithValue("@type", dayType);

            sql.execute_non_query(cmd);
        }

        private void AddUsedDays(string employeeId, string dayType, int daysToAdd)
        {
            SQL_CON sql = new SQL_CON();

            string column = dayType == "Vacation Day" ? "usedVacationDays" : "usedSicknessDays";

            SqlCommand cmd = new SqlCommand(
                $"UPDATE Employees SET {column} = {column} + @days WHERE employeeId = @id");
            cmd.Parameters.AddWithValue("@days", daysToAdd);
            cmd.Parameters.AddWithValue("@id", employeeId);

            sql.execute_non_query(cmd);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            string name = txtName.Text;
            string address = txtAddress.Text;
            string phone = txtPhone.Text;
            string status = comboBoxStatus.SelectedItem?.ToString();
            string type = comboBoxType.SelectedItem?.ToString();
            DateTime hireDate = dtpHire.Value;
            int salary;

            // Validate empty fields
            if (string.IsNullOrWhiteSpace(id) || string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(address) || string.IsNullOrWhiteSpace(phone) ||
                string.IsNullOrWhiteSpace(status) || string.IsNullOrWhiteSpace(type))
            {
                MessageBox.Show("Please fill in all required fields.", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtSalary.Text, out salary))
            {
                MessageBox.Show("Salary must be a valid number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // New employee must be Active
            if (status != "Active")
            {
                MessageBox.Show("New employees must be created with 'Active' status only.", "Invalid Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // If CEO, check if another active CEO already exists
            if (type == "CEO")
            {
                try
                {
                    SQL_CON sqlCheck = new SQL_CON();
                    SqlCommand checkCmd = new SqlCommand(@"
                SELECT COUNT(*) 
                FROM Employees E
                JOIN CEOEmployee C ON E.employeeId = C.employeeId
                WHERE E.employeeStatus = 'Active'");
                    SqlDataReader reader = sqlCheck.execute_query(checkCmd);


                    int count = (int)checkCmd.ExecuteScalar();
                    reader.Close();

                    if (count > 0)
                    {
                        MessageBox.Show("There is already an active CEO in the system.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error checking CEO status: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
                    if (dtpQuit.Value != DateTimePicker.MinimumDateTime)
                    {
                         MessageBox.Show("New employees cannot have a quit date.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                         return;
                     }

            try
            {
                SQL_CON sql = new SQL_CON();

                // Insert into Employees table
                SqlCommand cmd = new SqlCommand(@"
            INSERT INTO Employees 
            (employeeId, employeeName, employeeAdress, employeePhone, hireDate, salary, employeeStatus)
            VALUES 
            (@id, @name, @address, @phone, @hire, @salary, @status)");
            
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@hire", hireDate);
                cmd.Parameters.AddWithValue("@salary", salary);
                cmd.Parameters.AddWithValue("@status", status);

                sql.execute_non_query(cmd);

                // Insert into the correct child table
                SqlCommand childCmd = null;

                if (type == "Administration")
                {
                    childCmd = new SqlCommand("INSERT INTO AdministrationEmployee (employeeId) VALUES (@id)");
                }
                else if (type == "Technical Support")
                {
                    childCmd = new SqlCommand("INSERT INTO TechnicalSupportEmployee (employeeId) VALUES (@id)");
                }
                else if (type == "CEO")
                {
                    childCmd = new SqlCommand("INSERT INTO CEOEmployee (employeeId) VALUES (@id)");
                }

                if (childCmd != null)
                {
                    childCmd.Parameters.AddWithValue("@id", id);
                    sql.execute_non_query(childCmd);  
                }

                MessageBox.Show("Employee created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            catch (Exception ex)
            {
                MessageBox.Show("Error inserting employee: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string id = txtID.Text.Trim();  // This is the fixed ID (cannot change)
            string name = txtName.Text.Trim();
            string address = txtAddress.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string status = comboBoxStatus.SelectedItem?.ToString();
            DateTime hireDate = dtpHire.Value;
            DateTime? quitDate = dtpQuit.Value;
            int salary;

            // 1️⃣ Check if the user tried to change the ID
            if (!txtID.Enabled)
            {
                MessageBox.Show("Employee ID cannot be changed.", "Edit Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2️⃣ Validate required fields
            if (string.IsNullOrWhiteSpace(id) ||
                string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(address) ||
                string.IsNullOrWhiteSpace(phone) ||
                string.IsNullOrWhiteSpace(status))
            {
                MessageBox.Show("Please fill in all required fields.", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3️⃣ Validate salary
            if (!int.TryParse(txtSalary.Text.Trim(), out salary))
            {
                MessageBox.Show("Salary must be a valid number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 4️⃣ Run the update
            try
            {
                SQL_CON sql = new SQL_CON();

                SqlCommand cmd = new SqlCommand(@"
UPDATE Employees
SET employeeName = @name,
    employeeAdress = @address,
    employeePhone = @phone,
    hireDate = @hireDate,
    quitDate = @quitDate,
    salary = @salary,
    employeeStatus = @status
WHERE employeeId = @id");

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@hireDate", hireDate);
                cmd.Parameters.AddWithValue("@quitDate", (object)quitDate ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@salary", salary);
                cmd.Parameters.AddWithValue("@status", status);

                sql.execute_non_query(cmd);

                MessageBox.Show($"Employee '{name}' (ID: {id}) updated successfully!",
                                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating employee '{name}' (ID: {id}): {ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // Clear Personal Information
            txtID.Text = "";
            txtName.Text = "";
            txtAddress.Text = "";
            txtPhone.Text = "";

            // Clear Job/Employment Information
            comboBoxStatus.SelectedIndex = -1;
            txtSalary.Text = "";
            comboBoxType.SelectedIndex = -1;
            txtContractPath.Text = "";

            // Reset Dates
            dtpHire.Value = DateTime.Today;
            dtpQuit.Value = DateTime.Today;

            // Clear Days Off Section
            radioVacation.Checked = false;
            radioSick.Checked = false;
            monthCalendar1.SetDate(DateTime.Today);

            txtID.Enabled = true; //Releases the lock on the ID field.
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string employeeId = txtSearch.Text.Trim();  // get input and remove spaces

            // 1️⃣ If the box is empty
            if (string.IsNullOrWhiteSpace(employeeId))
            {
                MessageBox.Show("Please enter an Employee ID to search.",
                                "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;  // Stop here
            }

            // 2️⃣ Search the database for that employee
            SQL_CON sql = new SQL_CON();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Employees WHERE employeeId = @id");
            cmd.Parameters.AddWithValue("@id", employeeId);

            SqlDataReader reader = sql.execute_query(cmd);

            // 3️⃣ If we found the employee
            if (reader != null && reader.Read())
            {
                // Fill the form with employee data
                txtName.Text = reader["employeeName"].ToString();
                txtAddress.Text = reader["employeeAdress"].ToString();
                txtPhone.Text = reader["employeePhone"].ToString();

                dtpHire.Value = Convert.ToDateTime(reader["hireDate"]);

                if (reader["quitDate"] != DBNull.Value)
                    dtpQuit.Value = Convert.ToDateTime(reader["quitDate"]);
                else
                    dtpQuit.Value = DateTime.Today;

                comboBoxStatus.Text = reader["employeeStatus"].ToString();
                txtSalary.Text = reader["salary"].ToString();

                reader.Close();

                txtID.Enabled = false; //lock the ID feild so it won't be changed


                // ✅ Enable the Edit button since data is now loaded
                btnEdit.Enabled = true;
            }
            else
            {
                // 4️⃣ Employee ID was not found
                MessageBox.Show("No employee found with the given ID.",
                                "Search Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnEdit.Enabled = false;
                reader?.Close();
            }
        }
    }
}
