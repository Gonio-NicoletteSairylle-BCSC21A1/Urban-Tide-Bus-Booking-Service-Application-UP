using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Data.OleDb;

namespace Urban_Tide_Bus_Booking_Service_Application
{
    public partial class Form1 : Form
    {
        private readonly IUserRepository _repository;

        public Form1()
        {
            InitializeComponent();

            // Set up the repository (choose between JSON and MS Access dynamically)
            string jsonFilePath = Path.Combine(Application.StartupPath, "User.json");
            string accessConnectionString = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Path.Combine(Application.StartupPath, "UsersDB.msacc.accdb")}";

            // Dynamically choose repository: JSON or Access
            // For demonstration, using JSON. Change to AccessUserRepository if needed.
            _repository = new JsonUserRepository(jsonFilePath);
            
            // _repository = new AccessUserRepository(accessConnectionString);
        }

        // User model class
        public class User
        {
            public string Username { get; set; }
            public string Password { get; set; }
        }

        // IUserRepository interface
        public interface IUserRepository
        {
            List<User> GetUsers();
            void AddUser(User user);
            bool ValidateUser(string username, string password);
        }

        // JSON repository implementation
        public class JsonUserRepository : IUserRepository
        {
            private readonly string _filePath;

            public JsonUserRepository(string filePath)
            {
                _filePath = filePath;
            }

            public List<User> GetUsers()
            {
                if (!File.Exists(_filePath))
                    return new List<User>();

                string jsonContent = File.ReadAllText(_filePath);
                return JsonConvert.DeserializeObject<List<User>>(jsonContent) ?? new List<User>();
            }

            public void AddUser(User user)
            {
                var users = GetUsers();
                users.Add(user);

                string jsonContent = JsonConvert.SerializeObject(users, Formatting.Indented);
                File.WriteAllText(_filePath, jsonContent);
            }

            public bool ValidateUser(string username, string password)
            {
                var users = GetUsers();
                return users.Exists(u => u.Username.Equals(username, StringComparison.OrdinalIgnoreCase) && u.Password == password);
            }
        }

        // MS Access repository implementation
        public class AccessUserRepository : IUserRepository
        {
            private readonly string _connectionString;

            public AccessUserRepository(string connectionString)
            {
                _connectionString = connectionString;
            }

            public List<User> GetUsers()
            {
                var users = new List<User>();

                using (var connection = new OleDbConnection(_connectionString))
                {
                    connection.Open();
                    string query = "SELECT Username, Password FROM Users";

                    using (var command = new OleDbCommand(query, connection))
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            users.Add(new User
                            {
                                Username = reader.GetString(0),
                                Password = reader.GetString(1)
                            });
                        }
                    }
                }

                return users;
            }

            public void AddUser(User user)
            {
                using (var connection = new OleDbConnection(_connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Users (Username, Password) VALUES (@Username, @Password)";

                    using (var command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", user.Username);
                        command.Parameters.AddWithValue("@Password", user.Password);
                        command.ExecuteNonQuery();
                    }
                }
            }

            public bool ValidateUser(string username, string password)
            {
                using (var connection = new OleDbConnection(_connectionString))
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM Users WHERE Username = @Username AND Password = @Password";

                    using (var command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);
                        return (int)command.ExecuteScalar() > 0;
                    }
                }
            }
        }

        // Login button click event handler
        private void button1Login_Click(object sender, EventArgs e)
        {
            string username = textBox1Username.Text.Trim();
            string password = textBox2Password.Text.Trim();

            // Get users from both repositories
            List<User> jsonUsers = new JsonUserRepository(Path.Combine(Application.StartupPath, "User.json")).GetUsers();
            List<User> accessUsers = new AccessUserRepository($@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Path.Combine(Application.StartupPath, "UsersDB.msacc.accdb")}").GetUsers();

            // Find the user in both storage mediums
            User jsonUser = jsonUsers.Find(u => u.Username.Equals(username, StringComparison.OrdinalIgnoreCase));
            User accessUser = accessUsers.Find(u => u.Username.Equals(username, StringComparison.OrdinalIgnoreCase));

            // If user is not found in either medium
            if (jsonUser == null || accessUser == null)
            {
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate passwords match
            if (jsonUser.Password != password || accessUser.Password != password)
            {
                MessageBox.Show("Password mismatch between JSON and database records.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Proceed to login based on roles
            if (username.Equals("admin", StringComparison.OrdinalIgnoreCase) && password == "admin123")
            {
                Form3AdministratorPage adminPage = new Form3AdministratorPage();
                adminPage.Show();
                this.Hide();
            }
            else
            {
                Form2UserMainMenu userMainMenu = new Form2UserMainMenu();
                userMainMenu.Show();
                this.Hide();
            }
        }



        // Create account button click event
        private void button2guest_Click(object sender, EventArgs e)
        {
            Form4CreateAccount form4 = new Form4CreateAccount();
            form4.Show();
            this.Hide();
        }

        // Forgot password link click event
        private void linkLabel1Forgotuserorpass_Click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormforgetPass form4 = new FormforgetPass();
            form4.Show();
            this.Hide();
        }

        // Form closing event handler
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        // Form load event handler (optional)
        private void Form1_Load(object sender, EventArgs e)
        {
            // Optional: Any initialization logic
        }
    }
}
