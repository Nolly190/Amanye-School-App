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
    public partial class EditUser : Form
    {
        String check = "";
        public EditUser()
        {
            InitializeComponent();
        }

        private void EditUser_Load(object sender, EventArgs e)
        {
            if (Login.Role!="Admin")
            {
                
                    BtnAddUser.Enabled = false;
                    dgvSchools.Visible = false;
            }

            using (AmanyeDbEntities dbEntities = new AmanyeDbEntities())
            {
                var getAllUsers = dbEntities.UserTables.ToList();
                dgvSchools.Rows.Clear();
                int i = 0;
                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                dgvSchools.Columns.Add(btn);
                btn.HeaderText = "Action";
                btn.Text = "Delete User";
                btn.Name = "btn";
                btn.UseColumnTextForButtonValue = true;
                foreach (UserTable item in getAllUsers)
                {
                    if (Login.Username == item.Username )
                    {
                        TxtPhone.Text = item.phone;
                        TxtUsername.Text = item.Username;
                        txtHidden.Text = item.Id.ToString();
                    }
                    dgvSchools.Rows.Add();
                    dgvSchools.Rows[i].Cells[0].Value = item.Username;
                    dgvSchools.Rows[i].Cells[1].Value = item.phone;
                    dgvSchools.Rows[i].Cells[2].Value = new Button();
                    i++;
                }
            }
            pnlAddUserDropdown.Visible = false;
            
            this.btnExportData.BackColor = ColorTranslator.FromHtml("#0099cc");
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
            var fn = new AddUser();
            fn.Show();
            this.Hide();
        }

        private void BtnEditUser_Click(object sender, EventArgs e)
        {
           
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
            if (string.IsNullOrEmpty(txtOldPassword.Text))
            {
                MessageBox.Show(@"Old password is empty");
                return;
            }
            if (string.IsNullOrEmpty(txtNewPassword.Text))
            {
                MessageBox.Show(@"New password is empty");
                return;
            }
          

            using (AmanyeDbEntities dbEntities =new AmanyeDbEntities())
            {
                var checkusername = dbEntities.UserTables.SingleOrDefault(x => x.Username.Contains(TxtUsername.Text) && x.password.Contains(txtOldPassword.Text));
                if (checkusername==null)
                {
                    MessageBox.Show(@"Old Password Is Incorrect");
                    return;
                }

                checkusername.password = txtOldPassword.Text;
                checkusername.phone = TxtPhone.Text;
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
            }
         


        }

        private void dgvSchools_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSchools.Columns[e.ColumnIndex].Index == 2)
            {
                DialogResult dr = MessageBox.Show(@"Are sou sure you want to delete user?", "Warning", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    using (AmanyeDbEntities dbEntities = new AmanyeDbEntities())
                    {
                        var user = dgvSchools.Rows[e.RowIndex].Cells[0].Value.ToString();
                        var checkAll = dbEntities.UserTables;
                        var checkusername = dbEntities.UserTables.SingleOrDefault(x =>
                            x.Username.Contains(user));
                        if (checkusername == null)
                        {
                            MessageBox.Show(@"Could not fetch user");
                            return;
                        }

                        checkAll.Remove(checkusername);
                        dbEntities.SaveChanges();
                        MessageBox.Show(@"User Removed");
                    }
                    return;
                }
              

             
            }
            TxtUsername.Text = dgvSchools.Rows[e.RowIndex].Cells[0].Value.ToString();
            TxtPhone.Text = dgvSchools.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void DashboardBtn_Click(object sender, EventArgs e)
        {
            var fn = new Manager();
            fn.Show();
            this.Hide();
        }
    }
}
