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
    public partial class Manage_Bookings : Form
    {
        public Manage_Bookings()
        {
            InitializeComponent();
        }

        Rooms room = new Rooms();
        Bookings booking = new Bookings();

        private void Manage_BookingsForm_Load(object sender, EventArgs e)
        {
            DataGridView1.DataSource = booking.GetAllBookings();
            dataGridView2.DataSource = room.GetRooms();

            DBConnection conn = new DBConnection();
            MySqlCommand cmd = new MySqlCommand("select room_id from 307_room", conn.getConnection());
            conn.openConnection();
            MySqlDataReader DR = cmd.ExecuteReader();

            while (DR.Read())
            {
                ComboBoxRoomNumber.Items.Add(DR[0]);

            }

        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            ComboBoxRoomNumber.Text = "";
            TimePickerIN.Value = DateTime.Now;
            TimePickerOUT.Value = DateTime.Now;
        }

        private void buttonAddBooking_Click(object sender, EventArgs e)
        {
            try
            {
                int userid = gvars.Userid1;
                string selected = this.ComboBoxRoomNumber.GetItemText(this.ComboBoxRoomNumber.SelectedItem);
                int roomid = Convert.ToInt32(selected);
                DateTime dateIn = TimePickerIN.Value;
                String TimeIn = dateIn.ToShortTimeString();
                
                DateTime dateOut = TimePickerOUT.Value;
                String TimeOut = dateOut.ToShortTimeString();

                DateTime StartHour = DateTime.Parse(DateTime.Now.ToString("yyyy.MM.dd") + " " + "09:00:00");
                DateTime EndHour = DateTime.Parse(DateTime.Now.ToString("yyyy.MM.dd") + " " + "17:00:00");

                int CompareStartTime = DateTime.Compare(dateIn, StartHour);
                int CompareEndTime = DateTime.Compare(dateOut, EndHour);

                TimeSpan DurationCheck = DateTime.Parse(TimeOut).Subtract(DateTime.Parse(TimeIn));
                TimeSpan DurationCheckMaxTime = TimeSpan.FromHours(1);
                int CompMeetingTime = TimeSpan.Compare(DurationCheck, DurationCheckMaxTime);

                TimeSpan DurationCheckMinTime = TimeSpan.FromMinutes(5);
                int CompMeetingTime2 = TimeSpan.Compare(DurationCheck, DurationCheckMinTime);


                if (DateTime.Compare(dateIn.Date,DateTime.Now.Date) < 0)
                {
                    MessageBox.Show("The Date In Must Be = or > To Today Date", "Invalid Date In", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if(DateTime.Compare(dateOut.Date, dateIn.Date) < 0)
                {
                    MessageBox.Show("The Date Out Must Be = or > To Date In", "Invalid Date Out", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (TimeIn == TimeOut)
                {
                    MessageBox.Show("The time needs to be different, at lease 5 mins apart", "Invalid Time Paramaters", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (CompMeetingTime == 1)
                {
                    MessageBox.Show("You cannot book a meeting over an hour in length", "Invalid Time Paramaters", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (CompMeetingTime2 < 0)
                {
                    MessageBox.Show("You cannot book a meeting under 5 mins in length", "Invalid Time Paramaters", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (CompareEndTime >0)
                {
                    MessageBox.Show("You cannot book a meeting after 5:00PM", "Invalid Time Paramaters", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (CompareStartTime < 0)
                {
                    MessageBox.Show("You cannot book a meeting before 9:00AM", "Invalid Time Paramaters", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
               
                else
                {
                    if (booking.AddBooking(roomid, userid, TimeIn, TimeOut))
                    {
                        DataGridView1.DataSource = booking.GetAllBookings();
                        MessageBox.Show("New booking Added", "Add booking", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("booking NOT Added", "Add booking", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Add booking Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            
        }
    }
}