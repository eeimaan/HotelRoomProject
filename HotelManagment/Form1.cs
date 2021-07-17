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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void textpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string user_name_var = textusername.Text;   // name of your username textbox
            string password_var = textpassword.Text;     // name of your password textbox

            try
            {
                string myConnectionString = "server = localhost; database = winformapp2; uid = root; ";
                MySqlConnection conn = new MySqlConnection(myConnectionString);
                conn.Open();


                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = $"Select * from user where username='{user_name_var}' and password='{password_var}'";
                MySqlDataReader dataReader = cmd.ExecuteReader();
                if (dataReader.HasRows)
                {
                    lbl_status.Text = "Login Successful";
                    lbl_status.Visible = false;
                    Dashboard ds = new Dashboard();
                    this.Hide();
                    ds.Show();
                }
                else
                {
                    lbl_status.Text = "Login Failed";
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                lbl_status.Text = ex.Message;

            }
           
        }

        private void lbl_status_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
