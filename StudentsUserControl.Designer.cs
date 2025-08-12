namespace DashboardAS
{
    partial class StudentsUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonAddStudent = new System.Windows.Forms.Button();
            this.buttonEditStudent = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonArchive = new System.Windows.Forms.Button();
            this.checkBoxShowArchived = new System.Windows.Forms.CheckBox();
            this.buttonReactivate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Students";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(576, 263);
            this.dataGridView1.TabIndex = 1;
            // 
            // buttonAddStudent
            // 
            this.buttonAddStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAddStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonAddStudent.FlatAppearance.BorderSize = 0;
            this.buttonAddStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddStudent.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddStudent.ForeColor = System.Drawing.Color.White;
            this.buttonAddStudent.Location = new System.Drawing.Point(22, 378);
            this.buttonAddStudent.Name = "buttonAddStudent";
            this.buttonAddStudent.Size = new System.Drawing.Size(142, 33);
            this.buttonAddStudent.TabIndex = 2;
            this.buttonAddStudent.Text = "Register Student";
            this.buttonAddStudent.UseVisualStyleBackColor = false;
            this.buttonAddStudent.Click += new System.EventHandler(this.buttonAddStudent_Click);
            // 
            // buttonEditStudent
            // 
            this.buttonEditStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonEditStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.buttonEditStudent.FlatAppearance.BorderSize = 0;
            this.buttonEditStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditStudent.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditStudent.ForeColor = System.Drawing.Color.White;
            this.buttonEditStudent.Location = new System.Drawing.Point(192, 378);
            this.buttonEditStudent.Name = "buttonEditStudent";
            this.buttonEditStudent.Size = new System.Drawing.Size(125, 33);
            this.buttonEditStudent.TabIndex = 3;
            this.buttonEditStudent.Text = "Edit Student";
            this.buttonEditStudent.UseVisualStyleBackColor = false;
            this.buttonEditStudent.Click += new System.EventHandler(this.buttonEditStudent_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(105, 54);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(212, 23);
            this.textBoxSearch.TabIndex = 4;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Search by: ";
            // 
            // buttonArchive
            // 
            this.buttonArchive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonArchive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.buttonArchive.FlatAppearance.BorderSize = 0;
            this.buttonArchive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonArchive.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonArchive.ForeColor = System.Drawing.Color.White;
            this.buttonArchive.Location = new System.Drawing.Point(342, 378);
            this.buttonArchive.Name = "buttonArchive";
            this.buttonArchive.Size = new System.Drawing.Size(111, 33);
            this.buttonArchive.TabIndex = 6;
            this.buttonArchive.Text = "Archive";
            this.buttonArchive.UseVisualStyleBackColor = false;
            this.buttonArchive.Click += new System.EventHandler(this.buttonArchive_Click);
            // 
            // checkBoxShowArchived
            // 
            this.checkBoxShowArchived.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxShowArchived.AutoSize = true;
            this.checkBoxShowArchived.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxShowArchived.Location = new System.Drawing.Point(470, 56);
            this.checkBoxShowArchived.Name = "checkBoxShowArchived";
            this.checkBoxShowArchived.Size = new System.Drawing.Size(128, 21);
            this.checkBoxShowArchived.TabIndex = 7;
            this.checkBoxShowArchived.Text = "Show Archived";
            this.checkBoxShowArchived.UseVisualStyleBackColor = true;
            this.checkBoxShowArchived.CheckedChanged += new System.EventHandler(this.checkBoxShowArchived_CheckedChanged);
            // 
            // buttonReactivate
            // 
            this.buttonReactivate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonReactivate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            this.buttonReactivate.FlatAppearance.BorderSize = 0;
            this.buttonReactivate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReactivate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReactivate.ForeColor = System.Drawing.Color.White;
            this.buttonReactivate.Location = new System.Drawing.Point(474, 378);
            this.buttonReactivate.Name = "buttonReactivate";
            this.buttonReactivate.Size = new System.Drawing.Size(124, 33);
            this.buttonReactivate.TabIndex = 8;
            this.buttonReactivate.Text = "Reactivate";
            this.buttonReactivate.UseVisualStyleBackColor = false;
            this.buttonReactivate.Visible = false;
            this.buttonReactivate.Click += new System.EventHandler(this.buttonReactivate_Click);
            // 
            // StudentsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.buttonReactivate);
            this.Controls.Add(this.checkBoxShowArchived);
            this.Controls.Add(this.buttonArchive);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.buttonEditStudent);
            this.Controls.Add(this.buttonAddStudent);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "StudentsUserControl";
            this.Size = new System.Drawing.Size(620, 440);
            this.Load += new System.EventHandler(this.StudentsUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonAddStudent;
        private System.Windows.Forms.Button buttonEditStudent;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonArchive;
        private System.Windows.Forms.CheckBox checkBoxShowArchived;
        private System.Windows.Forms.Button buttonReactivate;
    }
}
