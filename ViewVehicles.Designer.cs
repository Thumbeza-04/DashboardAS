
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
            this.searchvehiclesbox = new System.Windows.Forms.TextBox();
            this.vehicleMJTableAdapter1 = new DashboardAS.managerDataSetTableAdapters.VehicleMJTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleMJBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 117);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search by vehicle type";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.licensePlateIDDataGridViewTextBoxColumn,
            this.transmissionTypeDataGridViewTextBoxColumn,
            this.fuelTypeDataGridViewTextBoxColumn,
            this.makeDataGridViewTextBoxColumn,
            this.vehicleTypeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vehicleMJBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(44, 147);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(745, 223);
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
            // searchvehiclesbox
            // 
            this.searchvehiclesbox.Location = new System.Drawing.Point(203, 117);
            this.searchvehiclesbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchvehiclesbox.Name = "searchvehiclesbox";
            this.searchvehiclesbox.Size = new System.Drawing.Size(168, 20);
            this.searchvehiclesbox.TabIndex = 4;
            this.searchvehiclesbox.TextChanged += new System.EventHandler(this.searchvehiclesbox_TextChanged);
            // 
            // vehicleMJTableAdapter1
            // 
            this.vehicleMJTableAdapter1.ClearBeforeFill = true;
            // 
            // ViewVehicles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(832, 517);
            this.Controls.Add(this.searchvehiclesbox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ViewVehicles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewVehicles";
            this.Load += new System.EventHandler(this.ViewVehicles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleMJBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox searchvehiclesbox;
        private managerDataSet managerDataSet1;
        private managerDataSetTableAdapters.VehicleMJTableAdapter vehicleMJTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn licensePlateIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transmissionTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fuelTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn makeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource vehicleMJBindingSource;
    }
}