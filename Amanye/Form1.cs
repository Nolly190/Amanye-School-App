using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Amanye
{
    public partial class Loading : Form
    {
        String check = "";
        public Loading()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 10000;
            timer1.Tick += new EventHandler(timer_Tick);
            timer1.Start();
        }
        
        void timer_Tick(object sender, EventArgs e)
        {
            if (check == "")
            {
                Login lc = new Login();
                lc.Show();
                this.Hide();
                check = "Done";
            }

        }

      
    }
}
