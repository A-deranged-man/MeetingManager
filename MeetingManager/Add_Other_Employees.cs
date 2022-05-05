using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace CMP307_TayMark_App
{
    public partial class Add_Other_Employees : Form
    {
        AddToBooking ATB = new AddToBooking();

        public Add_Other_Employees()
        {
            InitializeComponent();

        }

        private void Add_Other_EmployeesForm_Load(object sender, EventArgs e)
        {
            Emp_Grid.DataSource = ATB.GetEmployees();
            dataGridView1.DataSource = ATB.GetBookingsAll();

            DBConnection conn = new DBConnection();
            MySqlCommand cmd = new MySqlCommand("select booking_id from 307_booking where userid = @userid AND `307_booking`.`date` = CURDATE()", conn.getConnection());
            cmd.Parameters.Add("@userid", MySqlDbType.Int32).Value = gvars.Userid1;
            conn.openConnection();
            MySqlDataReader DR = cmd.ExecuteReader();

            while (DR.Read())
            {
                ComboBoxBookingID.Items.Add(DR[0]);

            }
        }


        private void ButtonAddStaffToBooking_Click_1(object sender, EventArgs e)
        {
            string selected = this.ComboBoxBookingID.GetItemText(this.ComboBoxBookingID.SelectedItem);
            int bookingid = Convert.ToInt32(selected);
            int userid = Convert.ToInt32(EmployeeIDTB.Text);

            Boolean InsertUserBooking = ATB.AddUsertoBooking(bookingid, userid);

            if (InsertUserBooking)
            {
                Emp_Grid.DataSource = ATB.GetEmployees();
                dataGridView1.DataSource = ATB.GetBookingsAll();
                MessageBox.Show("New Staff added Successfuly", "Add Staff", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("ERROR - Staff Not added", "Add Staff", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
