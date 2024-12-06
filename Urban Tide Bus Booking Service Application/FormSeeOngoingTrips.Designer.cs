namespace Urban_Tide_Bus_Booking_Service_Application
{
    partial class FormSeeOngoingTrips
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView2Bustrip = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.label2BUS = new System.Windows.Forms.Label();
            this.label1URBAN = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2Bustrip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(468, 31);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(366, 31);
            this.dateTimePicker1.TabIndex = 79;
            // 
            // dataGridView2Bustrip
            // 
            this.dataGridView2Bustrip.AllowUserToAddRows = false;
            this.dataGridView2Bustrip.AllowUserToDeleteRows = false;
            this.dataGridView2Bustrip.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2Bustrip.ColumnHeadersHeight = 35;
            this.dataGridView2Bustrip.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.title4,
            this.title5});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2Bustrip.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView2Bustrip.Location = new System.Drawing.Point(423, 78);
            this.dataGridView2Bustrip.Name = "dataGridView2Bustrip";
            this.dataGridView2Bustrip.ReadOnly = true;
            this.dataGridView2Bustrip.Size = new System.Drawing.Size(860, 636);
            this.dataGridView2Bustrip.TabIndex = 80;
            this.dataGridView2Bustrip.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2Bustrip_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Ongoing Trips";
            this.Column1.MinimumWidth = 130;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // title4
            // 
            this.title4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.title4.HeaderText = "Route";
            this.title4.MinimumWidth = 143;
            this.title4.Name = "title4";
            this.title4.ReadOnly = true;
            this.title4.Width = 143;
            // 
            // title5
            // 
            this.title5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.title5.HeaderText = "Price rate";
            this.title5.MinimumWidth = 130;
            this.title5.Name = "title5";
            this.title5.ReadOnly = true;
            this.title5.Width = 130;
            // 
            // Logo
            // 
            this.Logo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Logo.BackColor = System.Drawing.Color.Transparent;
            this.Logo.BackgroundImage = global::Urban_Tide_Bus_Booking_Service_Application.Properties.Resources.Logo_removebg_preview;
            this.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Logo.Location = new System.Drawing.Point(-3, -1);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(196, 145);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 81;
            this.Logo.TabStop = false;
            // 
            // label2BUS
            // 
            this.label2BUS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2BUS.AutoSize = true;
            this.label2BUS.BackColor = System.Drawing.Color.Transparent;
            this.label2BUS.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2BUS.ForeColor = System.Drawing.Color.LightCyan;
            this.label2BUS.Location = new System.Drawing.Point(153, 53);
            this.label2BUS.Name = "label2BUS";
            this.label2BUS.Size = new System.Drawing.Size(243, 27);
            this.label2BUS.TabIndex = 83;
            this.label2BUS.Text = "BUS BOOKING SERVICES";
            // 
            // label1URBAN
            // 
            this.label1URBAN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1URBAN.AutoSize = true;
            this.label1URBAN.BackColor = System.Drawing.Color.Transparent;
            this.label1URBAN.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1URBAN.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1URBAN.Location = new System.Drawing.Point(152, 18);
            this.label1URBAN.Name = "label1URBAN";
            this.label1URBAN.Size = new System.Drawing.Size(167, 35);
            this.label1URBAN.TabIndex = 82;
            this.label1URBAN.Text = "URBAN TIDE";
            // 
            // FormSeeOngoingTrips
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1283, 713);
            this.Controls.Add(this.label2BUS);
            this.Controls.Add(this.label1URBAN);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.dataGridView2Bustrip);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "FormSeeOngoingTrips";
            this.Text = "User (SeeOngoingTrips)";
            this.Load += new System.EventHandler(this.FormSeeOngoingTrips_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2Bustrip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView2Bustrip;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn title4;
        private System.Windows.Forms.DataGridViewTextBoxColumn title5;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label label2BUS;
        private System.Windows.Forms.Label label1URBAN;
    }
}