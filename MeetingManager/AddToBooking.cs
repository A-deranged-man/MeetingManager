using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace CMP307_TayMark_App
{
    class AddToBooking
    {
        DBConnection conn = new DBConnection();

        public DataTable GetEmployees()
        {
            MySqlCommand command = new MySqlCommand("SELECT `userid` AS \"Employee Number\", `first_name` AS \"First Name\",`last_name` AS \"Last Name\",`email` FROM `307_user`", conn.getConnection());
            conn.openConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            
            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }

        public DataTable GetBookingsAll()
        {
            MySqlCommand command = new MySqlCommand("SELECT `307_booking`.`booking_id` AS \"Booking Number\", `307_room`.`name` AS \"Room\", `307_booking`.`userid` AS \"Organiser\",`307_booking_members`.`userid` AS \"Additional Members\" ,`307_booking`.`time_in` AS \"Time Starting\", `307_booking`.`time_out` AS \"Time Finishing\" FROM `307_booking`, `307_booking_members`, `307_room` WHERE `307_booking`.`booking_id` = `307_booking_members`.`booking_id` AND `307_booking`.`room_id` = `307_room`.`room_id` AND `307_booking`.`date` = CURDATE() ORDER BY `Booking Number` ASC ", conn.getConnection());
            conn.openConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }


        public bool AddUsertoBooking(int bookingid, int userid)
        {   
            MySqlCommand command = new MySqlCommand();
            String insertQuery = "INSERT INTO `307_booking_members`(`booking_id`, `userid`) VALUES (@bookingid,@userid)";
            command.CommandText = insertQuery;
            command.Connection = conn.getConnection();

            command.Parameters.Add("@bookingid", MySqlDbType.Int32).Value = bookingid;
            command.Parameters.Add("@userid", MySqlDbType.Int32).Value = userid;

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
