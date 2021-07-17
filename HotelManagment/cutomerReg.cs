using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagment
{
    public partial class cutomerReg : Form
    {
        public cutomerReg()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            int customerid = Int16.Parse(txtcustomerid.Text);
            string name = txtname.Text;
            string contact = txtcontactno.Text;
            string address = txtaddress.Text;
            string gender = comboboxgender.Text;
            string nationality = txtnationality.Text;
            string dateofbirth = txtdateofbirth.Value.ToString("yyyy-MM-dd");
            int roomid_var = Int32.Parse(txtroomid.Text);
            int roomno_var = Int16.Parse(txtroomno.Text);
            string roomtype_var = txtroomtype.Text;
            string checkin = txtcheckin.Value.ToString("yyyy-MM-dd");
            int roomprice_var = Int32.Parse(textprice.Text);


            try
            {

                //This is my connection string i have assigned the database file address path  
                string connectionString = "server = localhost; database = winformapp2; uid = root; ";

                //This is my insert statement in which i am taking input from the user through windows forms  
                string insertCommand = $"INSERT INTO `customer`( `customerid`,`name`, `contact`, `address`, `gender`, `nationality`, `dateofbirth`,`roomid`, `roomno`, `roomtype`, `checkin`, `price`) VALUES ({customerid},'{name}','{contact}','{address}','{gender}','{nationality}','{dateofbirth}','{roomid_var}','{roomno_var}','{roomtype_var}','{checkin}','{roomprice_var}')";

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

        private void btndelete_Click(object sender, EventArgs e)
        {

            int customerid = Int16.Parse(txtcustomerid.Text);
            string name = txtname.Text;
            string contact= txtcontactno.Text;
            string address = txtaddress.Text;
            string gender = comboboxgender.Text;
            string nationality = txtnationality.Text;
            string dateofbirth = txtdateofbirth.Value.ToString("yyyy-MM-dd");
            int roomid_var = Int32.Parse(txtroomid.Text);
            int roomno_var = Int16.Parse(txtroomno.Text);
            string roomtype_var = txtroomtype.Text;
            string checkin = txtcheckin.Value.ToString("yyyy-MM-dd");
            int roomprice_var = Int32.Parse(textprice.Text);
            try
            {

                //This is my connection string i have assigned the database file address path  
                string connectionString = "server = localhost; database = winformapp2; uid = root; ";

                //This is my delete statement in which i am taking input from the user through windows forms  
                string deleteCommand = $"DELETE FROM `customer` WHERE `customerid`={customerid}";

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



    private void btnupdate_Click(object sender, EventArgs e)
        {
            int customerid = Int16.Parse(txtcustomerid.Text);
            string name = txtname.Text;
            string contact = txtcontactno.Text;
            string address = txtaddress.Text;
            string gender = comboboxgender.Text;
            string nationality = txtnationality.Text;
            string dateofbirth = txtdateofbirth.Value.ToString("yyyy-MM-dd");
            int roomid_var = Int32.Parse(txtroomid.Text);
            int roomno_var = Int16.Parse(txtroomno.Text);
            string roomtype_var = txtroomtype.Text;
           
            String checkin = txtcheckin.Value.ToString("yyyy-MM-dd");
            int roomprice_var = Int32.Parse(textprice.Text);


            try
            {

                //This is my connection string i have assigned the database file address path  
                string connectionString = "server = localhost; database = winformapp2; uid = root; ";

                //This is my update statement in which i am taking input from the user through windows forms  
                string updateCommand = $"UPDATE `customer` SET `customerid`='{customerid}',`name`='{name}',`contact` = '{contact}',`address` = '{address}', `gender`='{gender}',`nationality`='{nationality}' , `dateofbirth` = '{dateofbirth}', `roomid` = '{roomid_var}', `roomno` = '{roomno_var}',`roomtype` = '{roomtype_var}',`checkin` = '{checkin}',`price` = '{roomprice_var}' WHERE `customerid`={customerid}";

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

       

        private void cutomerReg_Load(object sender, EventArgs e)
        {

        }

        private void buttonload_Click(object sender, EventArgs e)
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

                        txtroomno.Text = reader.GetString("roomno");
                        txtroomtype.Text = reader.GetString("roomtype");
                        textprice.Text = reader.GetString("price");

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

        private void txtroomid_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

