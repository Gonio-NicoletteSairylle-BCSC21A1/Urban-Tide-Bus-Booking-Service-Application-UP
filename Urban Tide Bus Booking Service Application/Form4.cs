using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Urban_Tide_Bus_Booking_Service_Application
{
    public partial class Form4CreateAccount : Form
    {
        public Form4CreateAccount()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string createusername = textBoxusername.Text;
            string createpassword = textBox1.Text; // Create Password textbox
            string confirmPassword = txtConfirmPassword.Text; // Confirm Password textbox
            DateTime selectedDate = dateTimePicker1.Value;

            // Validate input
            if (string.IsNullOrWhiteSpace(createusername) || string.IsNullOrWhiteSpace(createpassword))
            {
                MessageBox.Show("Error: Please enter a Username and a Password.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (createpassword != confirmPassword)
            {
                MessageBox.Show("Error: Password and Confirm Password do not match.", "Password Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // JSON file path
            string jsonFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "User.json");

            // MS Access database file path
            string databaseFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "UsersDB.msacc.accdb");

            // Load users from JSON
            List<User> jsonUsers = LoadUsersFromJson(jsonFilePath);

            // Load users from MS Access
            List<User> accessUsers = LoadUsersFromAccess(databaseFilePath);

            // Check if user exists in JSON or Access
            User jsonUser = jsonUsers.Find(u => u.Username.Equals(createusername, StringComparison.OrdinalIgnoreCase));
            User accessUser = accessUsers.Find(u => u.Username.Equals(createusername, StringComparison.OrdinalIgnoreCase));

            if (jsonUser != null || accessUser != null)
            {
                // Update existing user
                if (jsonUser != null)
                {
                    jsonUser.Password = createpassword;
                    jsonUser.Birthdate = selectedDate;
                }
                else
                {
                    jsonUsers.Add(new User { Username = createusername, Password = createpassword, Birthdate = selectedDate });
                }

                if (accessUser != null)
                {
                    UpdateUserInAccess(databaseFilePath, createusername, createpassword, selectedDate);
                }
            }
            else
            {
                // Add new user
                jsonUsers.Add(new User { Username = createusername, Password = createpassword, Birthdate = selectedDate });
                AddUserToAccess(databaseFilePath, createusername, createpassword, selectedDate);
            }

            // Save updated JSON data
            SaveUsersToJson(jsonFilePath, jsonUsers);

            // Notify user and navigate to main menu
            MessageBox.Show("Account successfully created or updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Form2UserMainMenu mainMenuForm = new Form2UserMainMenu
            {
                Username = createusername
            };
            mainMenuForm.Show();
            this.Hide();
        }

        private List<User> LoadUsersFromJson(string filePath)
        {
            if (!File.Exists(filePath)) return new List<User>();
            string jsonContent = File.ReadAllText(filePath);
            var users = JsonConvert.DeserializeObject<List<User>>(jsonContent) ?? new List<User>();

            // Ensure that if no Birthdate is provided, it defaults to a valid DateTime
            foreach (var user in users)
            {
                if (user.Birthdate == null)
                {
                    user.Birthdate = DateTime.MinValue; // Default to a valid value (or set to null if preferred)
                }
            }

            return users;
        }

        private void SaveUsersToJson(string filePath, List<User> users)
        {
            File.WriteAllText(filePath, JsonConvert.SerializeObject(users, Formatting.Indented));
        }

        private List<User> LoadUsersFromAccess(string databaseFilePath)
        {
            List<User> users = new List<User>();
            try
            {
                using (OleDbConnection connection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={databaseFilePath};"))
                {
                    connection.Open();
                    string query = "SELECT Username, [Password], Birthdate FROM Users";
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            users.Add(new User
                            {
                                Username = reader.IsDBNull(0) ? string.Empty : reader.GetString(0),
                                Password = reader.IsDBNull(1) ? string.Empty : reader.GetString(1),
                                Birthdate = reader.IsDBNull(2) ? (DateTime?)null : reader.GetDateTime(2)
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading MS Access database: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return users;
        }

        private void AddUserToAccess(string databaseFilePath, string username, string password, DateTime birthdate)
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={databaseFilePath};"))
                {
                    connection.Open();
                    string query = "INSERT INTO Users (Username, [Password], Birthdate) VALUES (?, ?, ?)";
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("?", username);
                        command.Parameters.AddWithValue("?", password);
                        command.Parameters.AddWithValue("?", birthdate);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding user to MS Access database: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateUserInAccess(string databaseFilePath, string username, string password, DateTime birthdate)
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={databaseFilePath};"))
                {
                    connection.Open();
                    string query = "UPDATE Users SET [Password] = ?, Birthdate = ? WHERE Username = ?";
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("?", password);
                        command.Parameters.AddWithValue("?", birthdate);
                        command.Parameters.AddWithValue("?", username);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating user in MS Access database: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public class User
        {
            public string Username { get; set; }
            public string Password { get; set; }
            public DateTime? Birthdate { get; set; }
        }

        private void Form4CreateAccount_Load(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }
}
