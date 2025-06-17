using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DashboardAS
{
    public partial class InstructorDB : Form
    {
        int _ID;
        public InstructorDB(int ID)
        {
            InitializeComponent();
            _ID = ID;
        }

        private void Loadform(object Form)
        {
            if (this.MainPanel.Controls.Count > 0)
            {
                this.MainPanel.Controls.RemoveAt(0);
            }

            var form = Form as Form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;

            this.MainPanel.Controls.Add(form);
            this.MainPanel.Tag = form;

            form.Show();
        }
            private void InstructorDB_Load(object sender, EventArgs e)
            {
             Loadform(new Dash(_ID));
            }

        private void attBtn_Click(object sender, EventArgs e)
        {
            Loadform(new LessonAttendance(_ID));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Loadform(new StudentSummary(_ID));
        }
    }
}
