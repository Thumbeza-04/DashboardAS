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
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private async void Reports_Load(object sender, EventArgs e)
        {
            
            await webView21.EnsureCoreWebView2Async(null);
            string powerbi ="https://app.powerbi.com/view?r=eyJrIjoiNjMwOWNmMDgtOGUyNi00ZGY1LThhZmEtNzhiZGU0YWNkNzQ4IiwidCI6IjIyNjgyN2Q2LWE5ZDAtNDcwZC04YzE1LWIxNDZiMDE5MmQ1MSIsImMiOjh9";
            webView21.Source = new Uri(powerbi);

            
        }
    }
}
