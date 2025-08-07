
namespace DashboardAS
{
    partial class ManagerDB
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.viewbookingsbtn = new System.Windows.Forms.Button();
            this.viewinstructorsbtn = new System.Windows.Forms.Button();
            this.viewvehiclesbtn = new System.Windows.Forms.Button();
            this.viewstaffbtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.viewstaffbtn);
            this.panel1.Controls.Add(this.viewvehiclesbtn);
            this.panel1.Controls.Add(this.viewinstructorsbtn);
            this.panel1.Controls.Add(this.viewbookingsbtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 766);
            this.panel1.TabIndex = 0;
            // 
            // viewbookingsbtn
            // 
            this.viewbookingsbtn.Location = new System.Drawing.Point(12, 241);
            this.viewbookingsbtn.Name = "viewbookingsbtn";
            this.viewbookingsbtn.Size = new System.Drawing.Size(210, 57);
            this.viewbookingsbtn.TabIndex = 0;
            this.viewbookingsbtn.Text = "View Bookings";
            this.viewbookingsbtn.UseVisualStyleBackColor = true;
            this.viewbookingsbtn.Click += new System.EventHandler(this.viewbookingsbtn_Click);
            // 
            // viewinstructorsbtn
            // 
            this.viewinstructorsbtn.Location = new System.Drawing.Point(12, 345);
            this.viewinstructorsbtn.Name = "viewinstructorsbtn";
            this.viewinstructorsbtn.Size = new System.Drawing.Size(210, 57);
            this.viewinstructorsbtn.TabIndex = 1;
            this.viewinstructorsbtn.Text = "View Instructors";
            this.viewinstructorsbtn.UseVisualStyleBackColor = true;
            this.viewinstructorsbtn.Click += new System.EventHandler(this.viewinstructorsbtn_Click);
            // 
            // viewvehiclesbtn
            // 
            this.viewvehiclesbtn.Location = new System.Drawing.Point(12, 450);
            this.viewvehiclesbtn.Name = "viewvehiclesbtn";
            this.viewvehiclesbtn.Size = new System.Drawing.Size(210, 57);
            this.viewvehiclesbtn.TabIndex = 2;
            this.viewvehiclesbtn.Text = "View Vehicles";
            this.viewvehiclesbtn.UseVisualStyleBackColor = true;
            this.viewvehiclesbtn.Click += new System.EventHandler(this.viewvehiclesbtn_Click);
            // 
            // viewstaffbtn
            // 
            this.viewstaffbtn.Location = new System.Drawing.Point(12, 555);
            this.viewstaffbtn.Name = "viewstaffbtn";
            this.viewstaffbtn.Size = new System.Drawing.Size(210, 57);
            this.viewstaffbtn.TabIndex = 3;
            this.viewstaffbtn.Text = "View Staff";
            this.viewstaffbtn.UseVisualStyleBackColor = true;
            this.viewstaffbtn.Click += new System.EventHandler(this.viewstaffbtn_Click);
            // 
            // ManagerDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1343, 766);
            this.Controls.Add(this.panel1);
            this.Name = "ManagerDB";
            this.Text = "ManagerDB";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button viewstaffbtn;
        private System.Windows.Forms.Button viewvehiclesbtn;
        private System.Windows.Forms.Button viewinstructorsbtn;
        private System.Windows.Forms.Button viewbookingsbtn;
    }
}