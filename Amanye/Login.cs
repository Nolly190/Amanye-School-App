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
    public partial class Login : Form
    {
        public static string Role { get; set; }
        public static string Username { get; set; }
        String check = "";
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

            this.BtnSubmit.BackColor = ColorTranslator.FromHtml("#0099cc");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            using (AmanyeDbEntities dbEntities = new AmanyeDbEntities() )
            {
                var getLogin =
                    dbEntities.UserTables.SingleOrDefault(x => x.Username .Contains(TxtLogin.Text) && x.password .Contains(txtPassword.Text));
                if (getLogin==null)
                {
                    MessageBox.Show(@"Wrong Username or password entered");
                    return;
                }

                Role = getLogin.role;
                Username = getLogin.Username;
                var fn = new Manager();
                fn.Show();
                this.Hide();
            }
        }
    }
}
