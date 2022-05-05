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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {

            DBConnection conn = new DBConnection();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand();
            String query = "SELECT * FROM `307_user` WHERE `userid`=@EmployeeID AND `password`=@pass";

            command.CommandText = query;
            command.Connection = conn.getConnection();

            command.Parameters.Add("@EmployeeID", MySqlDbType.VarChar).Value = UserIDTB.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = gvars.PasswordHashed(PasswordTB.Text);

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if(table.Rows.Count > 0)
            {

                DataRow Row = table.Rows[0];
                gvars.Userid1 = Convert.ToInt32(UserIDTB.Text);
                String IsAdmin = Row["isAdmin"].ToString();
                if (IsAdmin == "True")
                {
                    gvars.Admin1 = 1;
                }
                else
                {

                }
                this.Hide();
                Main_Window mform = new Main_Window();
                mform.Show();
                
            }
            else
            {
                if(UserIDTB.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Enter Your Username to Login", "Empty Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (PasswordTB.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Enter Your Password to Login", "Empty Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("This Username Or Password Doesn't Exists", "Wrong Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }
    }
}
