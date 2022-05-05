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
    public partial class Manage_Rooms : Form
    {
        public Manage_Rooms()
        {
            InitializeComponent();
        }

        Rooms room = new Rooms();
        private void ManageRoomsForm_Load(object sender, EventArgs e)
        {
       
            DataGridView1.DataSource = room.GetRooms();

        }

        private void ButtonAddRoom_Click(object sender, EventArgs e)
        {
            
            
            string roomname = RoomNameTB.Text;
            int room_id = Convert.ToInt32(RoomNumberTB.Text);
            int capacity = Convert.ToInt32(CapacityTB.Text);
            

            try
            { 
                if (room.AddRoom(room_id,roomname,capacity))
                {
                    DataGridView1.DataSource = room.GetRooms();
                    MessageBox.Show("Room Added Successfully", "Add Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Room Not Added", "Add Room", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Room Number Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void ButtonEditRoom_Click(object sender, EventArgs e)
        {

            string roomname = RoomNameTB.Text;
           

            try
            {
                int room_id = Convert.ToInt32(RoomNumberTB.Text);
                int capacity = Convert.ToInt32(CapacityTB.Text);

                if (room.EditRoom(roomname, room_id, capacity))
                {
                    DataGridView1.DataSource = room.GetRooms();
                    MessageBox.Show("Room Data Updated", "Edit Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Room Data NOT Updated", "Edit Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error - Non number values entered", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ButtonRemoveRoom_Click(object sender, EventArgs e)
        {
            try
            {
                int room_id = Convert.ToInt32(RoomNumberTB.Text);

                if (room.RemoveRoom(room_id))
                {
                    DataGridView1.DataSource = room.GetRooms();
                    MessageBox.Show("Room Data Deleted", "Remove Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Room Data NOT Deleted", "Remove Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Room Number Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            RoomNameTB.Text = "";
            CapacityTB.Text = "";
        }

        // display selected row data from datagridview to textboxes
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RoomNumberTB.Text = DataGridView1.CurrentRow.Cells[0].Value.ToString();
            RoomNameTB.Text = DataGridView1.CurrentRow.Cells[1].Value.ToString();
            CapacityTB.Text = DataGridView1.CurrentRow.Cells[2].Value.ToString();
         
            }
    }
}
