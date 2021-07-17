
namespace HotelManagment
{
    partial class alldeatails
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewAllDetails = new System.Windows.Forms.DataGridView();
            this.customeridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkoutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servicechargesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomchargesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkoutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.winformapp2DataSet1 = new HotelManagment.winformapp2DataSet1();
            this.label2 = new System.Windows.Forms.Label();
            this.checkoutTableAdapter = new HotelManagment.winformapp2DataSet1TableAdapters.checkoutTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkoutBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winformapp2DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = " Details of Customer";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridViewAllDetails
            // 
            this.dataGridViewAllDetails.AutoGenerateColumns = false;
            this.dataGridViewAllDetails.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewAllDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAllDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customeridDataGridViewTextBoxColumn,
            this.checkinDataGridViewTextBoxColumn,
            this.checkoutDataGridViewTextBoxColumn,
            this.servicechargesDataGridViewTextBoxColumn,
            this.roomchargesDataGridViewTextBoxColumn,
            this.paymentDataGridViewTextBoxColumn});
            this.dataGridViewAllDetails.DataSource = this.checkoutBindingSource;
            this.dataGridViewAllDetails.Location = new System.Drawing.Point(60, 153);
            this.dataGridViewAllDetails.Name = "dataGridViewAllDetails";
            this.dataGridViewAllDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAllDetails.Size = new System.Drawing.Size(642, 353);
            this.dataGridViewAllDetails.TabIndex = 2;
            this.dataGridViewAllDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAllDetails_CellContentClick);
            // 
            // customeridDataGridViewTextBoxColumn
            // 
            this.customeridDataGridViewTextBoxColumn.DataPropertyName = "customerid";
            this.customeridDataGridViewTextBoxColumn.HeaderText = "customerid";
            this.customeridDataGridViewTextBoxColumn.Name = "customeridDataGridViewTextBoxColumn";
            // 
            // checkinDataGridViewTextBoxColumn
            // 
            this.checkinDataGridViewTextBoxColumn.DataPropertyName = "checkin";
            this.checkinDataGridViewTextBoxColumn.HeaderText = "checkin";
            this.checkinDataGridViewTextBoxColumn.Name = "checkinDataGridViewTextBoxColumn";
            // 
            // checkoutDataGridViewTextBoxColumn
            // 
            this.checkoutDataGridViewTextBoxColumn.DataPropertyName = "checkout";
            this.checkoutDataGridViewTextBoxColumn.HeaderText = "checkout";
            this.checkoutDataGridViewTextBoxColumn.Name = "checkoutDataGridViewTextBoxColumn";
            // 
            // servicechargesDataGridViewTextBoxColumn
            // 
            this.servicechargesDataGridViewTextBoxColumn.DataPropertyName = "servicecharges";
            this.servicechargesDataGridViewTextBoxColumn.HeaderText = "servicecharges";
            this.servicechargesDataGridViewTextBoxColumn.Name = "servicechargesDataGridViewTextBoxColumn";
            // 
            // roomchargesDataGridViewTextBoxColumn
            // 
            this.roomchargesDataGridViewTextBoxColumn.DataPropertyName = "roomcharges";
            this.roomchargesDataGridViewTextBoxColumn.HeaderText = "roomcharges";
            this.roomchargesDataGridViewTextBoxColumn.Name = "roomchargesDataGridViewTextBoxColumn";
            // 
            // paymentDataGridViewTextBoxColumn
            // 
            this.paymentDataGridViewTextBoxColumn.DataPropertyName = "payment";
            this.paymentDataGridViewTextBoxColumn.HeaderText = "payment";
            this.paymentDataGridViewTextBoxColumn.Name = "paymentDataGridViewTextBoxColumn";
            // 
            // checkoutBindingSource
            // 
            this.checkoutBindingSource.DataMember = "checkout";
            this.checkoutBindingSource.DataSource = this.winformapp2DataSet1;
            this.checkoutBindingSource.CurrentChanged += new System.EventHandler(this.checkoutBindingSource_CurrentChanged_1);
            // 
            // winformapp2DataSet1
            // 
            this.winformapp2DataSet1.DataSetName = "winformapp2DataSet1";
            this.winformapp2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "All Customer Detail";
            // 
            // checkoutTableAdapter
            // 
            this.checkoutTableAdapter.ClearBeforeFill = true;
            // 
            // alldeatails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 672);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewAllDetails);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "alldeatails";
            this.Text = "alldeatails";
            this.Load += new System.EventHandler(this.alldeatails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkoutBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winformapp2DataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewAllDetails;
        private System.Windows.Forms.Label label2;
        private winformapp2DataSet1 winformapp2DataSet1;
        private System.Windows.Forms.BindingSource checkoutBindingSource;
        private winformapp2DataSet1TableAdapters.checkoutTableAdapter checkoutTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn customeridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkoutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn servicechargesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomchargesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentDataGridViewTextBoxColumn;
    }
}