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
            pictureBox2.Visible = true;
            usernameTxt.Visible = true;
            passwordTxt.Visible = true;
            eNoTxt.Visible = true;
            LOGIN.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            loginBtn.Visible = true;


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


        private void loginBtn_Click_1(object sender, EventArgs e)
        {
            recptlogiNmjTableAdapter1.FillBy(DSstaffLogin.RECPTLOGINmj, int.Parse(eNoTxt.Text), usernameTxt.Text, passwordTxt.Text);

            if (DSstaffLogin.RECPTLOGINmj.Rows.Count > 0)
            {
                Form1 form1 = new Form1();
                PrepareForm(form1);

                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                usernameTxt.Visible = false;
                passwordTxt.Visible = false;
                eNoTxt.Visible = false;
                LOGIN.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                loginBtn.Visible = false;

            }
            else
            {
                managerlogiNmjTableAdapter1.FillBy(DSstaffLogin.MANAGERLOGINmj, int.Parse(eNoTxt.Text), usernameTxt.Text, passwordTxt.Text);

                if (DSstaffLogin.MANAGERLOGINmj.Rows.Count > 0)
                {
                    ManagerDB manager = new ManagerDB();
                    PrepareForm(manager);
                    pictureBox1.Visible = false;
                    pictureBox2.Visible = false;
                    usernameTxt.Visible = false;
                    passwordTxt.Visible = false;
                    eNoTxt.Visible = false;
                    LOGIN.Visible = false;
                    label1.Visible = false;
                    label2.Visible = false;
                    label3.Visible = false;
                    loginBtn.Visible = false;
                }


                else
                {

                    instructorlogiNmjTableAdapter1.FillBy(DSstaffLogin.INSTRUCTORLOGINmj, int.Parse(eNoTxt.Text), usernameTxt.Text, passwordTxt.Text);
                    if (DSstaffLogin.INSTRUCTORLOGINmj.Rows.Count > 0)
                    {
                        int inID = int.Parse(eNoTxt.Text);
                        InstructorDB InDb = new InstructorDB(inID);
                        PrepareForm(InDb);
                        pictureBox1.Visible = false;
                        pictureBox2.Visible = false;
                        usernameTxt.Visible = false;
                        passwordTxt.Visible = false;
                        eNoTxt.Visible = false;
                        LOGIN.Visible = false;
                        label1.Visible = false;
                        label2.Visible = false;
                        label3.Visible = false;
                        loginBtn.Visible = false;
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
