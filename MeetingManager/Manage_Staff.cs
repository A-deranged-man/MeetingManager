using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMP307_TayMark_App
{
    public partial class Manage_Staff : Form
    {
        Staff staffC = new Staff();

        public Manage_Staff()
        {
            InitializeComponent();
        }

        
        private void ManageStaffForm_Load(object sender, EventArgs e)
        {
            DataGridView1.DataSource = staffC.GetStaff();
        }

        private void ButtonAddStaff_Click(object sender, EventArgs e)
        {
            int userid = Convert.ToInt32(textBoxID.Text);
            String fname = textBoxFirstName.Text;
            String lname = textBoxLastName.Text;
            String email = textBoxEmail.Text;
            String password = gvars.PasswordHashed(textBoxPassword.Text);

            if (fname.Trim().Equals("") || lname.Trim().Equals("") || email.Trim().Equals(""))
            {
                MessageBox.Show("Required Fields - First & Last Name, email & password", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Boolean InsertStaff = staffC.InsertStaff(userid, fname, lname, email, password);

                if (InsertStaff)
                {
                    DataGridView1.DataSource = staffC.GetStaff();
                    MessageBox.Show("New Staff Inserted Successfuly", "Add Staff", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("ERROR - Staff Not Inserted", "Add Staff", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void ButtonEditStaff_Click(object sender, EventArgs e)
        {
            String fname = textBoxFirstName.Text;
            String lname = textBoxLastName.Text;
            String email = textBoxEmail.Text;
            String password = gvars.PasswordHashed(textBoxPassword.Text);
            try
            {
                int userid = Convert.ToInt32(textBoxID.Text);

                if (fname.Trim().Equals("") || lname.Trim().Equals("") || email.Trim().Equals(""))
                {
                    MessageBox.Show("Required Fields - First & Last Name + Phone Number", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Boolean InsertStaff = staffC.EditStaff(userid, fname, lname, email, password);

                    if (InsertStaff)
                    {
                        DataGridView1.DataSource = staffC.GetStaff();
                        MessageBox.Show("New Staff Updated Successfuly", "Edit Staff", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("ERROR - Staff Not Updated", "Edit Staff", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "ID Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ButtonRemoveStaff_Click(object sender, EventArgs e)
        {
            try
            {
                int userid = Convert.ToInt32(textBoxID.Text);

                if(staffC.RemoveStaff(userid))
                {
                    DataGridView1.DataSource = staffC.GetStaff();
                    MessageBox.Show("Staff Deleted Successfuly", "Delete Staff", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ButtonClear.PerformClick();
                   
                }
                else
                {
                    MessageBox.Show("ERROR - Staff Not Deleted", "Delete Staff", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "ID Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            textBoxID.Text = "";
            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            textBoxEmail.Text = "";
            textBoxPassword.Text = "";
        }
    }
}
