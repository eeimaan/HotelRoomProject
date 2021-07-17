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
namespace HotelManagment
{
    public partial class AddRoomForm : Form
    {
        public AddRoomForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int roomId_var = Int16.Parse(txtroomid.Text);
            int roomno_var = Int16.Parse(textroomno.Text);
            string roomtype_var = txtroomtype.Text;
            int roomprice_var = Int32.Parse(txt_price.Text);
           
            try
            {

                //This is my connection string i have assigned the database file address path  
                string connectionString = "server = localhost; database = winformapp2; uid = root; ";

                //This is my insert statement in which i am taking input from the user through windows forms  
                string insertCommand = $"INSERT INTO `rooms`(`room_id`, `roomno`, `roomtype`, `price`) VALUES ({roomId_var},'{roomno_var}','{roomtype_var}','{roomprice_var}')";

                //This is  MySqlConnection here i have created the object and pass my connection string.  
                MySqlConnection conn = new MySqlConnection(connectionString);

                //This is command class which will handle the insert statement.
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = insertCommand;

                conn.Open();

                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    lblMessage.Text = "Record Saved Successfully!";
                }
                else
                {
                    lblMessage.Text = "Record cannot be Saved!";
                }
                conn.Close();

            }
            catch (Exception ex)
            {

                lblMessage.Text = ex.Message;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int roomId_var = Int16.Parse(txtroomid.Text);
            int roomno_var = Int16.Parse(textroomno.Text);
            string roomtype_var = txtroomtype.Text;
            int roomprice_var = Int32.Parse(txt_price.Text);
            try
            {

                //This is my connection string i have assigned the database file address path  
                string connectionString = "server = localhost; database = winformapp2; uid = root; ";

                //This is my delete statement in which i am taking input from the user through windows forms  
                string deleteCommand = $"DELETE FROM `rooms` WHERE `room_id`={roomId_var}";

                //This is  MySqlConnection here i have created the object and pass my connection string.  
                MySqlConnection conn = new MySqlConnection(connectionString);

                //This is command class which will handle the delete statement.
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = deleteCommand;

                conn.Open();

                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    lblMessage.Text = "Record Deleted Successfully!";
                }
                else
                {
                    lblMessage.Text = "Record cannot be Deleted!";
                }
                conn.Close();

            }
            catch (Exception ex)
            {

                lblMessage.Text = ex.Message;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int roomId_var = Int16.Parse(txtroomid.Text);
            int roomno_var = Int16.Parse(textroomno.Text);
            string roomtype_var = txtroomtype.Text;
            int roomprice_var = Int32.Parse(txt_price.Text);
            try
            {

                //This is my connection string i have assigned the database file address path  
                string connectionString = "server = localhost; database = winformapp2; uid = root; ";

                //This is my update statement in which i am taking input from the user through windows forms  
                string updateCommand = $"UPDATE `rooms` SET `room_id`='{roomId_var}',`roomno`='{roomno_var}' , `roomtype` = '{roomtype_var}', `price` = '{roomprice_var}' WHERE `room_id`={roomId_var}";

                //This is  MySqlConnection here i have created the object and pass my connection string.  
                MySqlConnection conn = new MySqlConnection(connectionString);

                //This is command class which will handle the update statement.
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = updateCommand;

                conn.Open();

                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    lblMessage.Text = "Record Updated Successfully!";
                }
                else
                {
                    lblMessage.Text = "Record cannot be Updated!";
                }
                conn.Close();

            }
            catch (Exception ex)
            {

                lblMessage.Text = ex.Message;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                int roomId_var = Int16.Parse(txtroomid.Text);

                //This is my connection string i have assigned the database file address path  
                string connectionString = "server = localhost; database = winformapp2; uid = root; ";

                //This is my select statement in which i am taking input from the user through windows forms  
                string updateCommand = $"SELECT `room_id`, `roomno`, `roomtype`, `price` FROM `rooms` WHERE `room_id`={roomId_var}";

                //This is  MySqlConnection here i have created the object and pass my connection string.  
                MySqlConnection conn = new MySqlConnection(connectionString);

                //This is command class which will handle the select statement.
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = updateCommand;

                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        txtroomtype.Text = reader.GetString("roomtype");
                        txt_price.Text = reader.GetString("roomno");
                        textroomno.Text = reader.GetString("price");
                    }

                    lblMessage.Text = "Record Loaded Succesfully!";
                }
                else
                {
                    lblMessage.Text = "No Record Found!";
                }

                conn.Close();

            }
            catch (Exception ex)
            {

                lblMessage.Text = ex.Message;
            }
        }

        private void AddRoomForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'winformapp2DataSet.rooms' table. You can move, or remove it, as needed.
            this.roomsTableAdapter.Fill(this.winformapp2DataSet.rooms);

        }

        private void roomsBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            this.roomsTableAdapter.Update(this.winformapp2DataSet.rooms);
        }
    }
}
