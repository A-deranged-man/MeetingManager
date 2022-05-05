namespace CMP307_TayMark_App
{
    partial class Manage_Rooms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manage_Rooms));
            this.panel1 = new System.Windows.Forms.Panel();
            this.RoomNumberTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ButtonClear = new System.Windows.Forms.Button();
            this.ButtonRemoveRoom = new System.Windows.Forms.Button();
            this.ButtonEditRoom = new System.Windows.Forms.Button();
            this.ButtonAddRoom = new System.Windows.Forms.Button();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.CapacityTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.RoomNameTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.RoomNumberTB);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.ButtonClear);
            this.panel1.Controls.Add(this.ButtonRemoveRoom);
            this.panel1.Controls.Add(this.ButtonEditRoom);
            this.panel1.Controls.Add(this.ButtonAddRoom);
            this.panel1.Controls.Add(this.DataGridView1);
            this.panel1.Controls.Add(this.CapacityTB);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.RoomNameTB);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(964, 493);
            this.panel1.TabIndex = 1;
            // 
            // RoomNumberTB
            // 
            this.RoomNumberTB.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomNumberTB.Location = new System.Drawing.Point(149, 149);
            this.RoomNumberTB.Name = "RoomNumberTB";
            this.RoomNumberTB.Size = new System.Drawing.Size(67, 33);
            this.RoomNumberTB.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Room Number:";
            // 
            // ButtonClear
            // 
            this.ButtonClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonClear.Location = new System.Drawing.Point(36, 425);
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.Size = new System.Drawing.Size(352, 40);
            this.ButtonClear.TabIndex = 15;
            this.ButtonClear.Text = "Clear Fields";
            this.ButtonClear.UseVisualStyleBackColor = true;
            this.ButtonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // ButtonRemoveRoom
            // 
            this.ButtonRemoveRoom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonRemoveRoom.Location = new System.Drawing.Point(278, 382);
            this.ButtonRemoveRoom.Name = "ButtonRemoveRoom";
            this.ButtonRemoveRoom.Size = new System.Drawing.Size(110, 37);
            this.ButtonRemoveRoom.TabIndex = 14;
            this.ButtonRemoveRoom.Text = "Remove";
            this.ButtonRemoveRoom.UseVisualStyleBackColor = true;
            this.ButtonRemoveRoom.Click += new System.EventHandler(this.ButtonRemoveRoom_Click);
            // 
            // ButtonEditRoom
            // 
            this.ButtonEditRoom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonEditRoom.Location = new System.Drawing.Point(192, 382);
            this.ButtonEditRoom.Name = "ButtonEditRoom";
            this.ButtonEditRoom.Size = new System.Drawing.Size(80, 37);
            this.ButtonEditRoom.TabIndex = 13;
            this.ButtonEditRoom.Text = "Edit";
            this.ButtonEditRoom.UseVisualStyleBackColor = true;
            this.ButtonEditRoom.Click += new System.EventHandler(this.ButtonEditRoom_Click);
            // 
            // ButtonAddRoom
            // 
            this.ButtonAddRoom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAddRoom.Location = new System.Drawing.Point(36, 382);
            this.ButtonAddRoom.Name = "ButtonAddRoom";
            this.ButtonAddRoom.Size = new System.Drawing.Size(150, 37);
            this.ButtonAddRoom.TabIndex = 12;
            this.ButtonAddRoom.Text = "Add New Room";
            this.ButtonAddRoom.UseVisualStyleBackColor = true;
            this.ButtonAddRoom.Click += new System.EventHandler(this.ButtonAddRoom_Click);
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToAddRows = false;
            this.DataGridView1.AllowUserToDeleteRows = false;
            this.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Location = new System.Drawing.Point(423, 78);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.ReadOnly = true;
            this.DataGridView1.Size = new System.Drawing.Size(529, 387);
            this.DataGridView1.TabIndex = 11;
            this.DataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            // 
            // CapacityTB
            // 
            this.CapacityTB.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CapacityTB.Location = new System.Drawing.Point(149, 188);
            this.CapacityTB.Name = "CapacityTB";
            this.CapacityTB.Size = new System.Drawing.Size(67, 33);
            this.CapacityTB.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(55, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Capacity:";
            // 
            // RoomNameTB
            // 
            this.RoomNameTB.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomNameTB.Location = new System.Drawing.Point(149, 110);
            this.RoomNameTB.Name = "RoomNameTB";
            this.RoomNameTB.Size = new System.Drawing.Size(253, 33);
            this.RoomNameTB.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Room Name:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(964, 65);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(964, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Rooms";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Manage_Rooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 493);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Manage_Rooms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ManageRoomsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ButtonClear;
        private System.Windows.Forms.Button ButtonRemoveRoom;
        private System.Windows.Forms.Button ButtonEditRoom;
        private System.Windows.Forms.Button ButtonAddRoom;
        private System.Windows.Forms.DataGridView DataGridView1;
        private System.Windows.Forms.TextBox RoomNameTB;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CapacityTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox RoomNumberTB;
        private System.Windows.Forms.Label label3;
    }
}