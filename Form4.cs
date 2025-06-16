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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = false;
            panel1.Visible = false;
        }
        public void FormSetup(Form myForm)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }

            myForm = this;
            myForm.WindowState = FormWindowState.Maximized;
            myForm.Show();
        }

        private void PrepareForm(Form f)
        {
            foreach (Form c in this.MdiChildren)
            {
                c.Close();
            }
            f.MdiParent = this;
            f.WindowState = FormWindowState.Maximized;
            f.Show();
        }


        private void receptionistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
            panel1.Visible = true;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            mjReceptionistLoginTableAdapter1.FillBy(dsLogin1.MJReceptionistLogin, int.Parse(staffIdTxt.Text), usernameTxt.Text, passwordTxt.Text, roleTxt.Text);


            if (dsLogin1.MJReceptionistLogin.Rows.Count > 0)
            {
                Form1 form1 = new Form1();
                PrepareForm(form1);
                menuStrip1.Visible = false;
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                panel1.Visible = false;

            }
            else
            {
                mjInstructorLoginTableAdapter1.FillBy(dsLogin1.MJInstructorLogin, int.Parse(staffIdTxt.Text), usernameTxt.Text, passwordTxt.Text, roleTxt.Text);

                if (dsLogin1.MJInstructorLogin.Rows.Count > 0)
                {
                    int inId = int.Parse(staffIdTxt.Text);
                    InstructorDB InDB = new InstructorDB(inId);
                    PrepareForm(InDB);
                    menuStrip1.Visible = false;
                    pictureBox1.Visible = false;
                    pictureBox2.Visible = false;
                    panel1.Visible = false;
                }
                else
                {
                    mjManagerLoginTableAdapter1.FillBy(dsLogin1.MJManagerLogin, int.Parse(staffIdTxt.Text), usernameTxt.Text, passwordTxt.Text, roleTxt.Text);
                    if (dsLogin1.MJManagerLogin.Rows.Count > 0)
                    {
                        ManagerDB Manager = new ManagerDB();
                        PrepareForm(Manager);
                        menuStrip1.Visible = false;
                        pictureBox1.Visible = false;
                        pictureBox2.Visible = false;
                        panel1.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Cannot Login");
                    }
                }
            }
        }
    }
}
