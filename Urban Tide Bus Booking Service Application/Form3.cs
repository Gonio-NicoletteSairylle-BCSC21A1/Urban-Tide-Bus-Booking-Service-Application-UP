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
    public partial class Form3AdministratorPage : Form
    {
        public Form3AdministratorPage()
        {
            InitializeComponent();
        }

        private void button6settings_Click(object sender, EventArgs e)
        {

            // Open the settings form
            FormSettingAdmin settingsForm = new FormSettingAdmin();
            settingsForm.Show(); // Show the settings form
        }

        private void label1Userpriflename_Click(object sender, EventArgs e)
        {

        }

        private void label1URBAN_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1welcome_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void button5profile_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
        private void button1book_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button4schedules_Click(object sender, EventArgs e)
        {

        }

        private void button2see_Click(object sender, EventArgs e)
        {
            FormSeeOngoingTrips formSeeOngoingTrips = new FormSeeOngoingTrips();
            formSeeOngoingTrips.Show();
        }

        private void label2How_Click(object sender, EventArgs e)
        {

        }

        private void Form3AdministratorPage_Load(object sender, EventArgs e)
        {

        }

        private void button3routes_Click(object sender, EventArgs e)
        {
            FormEditBusRoutes editBusRoutes = new FormEditBusRoutes();
            editBusRoutes.Show();
        }

        private void button1book_Click_1(object sender, EventArgs e)
        {
            FormEditBookatrip formEditBookatrip = new FormEditBookatrip();
            formEditBookatrip.Show();
        }

        private void button2see_Click_1(object sender, EventArgs e)
        {
            FormEditongoingtrips formEditongoingtrips = new FormEditongoingtrips();
            formEditongoingtrips.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormEdit_bus_schedules formEdit_Bus_Schedules = new FormEdit_bus_schedules();
            formEdit_Bus_Schedules.Show();
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
    }
}