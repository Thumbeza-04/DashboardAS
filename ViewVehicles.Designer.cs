
namespace DashboardAS
{
    partial class ViewVehicles
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.licensePlateIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transmissionTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fuelTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleMJBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.managerDataSet1 = new DashboardAS.managerDataSet();
            this.vehicleMJTableAdapter1 = new DashboardAS.managerDataSetTableAdapters.VehicleMJTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.licensePlateTxtB = new System.Windows.Forms.TextBox();
            this.makeTxtB = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.INSERTbtn = new System.Windows.Forms.Button();
            this.UPDATEbtn = new System.Windows.Forms.Button();
            this.ARCHIVEbtn = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.licensePlateIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transmissionTypeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fuelTypeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleTypeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleMJBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vehicles List";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.licensePlateIDDataGridViewTextBoxColumn,
            this.transmissionTypeDataGridViewTextBoxColumn,
            this.fuelTypeDataGridViewTextBoxColumn,
            this.makeDataGridViewTextBoxColumn,
            this.vehicleTypeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vehicleMJBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(44, 37);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(680, 131);
            this.dataGridView1.TabIndex = 3;
            // 
            // licensePlateIDDataGridViewTextBoxColumn
            // 
            this.licensePlateIDDataGridViewTextBoxColumn.DataPropertyName = "LicensePlateID";
            this.licensePlateIDDataGridViewTextBoxColumn.HeaderText = "LicensePlateID";
            this.licensePlateIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.licensePlateIDDataGridViewTextBoxColumn.Name = "licensePlateIDDataGridViewTextBoxColumn";
            this.licensePlateIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // transmissionTypeDataGridViewTextBoxColumn
            // 
            this.transmissionTypeDataGridViewTextBoxColumn.DataPropertyName = "TransmissionType";
            this.transmissionTypeDataGridViewTextBoxColumn.HeaderText = "TransmissionType";
            this.transmissionTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.transmissionTypeDataGridViewTextBoxColumn.Name = "transmissionTypeDataGridViewTextBoxColumn";
            this.transmissionTypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // fuelTypeDataGridViewTextBoxColumn
            // 
            this.fuelTypeDataGridViewTextBoxColumn.DataPropertyName = "FuelType";
            this.fuelTypeDataGridViewTextBoxColumn.HeaderText = "FuelType";
            this.fuelTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fuelTypeDataGridViewTextBoxColumn.Name = "fuelTypeDataGridViewTextBoxColumn";
            this.fuelTypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // makeDataGridViewTextBoxColumn
            // 
            this.makeDataGridViewTextBoxColumn.DataPropertyName = "Make";
            this.makeDataGridViewTextBoxColumn.HeaderText = "Make";
            this.makeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.makeDataGridViewTextBoxColumn.Name = "makeDataGridViewTextBoxColumn";
            this.makeDataGridViewTextBoxColumn.Width = 125;
            // 
            // vehicleTypeDataGridViewTextBoxColumn
            // 
            this.vehicleTypeDataGridViewTextBoxColumn.DataPropertyName = "VehicleType";
            this.vehicleTypeDataGridViewTextBoxColumn.HeaderText = "VehicleType";
            this.vehicleTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vehicleTypeDataGridViewTextBoxColumn.Name = "vehicleTypeDataGridViewTextBoxColumn";
            this.vehicleTypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // vehicleMJBindingSource
            // 
            this.vehicleMJBindingSource.DataMember = "VehicleMJ";
            this.vehicleMJBindingSource.DataSource = this.managerDataSet1;
            // 
            // managerDataSet1
            // 
            this.managerDataSet1.DataSetName = "managerDataSet";
            this.managerDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vehicleMJTableAdapter1
            // 
            this.vehicleMJTableAdapter1.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 185);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "License Plate ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(301, 182);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Transmission Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(571, 185);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fuel Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 225);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Make";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(319, 225);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Vehicle Type";
            // 
            // licensePlateTxtB
            // 
            this.licensePlateTxtB.Location = new System.Drawing.Point(146, 181);
            this.licensePlateTxtB.Name = "licensePlateTxtB";
            this.licensePlateTxtB.Size = new System.Drawing.Size(137, 20);
            this.licensePlateTxtB.TabIndex = 9;
            // 
            // makeTxtB
            // 
            this.makeTxtB.Location = new System.Drawing.Point(91, 224);
            this.makeTxtB.Name = "makeTxtB";
            this.makeTxtB.Size = new System.Drawing.Size(148, 20);
            this.makeTxtB.TabIndex = 10;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Manual",
            "Automatic"});
            this.comboBox1.Location = new System.Drawing.Point(431, 177);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(129, 21);
            this.comboBox1.TabIndex = 11;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Petrol ",
            "Diesel"});
            this.comboBox2.Location = new System.Drawing.Point(645, 177);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(129, 21);
            this.comboBox2.TabIndex = 12;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Hatchback",
            "Sedan"});
            this.comboBox3.Location = new System.Drawing.Point(416, 220);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(129, 21);
            this.comboBox3.TabIndex = 13;
            // 
            // INSERTbtn
            // 
            this.INSERTbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.INSERTbtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.INSERTbtn.Location = new System.Drawing.Point(44, 275);
            this.INSERTbtn.Name = "INSERTbtn";
            this.INSERTbtn.Size = new System.Drawing.Size(106, 32);
            this.INSERTbtn.TabIndex = 14;
            this.INSERTbtn.Text = "INSERT";
            this.INSERTbtn.UseVisualStyleBackColor = false;
            this.INSERTbtn.Click += new System.EventHandler(this.INSERTbtn_Click);
            // 
            // UPDATEbtn
            // 
            this.UPDATEbtn.BackColor = System.Drawing.Color.Yellow;
            this.UPDATEbtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UPDATEbtn.Location = new System.Drawing.Point(305, 275);
            this.UPDATEbtn.Name = "UPDATEbtn";
            this.UPDATEbtn.Size = new System.Drawing.Size(106, 32);
            this.UPDATEbtn.TabIndex = 15;
            this.UPDATEbtn.Text = "UPDATE";
            this.UPDATEbtn.UseVisualStyleBackColor = false;
            this.UPDATEbtn.Click += new System.EventHandler(this.UPDATEbtn_Click);
            // 
            // ARCHIVEbtn
            // 
            this.ARCHIVEbtn.BackColor = System.Drawing.Color.Red;
            this.ARCHIVEbtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ARCHIVEbtn.Location = new System.Drawing.Point(534, 275);
            this.ARCHIVEbtn.Name = "ARCHIVEbtn";
            this.ARCHIVEbtn.Size = new System.Drawing.Size(106, 32);
            this.ARCHIVEbtn.TabIndex = 16;
            this.ARCHIVEbtn.Text = "ARCHIVE";
            this.ARCHIVEbtn.UseVisualStyleBackColor = false;
            this.ARCHIVEbtn.Click += new System.EventHandler(this.ARCHIVEbtn_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.licensePlateIDDataGridViewTextBoxColumn1,
            this.transmissionTypeDataGridViewTextBoxColumn1,
            this.fuelTypeDataGridViewTextBoxColumn1,
            this.makeDataGridViewTextBoxColumn1,
            this.vehicleTypeDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.vehicleMJBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(34, 355);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(690, 150);
            this.dataGridView2.TabIndex = 17;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(44, 332);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(118, 20);
            this.checkBox1.TabIndex = 18;
            this.checkBox1.Text = "View Archives";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // licensePlateIDDataGridViewTextBoxColumn1
            // 
            this.licensePlateIDDataGridViewTextBoxColumn1.DataPropertyName = "LicensePlateID";
            this.licensePlateIDDataGridViewTextBoxColumn1.HeaderText = "LicensePlateID";
            this.licensePlateIDDataGridViewTextBoxColumn1.Name = "licensePlateIDDataGridViewTextBoxColumn1";
            // 
            // transmissionTypeDataGridViewTextBoxColumn1
            // 
            this.transmissionTypeDataGridViewTextBoxColumn1.DataPropertyName = "TransmissionType";
            this.transmissionTypeDataGridViewTextBoxColumn1.HeaderText = "TransmissionType";
            this.transmissionTypeDataGridViewTextBoxColumn1.Name = "transmissionTypeDataGridViewTextBoxColumn1";
            // 
            // fuelTypeDataGridViewTextBoxColumn1
            // 
            this.fuelTypeDataGridViewTextBoxColumn1.DataPropertyName = "FuelType";
            this.fuelTypeDataGridViewTextBoxColumn1.HeaderText = "FuelType";
            this.fuelTypeDataGridViewTextBoxColumn1.Name = "fuelTypeDataGridViewTextBoxColumn1";
            // 
            // makeDataGridViewTextBoxColumn1
            // 
            this.makeDataGridViewTextBoxColumn1.DataPropertyName = "Make";
            this.makeDataGridViewTextBoxColumn1.HeaderText = "Make";
            this.makeDataGridViewTextBoxColumn1.Name = "makeDataGridViewTextBoxColumn1";
            // 
            // vehicleTypeDataGridViewTextBoxColumn1
            // 
            this.vehicleTypeDataGridViewTextBoxColumn1.DataPropertyName = "VehicleType";
            this.vehicleTypeDataGridViewTextBoxColumn1.HeaderText = "VehicleType";
            this.vehicleTypeDataGridViewTextBoxColumn1.Name = "vehicleTypeDataGridViewTextBoxColumn1";
            // 
            // ViewVehicles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(832, 517);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.ARCHIVEbtn);
            this.Controls.Add(this.UPDATEbtn);
            this.Controls.Add(this.INSERTbtn);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.makeTxtB);
            this.Controls.Add(this.licensePlateTxtB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ViewVehicles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewVehicles";
            this.Load += new System.EventHandler(this.ViewVehicles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleMJBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private managerDataSet managerDataSet1;
        private managerDataSetTableAdapters.VehicleMJTableAdapter vehicleMJTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn licensePlateIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transmissionTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fuelTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn makeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource vehicleMJBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox licensePlateTxtB;
        private System.Windows.Forms.TextBox makeTxtB;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button INSERTbtn;
        private System.Windows.Forms.Button UPDATEbtn;
        private System.Windows.Forms.Button ARCHIVEbtn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn licensePlateIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn transmissionTypeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fuelTypeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn makeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleTypeDataGridViewTextBoxColumn1;
    }
}