
namespace HotelManagment
{
    partial class cutomerReg
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
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtcustomerid = new System.Windows.Forms.TextBox();
            this.txtnationality = new System.Windows.Forms.TextBox();
            this.txtcontactno = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.textprice = new System.Windows.Forms.TextBox();
            this.txtroomno = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtroomtype = new System.Windows.Forms.ComboBox();
            this.comboboxgender = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtcheckin = new System.Windows.Forms.DateTimePicker();
            this.txtdateofbirth = new System.Windows.Forms.DateTimePicker();
            this.btnsave = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.mySqlDataAdapter1 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.roomid = new System.Windows.Forms.Label();
            this.txtroomid = new System.Windows.Forms.TextBox();
            this.buttonload = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(436, 186);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(200, 20);
            this.txtaddress.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer Registration";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 357);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Date of birth";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Nationality";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Contact no";
            // 
            // txtcustomerid
            // 
            this.txtcustomerid.AccessibleName = "txtcustomerid";
            this.txtcustomerid.Location = new System.Drawing.Point(436, 115);
            this.txtcustomerid.Name = "txtcustomerid";
            this.txtcustomerid.Size = new System.Drawing.Size(200, 20);
            this.txtcustomerid.TabIndex = 7;
            // 
            // txtnationality
            // 
            this.txtnationality.Location = new System.Drawing.Point(26, 244);
            this.txtnationality.Name = "txtnationality";
            this.txtnationality.Size = new System.Drawing.Size(200, 20);
            this.txtnationality.TabIndex = 8;
            // 
            // txtcontactno
            // 
            this.txtcontactno.AccessibleName = "txtcontactno";
            this.txtcontactno.Location = new System.Drawing.Point(26, 186);
            this.txtcontactno.Name = "txtcontactno";
            this.txtcontactno.Size = new System.Drawing.Size(200, 20);
            this.txtcontactno.TabIndex = 9;
            // 
            // txtname
            // 
            this.txtname.AccessibleName = "txtname";
            this.txtname.Location = new System.Drawing.Point(26, 115);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(200, 20);
            this.txtname.TabIndex = 10;
            // 
            // textprice
            // 
            this.textprice.AccessibleName = "textprice";
            this.textprice.Location = new System.Drawing.Point(852, 318);
            this.textprice.Name = "textprice";
            this.textprice.Size = new System.Drawing.Size(200, 20);
            this.textprice.TabIndex = 11;
            // 
            // txtroomno
            // 
            this.txtroomno.AccessibleName = "txtroomno";
            this.txtroomno.Location = new System.Drawing.Point(852, 179);
            this.txtroomno.Name = "txtroomno";
            this.txtroomno.Size = new System.Drawing.Size(200, 20);
            this.txtroomno.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(433, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Address";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(849, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Room no";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(433, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Customer Id";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(849, 287);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Price";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(849, 224);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Room Type";
            // 
            // txtroomtype
            // 
            this.txtroomtype.AccessibleName = "txtroomtype";
            this.txtroomtype.FormattingEnabled = true;
            this.txtroomtype.Items.AddRange(new object[] {
            "Single Bedded",
            "Double Bedded",
            "Triple Bedded"});
            this.txtroomtype.Location = new System.Drawing.Point(852, 248);
            this.txtroomtype.Name = "txtroomtype";
            this.txtroomtype.Size = new System.Drawing.Size(200, 21);
            this.txtroomtype.TabIndex = 18;
            // 
            // comboboxgender
            // 
            this.comboboxgender.AccessibleName = "comboboxgender";
            this.comboboxgender.FormattingEnabled = true;
            this.comboboxgender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboboxgender.Location = new System.Drawing.Point(26, 315);
            this.comboboxgender.Name = "comboboxgender";
            this.comboboxgender.Size = new System.Drawing.Size(200, 21);
            this.comboboxgender.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(433, 247);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "Check In";
            // 
            // txtcheckin
            // 
            this.txtcheckin.AccessibleName = "txtcheckin";
            this.txtcheckin.Location = new System.Drawing.Point(436, 271);
            this.txtcheckin.Name = "txtcheckin";
            this.txtcheckin.Size = new System.Drawing.Size(200, 20);
            this.txtcheckin.TabIndex = 21;
            // 
            // txtdateofbirth
            // 
            this.txtdateofbirth.AccessibleName = "txtdateofbirth";
            this.txtdateofbirth.Location = new System.Drawing.Point(26, 389);
            this.txtdateofbirth.Name = "txtdateofbirth";
            this.txtdateofbirth.Size = new System.Drawing.Size(200, 20);
            this.txtdateofbirth.TabIndex = 22;
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(605, 410);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(100, 23);
            this.btnsave.TabIndex = 23;
            this.btnsave.Text = "Register";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(731, 410);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(98, 23);
            this.btndelete.TabIndex = 24;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(851, 410);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(100, 23);
            this.btnupdate.TabIndex = 25;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AccessibleName = "lblMessage";
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(35, 473);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(53, 13);
            this.lblMessage.TabIndex = 27;
            this.lblMessage.Text = "Message:";
            // 
            // mySqlDataAdapter1
            // 
            this.mySqlDataAdapter1.DeleteCommand = null;
            this.mySqlDataAdapter1.InsertCommand = null;
            this.mySqlDataAdapter1.SelectCommand = null;
            this.mySqlDataAdapter1.UpdateCommand = null;
            // 
            // roomid
            // 
            this.roomid.AccessibleName = "roomid";
            this.roomid.AutoSize = true;
            this.roomid.Location = new System.Drawing.Point(848, 85);
            this.roomid.Name = "roomid";
            this.roomid.Size = new System.Drawing.Size(47, 13);
            this.roomid.TabIndex = 29;
            this.roomid.Text = "Room Id";
            // 
            // txtroomid
            // 
            this.txtroomid.AccessibleName = "txtroomid";
            this.txtroomid.Location = new System.Drawing.Point(851, 115);
            this.txtroomid.Name = "txtroomid";
            this.txtroomid.Size = new System.Drawing.Size(200, 20);
            this.txtroomid.TabIndex = 28;
            this.txtroomid.TextChanged += new System.EventHandler(this.txtroomid_TextChanged);
            // 
            // buttonload
            // 
            this.buttonload.AccessibleName = "buttonload";
            this.buttonload.Location = new System.Drawing.Point(975, 410);
            this.buttonload.Name = "buttonload";
            this.buttonload.Size = new System.Drawing.Size(167, 23);
            this.buttonload.TabIndex = 31;
            this.buttonload.Text = "Load room by enter room id";
            this.buttonload.UseVisualStyleBackColor = true;
            this.buttonload.Click += new System.EventHandler(this.buttonload_Click);
            // 
            // cutomerReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 672);
            this.Controls.Add(this.buttonload);
            this.Controls.Add(this.roomid);
            this.Controls.Add(this.txtroomid);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.txtdateofbirth);
            this.Controls.Add(this.txtcheckin);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.comboboxgender);
            this.Controls.Add(this.txtroomtype);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtroomno);
            this.Controls.Add(this.textprice);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtcontactno);
            this.Controls.Add(this.txtnationality);
            this.Controls.Add(this.txtcustomerid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtaddress);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "cutomerReg";
            this.Text = "cutomerReg";
            this.Load += new System.EventHandler(this.cutomerReg_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtcustomerid;
        private System.Windows.Forms.TextBox txtnationality;
        private System.Windows.Forms.TextBox txtcontactno;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox textprice;
        private System.Windows.Forms.TextBox txtroomno;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox txtroomtype;
        private System.Windows.Forms.ComboBox comboboxgender;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker txtcheckin;
        private System.Windows.Forms.DateTimePicker txtdateofbirth;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Label lblMessage;
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter1;
        private System.Windows.Forms.Label roomid;
        private System.Windows.Forms.TextBox txtroomid;
        private System.Windows.Forms.Button buttonload;
    }
}