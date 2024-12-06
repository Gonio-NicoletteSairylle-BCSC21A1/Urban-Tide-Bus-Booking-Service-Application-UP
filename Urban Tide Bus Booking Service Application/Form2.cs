using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Urban_Tide_Bus_Booking_Service_Application
{
    public partial class Form2UserMainMenu : Form
    {
        public string Username { get; set; } // Property to receive the username

        public Form2UserMainMenu()
        {
            InitializeComponent();
        }

        private void Form2UserMainMenu_Load(object sender, EventArgs e)
        {
            label1Userpriflename.Text = Username;
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button1book_Click(object sender, EventArgs e)
        {
            FormEditBookatrip editBookatrip = new FormEditBookatrip();
            editBookatrip.Show();
            this.Hide();
        }

        private void button2see_Click(object sender, EventArgs e)
        {
            FormSeeOngoingTrips Form = new FormSeeOngoingTrips();
            Form.Show();
            this.Hide();
        }

        private void button3routes_Click(object sender, EventArgs e)
        {
            FormEditBusRoutes EditBusRoutes = new FormEditBusRoutes();
            EditBusRoutes.Show();
            this.Hide();
        }

        private void button4schedules_Click(object sender, EventArgs e)
        {
            FormViewbusSchedules scheduleForm = new FormViewbusSchedules();
            scheduleForm.Show(); // Show the schedules form
        }

        private void Form2MainMenu_Load(object sender, EventArgs e)
        {

        }
        private void button6settings_Click(object sender, EventArgs e)
        {
            FormSetting settingsForm = new FormSetting();
            settingsForm.Show(); // Show the settings form
        }
        private void button7logout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Show Form1 (login form) and close Form2MainMenu
                Form1 loginForm = new Form1();
                loginForm.Show();
                this.Close(); // Close the main menu form
            }
        }

        private void dataGridView1BusAvailable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2Bustrip_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
