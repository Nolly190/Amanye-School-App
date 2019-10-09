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
    public partial class AddUser : Form
    {
        String check = "";
        public AddUser()
        {
            InitializeComponent();
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
          
            pnlAddUserDropdown.Visible = false;
            this.btnExportData.BackColor = ColorTranslator.FromHtml("#0099cc");
            using (AmanyeDbEntities dbEntities = new AmanyeDbEntities())
            {
               
                var getallUsers = dbEntities.UserTables.ToList();
                int i = 0;
                foreach (UserTable item in getallUsers)
                {
                    dgvSchools.Rows.Add();
                    dgvSchools.Rows[i].Cells[0].Value = item.Username;
                    dgvSchools.Rows[i].Cells[1].Value = item.phone;
                    i++;
                }
            }
        }
        
      
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (pnlAddUserDropdown.Visible==true)
            {
                pnlAddUserDropdown.Visible = false;
            }
            else
            {
                pnlAddUserDropdown.Visible = true;

            }
        }

        private void BtnAddUser_Click(object sender, EventArgs e)
        {
         
        }

        private void BtnEditUser_Click(object sender, EventArgs e)
        {
            var fn = new EditUser();
            fn.Show();
            this.Hide();
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            var fn = new Logout();
            fn.Show();
            this.Hide();
        }

        private void btnPrintData_Click(object sender, EventArgs e)
        {

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnExportData_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(TxtUsername.Text))
            {
                MessageBox.Show(@"Username is empty");
                return;
            }
            if (string.IsNullOrEmpty(TxtPhone.Text))
            {
                MessageBox.Show(@"Phone number is empty");
                return;

            }
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show(@"password is empty");
                return;
            }
            if (string.IsNullOrEmpty(txtRetypePassword.Text))
            {
                MessageBox.Show(@"retype-password is empty");
                return;
            }
            if (string.IsNullOrEmpty(CMBRole.SelectedItem.ToString()))
            {
                MessageBox.Show(@"User role is empty");
                return;
            }
            if (txtRetypePassword.Text != txtPassword.Text)
            {
               MessageBox.Show(@"Password and retype password does not match");
               return;
            }

          using (AmanyeDbEntities dbEntities =new AmanyeDbEntities())
          {
              var checkusername = dbEntities.UserTables.Where(x => x.Username.Contains(TxtUsername.Text));
                if (checkusername.Count()!=0)
                {
                    MessageBox.Show(@"Username already exist");
                    return;
                }

                var insertUser = new UserTable()
                {
                    password = txtPassword.Text,
                    phone = TxtPhone.Text,
                    Username = TxtUsername.Text,
                    role = CMBRole.SelectedItem.ToString(),
                };
                dbEntities.UserTables.Add(insertUser);
                dbEntities.SaveChanges();
                var getallUsers = dbEntities.UserTables.ToList();
                dgvSchools.Rows.Clear();
                int i = 0;
                foreach (UserTable item in getallUsers)
                {
                    dgvSchools.Rows.Add();
                    dgvSchools.Rows[i].Cells[0].Value = item.Username;
                    dgvSchools.Rows[i].Cells[1].Value = item.phone;
                    i++;
                }

                txtPassword.Text = "";
                txtRetypePassword.Text = "";
                TxtPhone.Text = "";
                TxtUsername.Text = "";
                CMBRole.Text = "";
          }
         


        }

        private void dgvSchools_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DashboardBtn_Click(object sender, EventArgs e)
        {
            var fn = new Manager();
            fn.Show();
            this.Hide();
        }
    }
}
