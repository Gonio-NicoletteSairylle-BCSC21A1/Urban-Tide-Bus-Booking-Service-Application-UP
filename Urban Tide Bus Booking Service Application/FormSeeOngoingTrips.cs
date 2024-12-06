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
    public partial class FormSeeOngoingTrips : Form
    {
        DataTable table = new DataTable("table");
        int index;
        public FormSeeOngoingTrips()
        {
            InitializeComponent();
        }

        private void FormSeeOngoingTrips_Load(object sender, EventArgs e)
        {
            table.Columns.Add("Ongoing Bus", Type.GetType("System.String"));
            table.Columns.Add("Route", Type.GetType("System.String"));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2Bustrip_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
