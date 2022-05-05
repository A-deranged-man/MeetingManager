using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace CMP307_TayMark_App
{
    class Bookings
    {
        DBConnection conn = new DBConnection();

        public DataTable GetAllBookings()
        {
            MySqlCommand command = new MySqlCommand("SELECT `booking_id` AS \"Booking Number\", `room_id` AS \"Room Number\", `userid` AS \"Organiser\", `time_in` AS \"Time Starting\", `time_out` AS \"Time Finishing\"FROM `307_booking` WHERE date = CURDATE()", conn.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }

        public bool AddBooking(int roomid, int userid ,String TimeIn, String TimeOut)
        {
            MySqlCommand command = new MySqlCommand();
            String insertQuery = "INSERT INTO `307_booking`(`room_id`,`userid`, `date`, `time_in`,`time_out`) VALUES (@rnm,@userid,@date,@tin,@tout)";
            command.CommandText = insertQuery;
            command.Connection = conn.getConnection();

            command.Parameters.Add("@rnm", MySqlDbType.Int32).Value = roomid;
            command.Parameters.Add("@userid", MySqlDbType.Int32).Value = userid;
            command.Parameters.Add("@date",MySqlDbType.Date).Value = DateTime.Today;
            command.Parameters.Add("@tin", MySqlDbType.String).Value = TimeIn;
            command.Parameters.Add("@tout", MySqlDbType.String).Value = TimeOut;

            conn.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                conn.closeConnection();
                return true;
            }
            else
            {
                conn.closeConnection();
                return false;
            }

        }

       

    }
}
