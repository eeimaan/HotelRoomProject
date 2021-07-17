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
    public partial class checkout : Form
    {
        public checkout()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {

            int customerid = Int16.Parse(txtid.Text);
            string checkin = txtcheckin.Value.ToString("yyyy-MM-dd");
            string checkout = txtcheckout.Value.ToString("yyyy-MM-dd");
            string Customer_name = textname.Text;
            string ServiceCharges = txtsr.Text;
            string RoomCharges = txtroomcharges.Text;
            string payment = txtpayment.Text;
          
            try
            {

                //This is my connection string i have assigned the database file address path  
                string connectionString = "server = localhost; database = winformapp2; uid = root; ";

                //This is my insert statement in which i am taking input from the user through windows forms  
                string insertCommand = $"INSERT INTO `checkout`( `customerid`,`checkin`, `checkout`,`customername`, `servicecharges`, `roomcharges`, `payment`) VALUES ({customerid},'{txtcheckin}','{txtcheckout}','{textname}','{txtsr}','{txtroomcharges}','{txtpayment}')";

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

        private void btnload_Click(object sender, EventArgs e)
        {
            try
            {
                int customer = Int16.Parse(txtid.Text);

                //This is my connection string i have assigned the database file address path  
                string connectionString = "server = localhost; database = winformapp2; uid = root; ";

                //This is my select statement in which i am taking input from the user through windows forms  
                string updateCommand = $"SELECT `customerid`,`checkin`, `name`, `price` FROM `customer` WHERE `customerid`= {customer}";

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
                        txtid.Text = reader.GetString("customerid");
                        txtcheckin.Text = reader.GetString("checkin");
                        textname.Text = reader.GetString("name");
                        txtroomcharges.Text = reader.GetString("price");
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

        private void txtpayment_TextChanged(object sender, EventArgs e)
        {
            int ServiceCharges = int.Parse(txtsr.Text);
           int RoomCharges = int.Parse(txtroomcharges.Text);
          int Totalcharges = ServiceCharges + RoomCharges ;
            txtpayment.Text = Convert.ToString(Totalcharges);

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            int customerid = Int16.Parse(txtid.Text);
           
            try
            {

                //This is my connection string i have assigned the database file address path  
                string connectionString = "server = localhost; database = winformapp2; uid = root; ";

                //This is my delete statement in which i am taking input from the user through windows forms  
                string deleteCommand = $"DELETE FROM `checkout` WHERE `customerid`={customerid}";

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
            int customerid = Int16.Parse(txtid.Text);
            string checkin = txtcheckin.Value.ToString("yyyy-MM-dd");
            string checkout = txtcheckout.Value.ToString("yyyy-MM-dd");
            string customer_name = textname.Text;
            string ServiceCharges = txtsr.Text;
            string RoomCharges = txtroomcharges.Text;
            string payment = txtpayment.Text;


            try
            {

                //This is my connection string i have assigned the database file address path  
                string connectionString = "server = localhost; database = winformapp2; uid = root; ";

                //This is my update statement in which i am taking input from the user through windows forms  
                string updateCommand = $"UPDATE `checkout` SET `customerid`='{customerid}',`checkin`='{checkin}',`checkout` = '{checkout}',`customername` = '{customer_name}',`servicecharges` = '{ServiceCharges}', `roomcharges`='{RoomCharges}', `payment` = '{payment}' WHERE `customerid`={customerid}";

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
    }
    
}
