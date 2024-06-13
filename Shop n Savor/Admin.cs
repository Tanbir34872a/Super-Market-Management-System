using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Collections;


namespace Shop_n_Savor
{
	public partial class Admin : Form
	{
		private string uadmin;
		private int flag = 0;
		private string username = "";
		DataTable dt;


        public Admin()
		{
			InitializeComponent();
		}

        public Admin(string uname)
        {
            InitializeComponent();
            uadmin = uname;
        }

        void GetEmployees()
		{
			SqlConnection conn = null;
			try
			{
				conn = new SqlConnection(@"Data Source=DESKTOP-NO4RLJM\SQLEXPRESS;Initial Catalog=ShopNSavor;Integrated Security=True");
				conn.Open();

				string query = "select * from Employees;";
				SqlCommand cmd = new SqlCommand(query, conn);
				DataSet ds = new DataSet();
				SqlDataAdapter adp = new SqlDataAdapter(cmd);
				adp.Fill(ds);
				dt = ds.Tables[0];
				dgvemployees.DataSource = dt;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				conn.Close();
			}
		}

		private void clearinput()
		{
			tbuname.Text = "";
			tbfname.Text = "";
			tblname.Text = "";
			rbmale.Checked = rbfemale.Checked =  false;
			dtpdob.Text = "";
			tbemail.Text = "";
			tbphone.Text = "";
			tbaddress.Text = "";
			rbyes.Checked = rbno.Checked = false;
			tbpass.Text = "";
		}

		private void Admin_Load(object sender, EventArgs e)
		{
			GetEmployees();
		}

		private void bnew_Click(object sender, EventArgs e)
		{
			inputinfo.Enabled = true;
			dgvemployees.Enabled = false;
			bnew.Enabled = false;
			bupdate.Enabled = false;
			bdelete.Enabled = false;
			bsave.Enabled = true;
			bcancel.Enabled = true;
			clearinput();
			flag = 1;
		}

		private void bupdate_Click(object sender, EventArgs e)
		{
            if (tbuname.Text == uadmin)
            {
                MessageBox.Show("You can't edit yourself here you silly 🤭");
                return;
            }
            inputinfo.Enabled = true;
			dgvemployees.Enabled = false;
			bnew.Enabled = false;
			bupdate.Enabled = false;
			bdelete.Enabled = false;
			bsave.Enabled = true;
			bcancel.Enabled = true;
			flag = 2;
			username = tbuname.Text;
		}

		private void bdelete_Click(object sender, EventArgs e)
		{
			if (tbuname.Text == uadmin)
			{
				MessageBox.Show("You can't delete yourself you silly 🤭");
				return;
			}
            DialogResult dialogResult = MessageBox.Show("Are you sure to delete?", "Confirm", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                SqlConnection conn = null;
                try
                {
                    conn = new SqlConnection(@"Data Source=DESKTOP-NO4RLJM\SQLEXPRESS;Initial Catalog=ShopNSavor;Integrated Security=True");
					conn.Open();

                    string query = $"DELETE from Employees where username='{tbuname.Text}';";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
            else
            {
				return; 
            }
			GetEmployees();
        }

		private void dgvemployees_CellEnter(object sender, DataGridViewCellEventArgs e)
		{
			tbuname.Text = dgvemployees.CurrentRow.Cells[0].Value.ToString();
			tbfname.Text = dgvemployees.CurrentRow.Cells[1].Value.ToString();
			tblname.Text = dgvemployees.CurrentRow.Cells[2].Value.ToString();
			//tbuname.Text = dgvemployees.CurrentRow.Cells[3].Value.ToString();
			dtpdob.Text = dgvemployees.CurrentRow.Cells[4].Value.ToString();
			tbemail.Text = dgvemployees.CurrentRow.Cells[5].Value.ToString();
			tbphone.Text = dgvemployees.CurrentRow.Cells[6].Value.ToString();
			tbaddress.Text = dgvemployees.CurrentRow.Cells[7].Value.ToString();
			//tbuname.Text = dgvemployees.CurrentRow.Cells[8].Value.ToString();
			tbpass.Text = dgvemployees.CurrentRow.Cells[9].Value.ToString();

			if (dgvemployees.CurrentRow.Cells[3].Value.ToString() == "Male")
			{
				rbmale.Checked = true;
			}
			else 
			{
				rbfemale.Checked = true;
			}
			if (dgvemployees.CurrentRow.Cells[8].Value.ToString() == "Yes")
			{
				rbyes.Checked = true;
			}
			else
			{
				rbno.Checked = true;
			}
		}

		private void bexit_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void bcancel_Click(object sender, EventArgs e)
		{
			inputinfo.Enabled = false;
			dgvemployees.Enabled = true;
			bnew.Enabled = true;
			bupdate.Enabled = true;
			bdelete.Enabled = true;
			bsave.Enabled = false;
			bcancel.Enabled = false;
		}

		private void bsave_Click(object sender, EventArgs e)
		{
			if (
				tbuname.Text != "" &&
				tbfname.Text != "" &&
				tblname.Text != "" &&
				(rbmale.Checked || rbfemale.Checked) &&
				dtpdob.Text != "" &&
				tbemail.Text != "" &&
				tbphone.Text != "" &&
				tbaddress.Text != "" &&
				(rbyes.Checked || rbno.Checked) &&
				tbpass.Text != ""
				)
			{


				string gender = "Male";
				string admin = "No";

				if (rbfemale.Checked == true) { gender = "Female"; }
				if (rbyes.Checked == true) { admin = "Yes"; }


				string query;

				if (flag == 1)
				{
					query = "INSERT INTO Employees VALUES ('" + tbuname.Text + "','" + tbfname.Text + "','" + tblname.Text + "','" + gender + "','" +
						dtpdob.Text + "','" + tbemail.Text + "','" + tbphone.Text + "','" + tbaddress.Text + "','" + admin + "','" + tbpass.Text + "');";
				}
				else
				{
					query = "UPDATE Employees Set Username='" + tbuname.Text +
						"',FirstName='" + tbfname.Text +
						"',LastName='" + tblname.Text +
						"',Gender='" + gender +
						"',DOB='" + dtpdob.Text +
						"',Email='" + tbemail.Text +
						"',Phone='" + tbphone.Text +
						"',Address='" + tbaddress.Text +
						"',Admin='" + admin +
						"',Passcode='" + tbpass.Text +
                        "' Where Username='" + username + "';";
				}
				SqlConnection conn = null;
				try
				{
					conn = new SqlConnection(@"Data Source=DESKTOP-NO4RLJM\SQLEXPRESS;Initial Catalog=ShopNSavor;Integrated Security=True");
					conn.Open();

					SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();

                    inputinfo.Enabled = false;
					dgvemployees.Enabled = true;
					bnew.Enabled = true;
					bupdate.Enabled = true;
					bdelete.Enabled = true;
					bsave.Enabled = false;
					bcancel.Enabled = false;
                    GetEmployees();
                }
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
				finally
				{
					conn.Close();
				}
            }
			else
			{
				MessageBox.Show("Plase make sure to write all the fields");
			}
        }

        private void tbsearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataView dv = dt.DefaultView;
                dv.RowFilter = string.Format("Username Like '%{0}%' or FirstName Like '%{0}%' or LastName Like '%{0}%' or Gender Like '%{0}%' or Email Like '%{0}%' or Phone Like '%{0}%' or Address Like '%{0}%' or Admin Like '%{0}%' or Passcode Like '%{0}%'", tbsearch.Text);
                dgvemployees.DataSource = dv;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
