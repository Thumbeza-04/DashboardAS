
namespace DashboardAS
{
    partial class ViewStaff
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
            this.searchstaffbox = new System.Windows.Forms.TextBox();
            this.managerDataSet1 = new DashboardAS.managerDataSet();
            this.staffMJTableAdapter1 = new DashboardAS.managerDataSetTableAdapters.StaffMJTableAdapter();
            this.staffMJBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.staffIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffCellNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postalCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffMJBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search by surname";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.staffIDDataGridViewTextBoxColumn,
            this.staffNameDataGridViewTextBoxColumn,
            this.staffSurnameDataGridViewTextBoxColumn,
            this.staffEmailDataGridViewTextBoxColumn,
            this.staffCellNumberDataGridViewTextBoxColumn,
            this.iDNoDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.streetNumberDataGridViewTextBoxColumn,
            this.streetNameDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.postalCodeDataGridViewTextBoxColumn,
            this.roleDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.staffMJBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(59, 181);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(993, 274);
            this.dataGridView1.TabIndex = 4;
            // 
            // searchstaffbox
            // 
            this.searchstaffbox.Location = new System.Drawing.Point(226, 142);
            this.searchstaffbox.Name = "searchstaffbox";
            this.searchstaffbox.Size = new System.Drawing.Size(223, 22);
            this.searchstaffbox.TabIndex = 5;
            this.searchstaffbox.TextChanged += new System.EventHandler(this.searchstaffbox_TextChanged);
            // 
            // managerDataSet1
            // 
            this.managerDataSet1.DataSetName = "managerDataSet";
            this.managerDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // staffMJTableAdapter1
            // 
            this.staffMJTableAdapter1.ClearBeforeFill = true;
            // 
            // staffMJBindingSource
            // 
            this.staffMJBindingSource.DataMember = "StaffMJ";
            this.staffMJBindingSource.DataSource = this.managerDataSet1;
            // 
            // staffIDDataGridViewTextBoxColumn
            // 
            this.staffIDDataGridViewTextBoxColumn.DataPropertyName = "StaffID";
            this.staffIDDataGridViewTextBoxColumn.HeaderText = "StaffID";
            this.staffIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.staffIDDataGridViewTextBoxColumn.Name = "staffIDDataGridViewTextBoxColumn";
            this.staffIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.staffIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // staffNameDataGridViewTextBoxColumn
            // 
            this.staffNameDataGridViewTextBoxColumn.DataPropertyName = "StaffName";
            this.staffNameDataGridViewTextBoxColumn.HeaderText = "StaffName";
            this.staffNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.staffNameDataGridViewTextBoxColumn.Name = "staffNameDataGridViewTextBoxColumn";
            this.staffNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // staffSurnameDataGridViewTextBoxColumn
            // 
            this.staffSurnameDataGridViewTextBoxColumn.DataPropertyName = "StaffSurname";
            this.staffSurnameDataGridViewTextBoxColumn.HeaderText = "StaffSurname";
            this.staffSurnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.staffSurnameDataGridViewTextBoxColumn.Name = "staffSurnameDataGridViewTextBoxColumn";
            this.staffSurnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // staffEmailDataGridViewTextBoxColumn
            // 
            this.staffEmailDataGridViewTextBoxColumn.DataPropertyName = "StaffEmail";
            this.staffEmailDataGridViewTextBoxColumn.HeaderText = "StaffEmail";
            this.staffEmailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.staffEmailDataGridViewTextBoxColumn.Name = "staffEmailDataGridViewTextBoxColumn";
            this.staffEmailDataGridViewTextBoxColumn.Width = 125;
            // 
            // staffCellNumberDataGridViewTextBoxColumn
            // 
            this.staffCellNumberDataGridViewTextBoxColumn.DataPropertyName = "StaffCellNumber";
            this.staffCellNumberDataGridViewTextBoxColumn.HeaderText = "StaffCellNumber";
            this.staffCellNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.staffCellNumberDataGridViewTextBoxColumn.Name = "staffCellNumberDataGridViewTextBoxColumn";
            this.staffCellNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDNoDataGridViewTextBoxColumn
            // 
            this.iDNoDataGridViewTextBoxColumn.DataPropertyName = "IDNo";
            this.iDNoDataGridViewTextBoxColumn.HeaderText = "IDNo";
            this.iDNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDNoDataGridViewTextBoxColumn.Name = "iDNoDataGridViewTextBoxColumn";
            this.iDNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.Width = 125;
            // 
            // streetNumberDataGridViewTextBoxColumn
            // 
            this.streetNumberDataGridViewTextBoxColumn.DataPropertyName = "StreetNumber";
            this.streetNumberDataGridViewTextBoxColumn.HeaderText = "StreetNumber";
            this.streetNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.streetNumberDataGridViewTextBoxColumn.Name = "streetNumberDataGridViewTextBoxColumn";
            this.streetNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // streetNameDataGridViewTextBoxColumn
            // 
            this.streetNameDataGridViewTextBoxColumn.DataPropertyName = "StreetName";
            this.streetNameDataGridViewTextBoxColumn.HeaderText = "StreetName";
            this.streetNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.streetNameDataGridViewTextBoxColumn.Name = "streetNameDataGridViewTextBoxColumn";
            this.streetNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            this.cityDataGridViewTextBoxColumn.Width = 125;
            // 
            // postalCodeDataGridViewTextBoxColumn
            // 
            this.postalCodeDataGridViewTextBoxColumn.DataPropertyName = "PostalCode";
            this.postalCodeDataGridViewTextBoxColumn.HeaderText = "PostalCode";
            this.postalCodeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.postalCodeDataGridViewTextBoxColumn.Name = "postalCodeDataGridViewTextBoxColumn";
            this.postalCodeDataGridViewTextBoxColumn.Width = 125;
            // 
            // roleDataGridViewTextBoxColumn
            // 
            this.roleDataGridViewTextBoxColumn.DataPropertyName = "Role";
            this.roleDataGridViewTextBoxColumn.HeaderText = "Role";
            this.roleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
            this.roleDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Width = 125;
            // 
            // ViewStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 636);
            this.Controls.Add(this.searchstaffbox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewStaff";
            this.Load += new System.EventHandler(this.ViewStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffMJBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox searchstaffbox;
        private managerDataSet managerDataSet1;
        private managerDataSetTableAdapters.StaffMJTableAdapter staffMJTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffCellNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn streetNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn streetNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postalCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource staffMJBindingSource;
    }
}