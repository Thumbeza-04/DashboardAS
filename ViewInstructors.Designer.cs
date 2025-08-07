
namespace DashboardAS
{
    partial class ViewInstructors
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
            this.searchinstructorsbox = new System.Windows.Forms.TextBox();
            this.managerDataSet1 = new DashboardAS.managerDataSet();
            this.instructorMJTableAdapter1 = new DashboardAS.managerDataSetTableAdapters.InstructorMJTableAdapter();
            this.instructorMJBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.instructorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.licensePlateIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.licenseNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expertiseLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instructorMJBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 147);
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
            this.instructorIDDataGridViewTextBoxColumn,
            this.licensePlateIDDataGridViewTextBoxColumn,
            this.licenseNumberDataGridViewTextBoxColumn,
            this.expertiseLevelDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.contactNumberDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.instructorMJBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(59, 181);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(993, 274);
            this.dataGridView1.TabIndex = 2;
            // 
            // searchinstructorsbox
            // 
            this.searchinstructorsbox.Location = new System.Drawing.Point(215, 145);
            this.searchinstructorsbox.Name = "searchinstructorsbox";
            this.searchinstructorsbox.Size = new System.Drawing.Size(223, 22);
            this.searchinstructorsbox.TabIndex = 3;
            this.searchinstructorsbox.TextChanged += new System.EventHandler(this.searchinstructorsbox_TextChanged);
            // 
            // managerDataSet1
            // 
            this.managerDataSet1.DataSetName = "managerDataSet";
            this.managerDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // instructorMJTableAdapter1
            // 
            this.instructorMJTableAdapter1.ClearBeforeFill = true;
            // 
            // instructorMJBindingSource
            // 
            this.instructorMJBindingSource.DataMember = "InstructorMJ";
            this.instructorMJBindingSource.DataSource = this.managerDataSet1;
            // 
            // instructorIDDataGridViewTextBoxColumn
            // 
            this.instructorIDDataGridViewTextBoxColumn.DataPropertyName = "InstructorID";
            this.instructorIDDataGridViewTextBoxColumn.HeaderText = "InstructorID";
            this.instructorIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.instructorIDDataGridViewTextBoxColumn.Name = "instructorIDDataGridViewTextBoxColumn";
            this.instructorIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.instructorIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // licensePlateIDDataGridViewTextBoxColumn
            // 
            this.licensePlateIDDataGridViewTextBoxColumn.DataPropertyName = "LicensePlateID";
            this.licensePlateIDDataGridViewTextBoxColumn.HeaderText = "LicensePlateID";
            this.licensePlateIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.licensePlateIDDataGridViewTextBoxColumn.Name = "licensePlateIDDataGridViewTextBoxColumn";
            this.licensePlateIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // licenseNumberDataGridViewTextBoxColumn
            // 
            this.licenseNumberDataGridViewTextBoxColumn.DataPropertyName = "LicenseNumber";
            this.licenseNumberDataGridViewTextBoxColumn.HeaderText = "LicenseNumber";
            this.licenseNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.licenseNumberDataGridViewTextBoxColumn.Name = "licenseNumberDataGridViewTextBoxColumn";
            this.licenseNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // expertiseLevelDataGridViewTextBoxColumn
            // 
            this.expertiseLevelDataGridViewTextBoxColumn.DataPropertyName = "ExpertiseLevel";
            this.expertiseLevelDataGridViewTextBoxColumn.HeaderText = "ExpertiseLevel";
            this.expertiseLevelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.expertiseLevelDataGridViewTextBoxColumn.Name = "expertiseLevelDataGridViewTextBoxColumn";
            this.expertiseLevelDataGridViewTextBoxColumn.Width = 125;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.Width = 125;
            // 
            // contactNumberDataGridViewTextBoxColumn
            // 
            this.contactNumberDataGridViewTextBoxColumn.DataPropertyName = "ContactNumber";
            this.contactNumberDataGridViewTextBoxColumn.HeaderText = "ContactNumber";
            this.contactNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.contactNumberDataGridViewTextBoxColumn.Name = "contactNumberDataGridViewTextBoxColumn";
            this.contactNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // ViewInstructors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 636);
            this.Controls.Add(this.searchinstructorsbox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewInstructors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewInstructors";
            this.Load += new System.EventHandler(this.ViewInstructors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instructorMJBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox searchinstructorsbox;
        private managerDataSet managerDataSet1;
        private managerDataSetTableAdapters.InstructorMJTableAdapter instructorMJTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn instructorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn licensePlateIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn licenseNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expertiseLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource instructorMJBindingSource;
    }
}