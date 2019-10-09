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
    public partial class Logout : Form
    {
        String check = "";
        public Logout()
        {
            InitializeComponent();
        }

        private void Logout_Load(object sender, EventArgs e)
        {

            this.button1.BackColor = ColorTranslator.FromHtml("#0099cc");
            this.button1.ForeColor = ColorTranslator.FromHtml("#fff");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
