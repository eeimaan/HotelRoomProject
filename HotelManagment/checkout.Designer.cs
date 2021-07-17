
namespace HotelManagment
{
    partial class checkout
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtsr = new System.Windows.Forms.TextBox();
            this.txtroomcharges = new System.Windows.Forms.TextBox();
            this.txtpayment = new System.Windows.Forms.TextBox();
            this.txtcheckin = new System.Windows.Forms.DateTimePicker();
            this.txtcheckout = new System.Windows.Forms.DateTimePicker();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnload = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.customerid = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textname = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Receipt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Check in date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Check out date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(432, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Service Charges";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(432, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Room charges";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(165, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Total Payment";
            // 
            // txtsr
            // 
            this.txtsr.AccessibleName = "txtsr";
            this.txtsr.Location = new System.Drawing.Point(543, 133);
            this.txtsr.Name = "txtsr";
            this.txtsr.Size = new System.Drawing.Size(200, 20);
            this.txtsr.TabIndex = 6;
            // 
            // txtroomcharges
            // 
            this.txtroomcharges.AccessibleName = "txtroomcharges";
            this.txtroomcharges.Location = new System.Drawing.Point(543, 184);
            this.txtroomcharges.Name = "txtroomcharges";
            this.txtroomcharges.Size = new System.Drawing.Size(200, 20);
            this.txtroomcharges.TabIndex = 7;
            // 
            // txtpayment
            // 
            this.txtpayment.AccessibleName = "txtpayment";
            this.txtpayment.Location = new System.Drawing.Point(271, 270);
            this.txtpayment.Name = "txtpayment";
            this.txtpayment.Size = new System.Drawing.Size(200, 20);
            this.txtpayment.TabIndex = 8;
            this.txtpayment.TextChanged += new System.EventHandler(this.txtpayment_TextChanged);
            // 
            // txtcheckin
            // 
            this.txtcheckin.AccessibleName = "txtcheckin";
            this.txtcheckin.Location = new System.Drawing.Point(168, 136);
            this.txtcheckin.Name = "txtcheckin";
            this.txtcheckin.Size = new System.Drawing.Size(200, 20);
            this.txtcheckin.TabIndex = 9;
            // 
            // txtcheckout
            // 
            this.txtcheckout.AccessibleName = "txtcheckout";
            this.txtcheckout.Location = new System.Drawing.Point(168, 181);
            this.txtcheckout.Name = "txtcheckout";
            this.txtcheckout.Size = new System.Drawing.Size(200, 20);
            this.txtcheckout.TabIndex = 10;
            // 
            // btndelete
            // 
            this.btndelete.AccessibleName = "btndelete";
            this.btndelete.Location = new System.Drawing.Point(199, 488);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 11;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.AccessibleName = "btnupdate";
            this.btnupdate.Location = new System.Drawing.Point(333, 488);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 12;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnload
            // 
            this.btnload.AccessibleName = "btnload";
            this.btnload.Location = new System.Drawing.Point(457, 488);
            this.btnload.Name = "btnload";
            this.btnload.Size = new System.Drawing.Size(208, 23);
            this.btnload.TabIndex = 13;
            this.btnload.Text = "Load Details by enter Customer ID";
            this.btnload.UseVisualStyleBackColor = true;
            this.btnload.Click += new System.EventHandler(this.btnload_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(64, 488);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 14;
            this.btnsave.Text = "Conform";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // customerid
            // 
            this.customerid.AccessibleName = "customerid";
            this.customerid.AutoSize = true;
            this.customerid.Location = new System.Drawing.Point(59, 92);
            this.customerid.Name = "customerid";
            this.customerid.Size = new System.Drawing.Size(65, 13);
            this.customerid.TabIndex = 15;
            this.customerid.Text = "Customer ID";
            // 
            // txtid
            // 
            this.txtid.AccessibleName = "txtid";
            this.txtid.Location = new System.Drawing.Point(168, 92);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(200, 20);
            this.txtid.TabIndex = 16;
            // 
            // lblMessage
            // 
            this.lblMessage.AccessibleName = "lblMessage";
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(61, 414);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(53, 13);
            this.lblMessage.TabIndex = 17;
            this.lblMessage.Text = "Message:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(432, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Customer Name";
            // 
            // textname
            // 
            this.textname.Location = new System.Drawing.Point(543, 89);
            this.textname.Name = "textname";
            this.textname.Size = new System.Drawing.Size(200, 20);
            this.textname.TabIndex = 19;
            // 
            // checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 672);
            this.Controls.Add(this.textname);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.customerid);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnload);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.txtcheckout);
            this.Controls.Add(this.txtcheckin);
            this.Controls.Add(this.txtpayment);
            this.Controls.Add(this.txtroomcharges);
            this.Controls.Add(this.txtsr);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "checkout";
            this.Text = "checkout";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtsr;
        private System.Windows.Forms.TextBox txtroomcharges;
        private System.Windows.Forms.TextBox txtpayment;
        private System.Windows.Forms.DateTimePicker txtcheckin;
        private System.Windows.Forms.DateTimePicker txtcheckout;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnload;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Label customerid;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textname;
    }
}