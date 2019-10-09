using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Amanye.Properties;

namespace Amanye
{
    public partial class Manager : Form
    {
        String check = "";
        public Manager()
        {
            InitializeComponent();
        }

        private void Manager_Load(object sender, EventArgs e)
        {
            pnlManagerDropdown.Visible = false;
            if (Login.Role != "Admin")
            {
                BtnAddUser.Enabled = false;
            }
            this.BtnUpdate.BackColor = ColorTranslator.FromHtml("#0099cc");
            this.btnExportData.BackColor = ColorTranslator.FromHtml("#0099cc");
            using (AmanyeDbEntities dbEntities = new AmanyeDbEntities())
            {
                var getAllSchools = dbEntities.SchoolTables.ToList();
                dgvSchools.Rows.Clear();
                int i = 0;
                foreach (SchoolTable item in getAllSchools)
                {
                    dgvSchools.Rows.Add();
                    dgvSchools.Rows[i].Cells[0].Value = item.Proprietor;
                    dgvSchools.Rows[i].Cells[1].Value = item.SchoolName;
                    dgvSchools.Rows[i].Cells[2].Value = item.Phone;
                    dgvSchools.Rows[i].Cells[3].Value = item.Address;
                    dgvSchools.Rows[i].Cells[4].Value = item.Id;
                    i++;
                }
            }
          
        }
        
      
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (pnlManagerDropdown.Visible==true)
            {
                pnlManagerDropdown.Visible = false;
            }
            else
            {
                pnlManagerDropdown.Visible = true;

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

      
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPhone.Text))
            {
                MessageBox.Show(@"School's Phone number is empty");
                return;
            }
            if (string.IsNullOrEmpty(txtSchoolName.Text))
            {
                MessageBox.Show(@"School's Name is empty");
                return;

            }
            if (string.IsNullOrEmpty(TxtAddress.Text))
            {
                MessageBox.Show(@"School's Address is empty");
                return;
            }
            if (string.IsNullOrEmpty(TxtProperietor.Text))
            {
                MessageBox.Show(@"School's proprietor is empty");
                return;
            }

            using (AmanyeDbEntities dbEntities = new AmanyeDbEntities())
            {
                var checkSchool = dbEntities.SchoolTables.Where(x => x.SchoolName.Contains(txtSchoolName.Text));
               
                if (string.IsNullOrEmpty(check))
                {
                    if (checkSchool.Count() != 0)
                    {
                        MessageBox.Show(@"School already exists");
                        return;
                    }
                    var insertSchool = new SchoolTable()
                {
                    Address = TxtAddress.Text,
                    Phone = txtPhone.Text,
                    Proprietor = TxtProperietor.Text,
                    SchoolName = txtSchoolName.Text
                };
                dbEntities.SchoolTables.Add(insertSchool);
                dbEntities.SaveChanges();
               

                }
                else
                {
                    var getASchool = dbEntities.SchoolTables.SingleOrDefault(x=>x.Id.ToString() == txtHiddenForSchoolUpdate.Text);
                    getASchool.Address = TxtAddress.Text;
                    getASchool.Phone = txtPhone.Text;
                    getASchool. Proprietor = TxtProperietor.Text;
                    getASchool. SchoolName = txtSchoolName.Text;
                    dbEntities.SaveChanges();
                }

                txtSchoolName.Text = null;
                txtPhone.Text = null;
                TxtProperietor.Text = null;
                TxtAddress.Text = null;
                check = "";
                var getAllSchools = dbEntities.SchoolTables.ToList();
                dgvSchools.Rows.Clear();
                int i = 0;
                foreach (SchoolTable item in getAllSchools)
                {
                    dgvSchools.Rows.Add();
                    dgvSchools.Rows[i].Cells[0].Value = item.Proprietor;
                    dgvSchools.Rows[i].Cells[1].Value = item.SchoolName;
                    dgvSchools.Rows[i].Cells[2].Value = item.Phone;
                    dgvSchools.Rows[i].Cells[3].Value = item.Address;
                    dgvSchools.Rows[i].Cells[4].Value = item.Id;
                    i++;
                }

            }
        }

        private void btnExportData_Click(object sender, EventArgs e)
        {
            ExportPdf.Export(dgvSchools,"Napps School Directory");

        }


        
        private void txtSearchDirectory_TextChanged(object sender, EventArgs e)
        {
            using (AmanyeDbEntities dbEntities = new AmanyeDbEntities() )
            {
                var getSearchedQuery = (string.IsNullOrEmpty(txtSearchDirectory.Text)) ?
                    dbEntities.SchoolTables.ToList() :
                dbEntities.SchoolTables.Where(x => x.SchoolName.Contains(txtSearchDirectory.Text)).ToList();
                if (getSearchedQuery.Count()!=0)
                {
                    dgvSchools.Rows.Clear();
                    int i = 0;
                    foreach (SchoolTable item in getSearchedQuery)
                    {
                        dgvSchools.Rows.Add();
                        dgvSchools.Rows[i].Cells[0].Value = item.Proprietor;
                        dgvSchools.Rows[i].Cells[1].Value = item.SchoolName;
                        dgvSchools.Rows[i].Cells[2].Value = item.Phone;
                        dgvSchools.Rows[i].Cells[3].Value = item.Address;
                        dgvSchools.Rows[i].Cells[4].Value = item.Id;
                        i++;
                    }
                }

            }
        }

        private void dgvSchools_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            check = "Update";
            TxtAddress.Text = dgvSchools.Rows[e.RowIndex].Cells[3].Value.ToString();
           txtPhone.Text = dgvSchools.Rows[e.RowIndex].Cells[2].Value.ToString();
            TxtProperietor.Text= dgvSchools.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtSchoolName.Text=dgvSchools.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtHiddenForSchoolUpdate.Text=dgvSchools.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void txtSearchDirectory_Enter(object sender, EventArgs e)
        {
            if (txtSearchDirectory.Text == "Search Directory")
            {
                txtSearchDirectory.Text = "";
                txtSearchDirectory.ForeColor= Color.Black;
            }
        }

        private void txtSearchDirectory_Leave(object sender, EventArgs e)
        {
            txtSearchDirectory.ForeColor = Color.Silver;
            txtSearchDirectory.Text = "Search Directory";
        }
    }
}
