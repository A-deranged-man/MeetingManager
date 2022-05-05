namespace CMP307_TayMark_App
{
    partial class Main_Window
    {

        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Window));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ManageBookingsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEmployeesToMeetingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ManageStaffMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ManageRoomsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ManageBookingsMenuItem,
            this.addEmployeesToMeetingToolStripMenuItem,
            this.ManageStaffMenuItem,
            this.ManageRoomsMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 4, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(168, 625);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ManageBookingsMenuItem
            // 
            this.ManageBookingsMenuItem.ForeColor = System.Drawing.Color.White;
            this.ManageBookingsMenuItem.Name = "ManageBookingsMenuItem";
            this.ManageBookingsMenuItem.Padding = new System.Windows.Forms.Padding(4, 20, 4, 0);
            this.ManageBookingsMenuItem.Size = new System.Drawing.Size(155, 39);
            this.ManageBookingsMenuItem.Text = "Manage and Add Bookings";
            this.ManageBookingsMenuItem.Click += new System.EventHandler(this.ManageBookingsMenuItem_Click);
            // 
            // addEmployeesToMeetingToolStripMenuItem
            // 
            this.addEmployeesToMeetingToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.addEmployeesToMeetingToolStripMenuItem.Name = "addEmployeesToMeetingToolStripMenuItem";
            this.addEmployeesToMeetingToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 20, 4, 0);
            this.addEmployeesToMeetingToolStripMenuItem.Size = new System.Drawing.Size(155, 39);
            this.addEmployeesToMeetingToolStripMenuItem.Text = "Add Employees to Meeting";
            this.addEmployeesToMeetingToolStripMenuItem.Click += new System.EventHandler(this.addEmployeesToMeetingToolStripMenuItem_Click);
            // 
            // ManageStaffMenuItem
            // 
            this.ManageStaffMenuItem.ForeColor = System.Drawing.Color.White;
            this.ManageStaffMenuItem.Name = "ManageStaffMenuItem";
            this.ManageStaffMenuItem.Padding = new System.Windows.Forms.Padding(4, 20, 4, 0);
            this.ManageStaffMenuItem.Size = new System.Drawing.Size(155, 39);
            this.ManageStaffMenuItem.Text = "Manage Staff";
            this.ManageStaffMenuItem.Click += new System.EventHandler(this.ManageStaffMenuItem_Click);
            // 
            // ManageRoomsMenuItem
            // 
            this.ManageRoomsMenuItem.ForeColor = System.Drawing.Color.White;
            this.ManageRoomsMenuItem.Name = "ManageRoomsMenuItem";
            this.ManageRoomsMenuItem.Padding = new System.Windows.Forms.Padding(4, 20, 4, 0);
            this.ManageRoomsMenuItem.Size = new System.Drawing.Size(155, 39);
            this.ManageRoomsMenuItem.Text = "Manage Rooms";
            this.ManageRoomsMenuItem.Click += new System.EventHandler(this.ManageRoomsMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 438);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 171);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Main_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1064, 625);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main_Window";
            this.Text = "Main_Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_Form_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ManageStaffMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ManageRoomsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ManageBookingsMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem addEmployeesToMeetingToolStripMenuItem;
    }
}