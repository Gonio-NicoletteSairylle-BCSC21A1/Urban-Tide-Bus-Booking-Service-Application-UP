using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace Urban_Tide_Bus_Booking_Service_Application
{
    public partial class FormforgetPass : Form
    {
        public FormforgetPass()
        {
            InitializeComponent();
        }

        private void label1URBAN_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string enteredUsername = textBox1username.Text.Trim();
            DateTime selectedDate = dateTimePicker1.Value;

            // Path for the forpass.json file
            string filePath = @"C:\Users\Bravo\Documents\Data Structures\User.json";

            // Read the JSON content from the file
            if (File.Exists(filePath))
            {
                string jsonContent = File.ReadAllText(filePath);
                var userData = JsonConvert.DeserializeObject<UserData>(jsonContent);

                // Validate the entered username and birthdate against the JSON data
                bool isUsernameCorrect = enteredUsername == userData.Username;
                bool isBirthdateCorrect = selectedDate.ToString("yyyy-MM-dd") == userData.Birthdate;

                if (isUsernameCorrect && isBirthdateCorrect)
                {
                    MessageBox.Show("Login successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Open Form2UserMainMenu
                    Form2UserMainMenu mainMenuForm = new Form2UserMainMenu();
                    mainMenuForm.Show();
                    this.Close();
                }
                else
                {
                    // Display error messages if validation fails
                    if (!isUsernameCorrect)
                    {
                        MessageBox.Show("Error: Incorrect username", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Error: Incorrect birthdate.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Error: forpass.json file not found.", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormforgetPass_Load(object sender, EventArgs e)
        {

        }
    }

    // Class to store the user data from the forpass.json file
    public class UserData
    {
        public string Username { get; set; }
        public string Birthdate { get; set; }
    }
}
