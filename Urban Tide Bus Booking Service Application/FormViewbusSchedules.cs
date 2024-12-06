using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Urban_Tide_Bus_Booking_Service_Application
{
    public partial class FormViewbusSchedules : Form
    {
        DataTable table=new DataTable("table");
        int index;

        public FormViewbusSchedules()
        {
            InitializeComponent();
        }

        private void FormViewbusSchedules_Load(object sender, EventArgs e)
        {
            table.Columns.Add("Bus Id", Type.GetType("System.String"));
            table.Columns.Add("Route", Type.GetType("System.String"));
            table.Columns.Add("Schedule Departure", Type.GetType("System.String"));
            dataGridView1.DataSource = table;
        }

       private void button2_Click(object sender, EventArgs e)
        {
            table.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text=String.Empty;
            textBox2.Text=String.Empty;
            textBox3.Text=String.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row=dataGridView1.Rows[index];
            textBox1.Text=row.Cells[0].Value.ToString();
            textBox2.Text = row.Cells[1].Value.ToString();
            textBox3.Text = row.Cells[2].Value.ToString();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataGridViewRow newdata = dataGridView1.Rows[index];
            newdata.Cells[0].Value = textBox1.Text;
            newdata.Cells[1].Value = textBox2.Text;
            newdata.Cells[2].Value = textBox3.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            index=dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(index);

        }

    }
}
