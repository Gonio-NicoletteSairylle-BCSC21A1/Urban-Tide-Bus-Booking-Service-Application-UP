using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Urban_Tide_Bus_Booking_Service_Application
{
    public partial class FormEditBookatrip : Form
    {
        // A list to store places (simulating a database for simplicity)
        private List<string> places = new List<string>();

        public FormEditBookatrip()
        {
            InitializeComponent();
        }

        private void FormEditBookatrip_Load(object sender, EventArgs e)
        {
            // Initialize the DataGridView when the form loads
            RefreshDataGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Optional: Handle click event for label2 (if needed)
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (dataGridView2bustrips.SelectedRows.Count > 0)
            {
                // Get the index of the selected row
                int selectedIndex = dataGridView2bustrips.SelectedRows[0].Index;

                // Ensure the index is within bounds
                if (selectedIndex >= 0 && selectedIndex < places.Count)
                {
                    // Confirm the deletion with the admin
                    var confirmResult = MessageBox.Show(
                        $"Are you sure you want to delete '{places[selectedIndex]}'?",
                        "Confirm Deletion",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                    if (confirmResult == DialogResult.Yes)
                    {
                        // Remove the selected place from the list
                        places.RemoveAt(selectedIndex);

                        // Refresh the DataGridView to show the updated list
                        RefreshDataGrid();

                        MessageBox.Show("Place removed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a place to delete.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshDataGrid()
        {
            // Bind the list of places to the DataGridView
            dataGridView2bustrips.DataSource = places
                .Select((place, index) => new { ID = index + 1, Place = place })
                .ToList();

            // Optionally, adjust DataGridView columns for a better user experience
            dataGridView2bustrips.Columns[0].HeaderText = "ID";
            dataGridView2bustrips.Columns[1].HeaderText = "Place";

            // Enable full-row selection for easier usability
            dataGridView2bustrips.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
    }
}
