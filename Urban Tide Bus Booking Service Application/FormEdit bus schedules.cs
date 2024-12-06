using System;
using System.Globalization;
using System.Windows.Forms;

namespace Urban_Tide_Bus_Booking_Service_Application
{
    public partial class FormEdit_bus_schedules : Form
    {
        public FormEdit_bus_schedules()
        {
            InitializeComponent();
        }

        private void FormEdit_bus_schedules_Load(object sender, EventArgs e)
        {
            // Add a column to the DataGridView programmatically
            dataGridView2Bussched.Columns.Add("Time", "Time"); // Adds a column named "Time"
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); // Closes the form
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
