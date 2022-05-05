using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CMP307_TayMark_App
{
    public partial class Main_Window : Form
    {
        public Main_Window()
        {
            InitializeComponent();
        }

        private void Main_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ManageStaffMenuItem_Click(object sender, EventArgs e)
        {
            if (gvars.Admin1 == 1)
            {
                Manage_Staff manageStaff = new Manage_Staff();
                manageStaff.ShowDialog();
            }
            else
            {
                MessageBox.Show("This feature is restricted to administrators only", "Invalid Account Credentials", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ManageRoomsMenuItem_Click(object sender, EventArgs e)
        {
            if (gvars.Admin1 == 1)
            {
                Manage_Rooms manageRooms = new Manage_Rooms();
                manageRooms.ShowDialog();
            }
            else
            {
                MessageBox.Show("This feature is restricted to administrators only", "Invalid Account Credentials", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ManageBookingsMenuItem_Click(object sender, EventArgs e)
        {
           
                Manage_Bookings manageBookings = new Manage_Bookings();
                manageBookings.ShowDialog();
            
            
        }

        private void addEmployeesToMeetingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Other_Employees ATB = new Add_Other_Employees();
            ATB.ShowDialog();
        }
    }
}
