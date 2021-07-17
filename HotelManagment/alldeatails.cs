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
    public partial class alldeatails : Form
    {
        public alldeatails()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void alldeatails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'winformapp2DataSet1.checkout' table. You can move, or remove it, as needed.
            this.checkoutTableAdapter.Fill(this.winformapp2DataSet1.checkout);


            // TODO: This line of code loads data into the 'winformapp2DataSet3.checkout' table. You can move, or remove it, as needed.


        }

        private void checkoutBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void checkoutBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            
        }

        private void dataGridViewAllDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void checkoutBindingSource_CurrentChanged_1(object sender, EventArgs e)
        {
            this.checkoutTableAdapter.Update(this.winformapp2DataSet1.checkout);
        }
    }
}
