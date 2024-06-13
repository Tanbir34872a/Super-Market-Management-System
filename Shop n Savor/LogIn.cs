using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;
using System.Runtime.CompilerServices;

namespace Shop_n_Savor
{
	public partial class LogIn : Form
	{
		string username;
		string fname;
		string lname;
		string email;
		string phone;
		string pass;
		string dob;
		string address;
		string gender;

		public LogIn()
		{
			InitializeComponent();
		}
		public LogIn(string u)
		{
			InitializeComponent();
			initiate_labels_textboxes(u);
		}
		public LogIn(string u, int temp) 
		{
			InitializeComponent();
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(@"Data Source=DESKTOP-NO4RLJM\SQLEXPRESS;Initial Catalog=ShopNSavor;Integrated Security=True");
                conn.Open();

                string query = $"update Employees set Passcode='{temp}' where Username='{u}';";
                SqlCommand cmd = new SqlCommand(query, conn);
				cmd.ExecuteNonQuery();

                query = "select * from Employees where Username='" + u + "';";
                cmd = new SqlCommand(query, conn);
                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];
                username = dt.Rows[0]["Username"].ToString();
                fname = dt.Rows[0]["FirstName"].ToString();
                lname = dt.Rows[0]["LastName"].ToString();
                email = dt.Rows[0]["Email"].ToString();
                phone = dt.Rows[0]["Phone"].ToString();
                pass = dt.Rows[0]["Passcode"].ToString();
                dob = dt.Rows[0]["DOB"].ToString();
                address = dt.Rows[0]["Address"].ToString();
                gender = dt.Rows[0]["Gender"].ToString();
				inputinfo.Enabled = false;
				PassPanel.Visible = true;
				button1.Visible = false;
                label2.Text = "Welcome, " + fname + " " + lname;
                textboxes();
				tbpass.Text = pass;
				button9.Enabled = false;
				button4.Enabled = false;
				button2.Enabled = false;
				Cancel.Enabled = false;
				button8.Enabled = false;
				Save.Enabled = true;
				Save.Visible = true;

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


		public void initiate_labels_textboxes(string u) 
		{
			SqlConnection conn = null;
			try
			{
				conn = new SqlConnection(@"Data Source=DESKTOP-NO4RLJM\SQLEXPRESS;Initial Catalog=ShopNSavor;Integrated Security=True");
				conn.Open();

				string query = "select * from Employees where Username='" + u + "';";
				SqlCommand cmd = new SqlCommand(query, conn);
				DataSet ds = new DataSet();
				SqlDataAdapter adp = new SqlDataAdapter(cmd);
				adp.Fill(ds);
				DataTable dt = ds.Tables[0];
				username = dt.Rows[0]["Username"].ToString();
				fname = dt.Rows[0]["FirstName"].ToString();
				lname = dt.Rows[0]["LastName"].ToString();
				email = dt.Rows[0]["Email"].ToString();
				phone = dt.Rows[0]["Phone"].ToString();
				pass = dt.Rows[0]["Passcode"].ToString();
				dob = dt.Rows[0]["DOB"].ToString();
				address = dt.Rows[0]["Address"].ToString();
				gender = dt.Rows[0]["Gender"].ToString();
                button1.Visible = (dt.Rows[0]["Admin"].ToString() == "Yes");
                label2.Text = "Welcome, " + fname + " " + lname;
				textboxes();
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

		private void textboxes()
		{
            tbuname.Text = username;
            tbfname.Text = fname;
            tblname.Text = lname;
            tbemail.Text = email;
            tbphone.Text = phone;
            dtpdob.Text = dob;
			tbaddress.Text = address;
			if (gender == "Male") { rbmale.Checked = true; }
			else { rbfemale.Checked = true;}
			tbpass.Text = "XXXXXX";
        }

		private void button2_Click(object sender, EventArgs e)
		{
			tbpass.Text = "";
			PassPanel.Visible = true;
			inputinfo.Enabled = true;
			Cancel.Visible = true;
			Save.Visible = true;
			button2.Visible = false;
			button9.Enabled = false;
			button4.Enabled = false;
			button1.Enabled = false;
		}

		private void Cancel_Click(object sender, EventArgs e)
		{
            PassPanel.Visible = false;
            inputinfo.Enabled = false;
			Cancel.Visible = false;
            Save.Visible = false;
			button2.Visible = true;
            button9.Enabled = true;
            button4.Enabled = true;
            button1.Enabled = true;
            textboxes();
        }

		private void Save_Click(object sender, EventArgs e)
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
                tbpass.Text != ""
                )
            {
                string gender = "Male";

                if (rbfemale.Checked == true) { gender = "Female"; }

				if (tbpass.Text == "")
				{
					MessageBox.Show("Please enter password to save changes!");
				}
				else if (tbpass.Text != pass)
				{
					MessageBox.Show("Incorrect Password");
				}
				else
				{
					string query = "";
					if (tbnpass.Text == "" && tbcpass.Text == "")
					{
						query = "UPDATE Employees Set Username='" + tbuname.Text +
							"',FirstName='" + tbfname.Text +
							"',LastName='" + tblname.Text +
							"',Gender='" + gender +
							"',DOB='" + dtpdob.Text +
							"',Email='" + tbemail.Text +
							"',Phone='" + tbphone.Text +
							"',Address='" + tbaddress.Text +
							"' Where Username='" + username + "';";
					}

					else if (tbnpass.Text != tbcpass.Text)
					{
						MessageBox.Show("New passwords does not match");
					}

					else if (Validations.Pass_validate(tbnpass.Text))
					{
						query = "UPDATE Employees Set Username='" + tbuname.Text +
							"',FirstName='" + tbfname.Text +
							"',LastName='" + tblname.Text +
							"',Gender='" + gender +
							"',DOB='" + dtpdob.Text +
							"',Email='" + tbemail.Text +
							"',Phone='" + tbphone.Text +
							"',Address='" + tbaddress.Text +
							"',Passcode='" + tbnpass.Text +
							"' Where Username='" + username + "';";
					}

					else
					{
						MessageBox.Show("Make sure to have Upper & Lower Case, Numbers & Symbols and at least 6 characters long");
					}
					if (query != "")
					{
						SqlConnection conn = null;
						try
						{
							conn = new SqlConnection(@"Data Source=DESKTOP-NO4RLJM\SQLEXPRESS;Initial Catalog=ShopNSavor;Integrated Security=True");
							conn.Open();
							SqlCommand cmd = new SqlCommand(query, conn);
							cmd.ExecuteNonQuery();
							MessageBox.Show("Information Updated, please Log In again");
							Close();
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
				}
			}
            else
            {
                MessageBox.Show("Plase make sure to write all the fields");
            }
        }

		private void button8_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void button3_Click(object sender, EventArgs e)
		{
            inputinfo.Enabled = true;
            button9.Enabled = true;
            button4.Enabled = true;
            button1.Enabled = true;

            if (button3.Text == "🌙")
			{
				button3.Text = "☀️";
				this.BackColor = Color.FromArgb(64, 64, 64);
                button1.BackColor = Color.FromArgb(0, 0, 0); 
                button2.BackColor = Color.FromArgb(0, 0, 0);
                button3.BackColor = Color.FromArgb(0, 0, 0);
                button4.BackColor = Color.FromArgb(0, 0, 0);
                button8.BackColor = Color.FromArgb(0, 0, 0);
                button9.BackColor = Color.FromArgb(0, 0, 0);
				Cancel.BackColor = Color.FromArgb(0, 0, 0);
				Save.BackColor = Color.FromArgb(0, 0, 0);

                button1.ForeColor = Color.FromArgb(255, 255, 255);
                button2.ForeColor = Color.FromArgb(255, 255, 255);
                button3.ForeColor = Color.FromArgb(255, 255, 255);
                button4.ForeColor = Color.FromArgb(255, 255, 255);
                button8.ForeColor = Color.FromArgb(255, 255, 255);
                button9.ForeColor = Color.FromArgb(255, 255, 255);
                Cancel.ForeColor = Color.FromArgb(255, 255, 255);
                Save.ForeColor = Color.FromArgb(255, 255, 255);

                label1.ForeColor = Color.FromArgb(255, 255, 255);
				label2.ForeColor = Color.FromArgb(255, 255, 255);
				label3.ForeColor = Color.FromArgb(255, 255, 255);
				label4.ForeColor = Color.FromArgb(255, 255, 255);
				label5.ForeColor = Color.FromArgb(255, 255, 255);
                label6.ForeColor = Color.FromArgb(255, 255, 255);
                label7.ForeColor = Color.FromArgb(255, 255, 255);
				label8.ForeColor = Color.FromArgb(255, 255, 255);
				label9.ForeColor = Color.FromArgb(255, 255, 255);
				label10.ForeColor = Color.FromArgb(255, 255, 255);
                label11.ForeColor = Color.FromArgb(255, 255, 255);
				label12.ForeColor = Color.FromArgb(255, 255, 255);
				rbmale.ForeColor = Color.FromArgb(255, 255, 255);
                rbfemale.ForeColor = Color.FromArgb(255, 255, 255);

                pictureBox2.Visible = true;
				pictureBox1.Visible = false;
            }
			else
			{
				
				button3.Text = "🌙";
                this.BackColor = Color.FromArgb(224, 224, 224);
                button1.BackColor = Color.FromArgb(255, 255, 255);
                button2.BackColor = Color.FromArgb(255, 255, 255);
                button3.BackColor = Color.FromArgb(255, 255, 255);
                button4.BackColor = Color.FromArgb(255, 255, 255);
                button8.BackColor = Color.FromArgb(255, 255, 255);
                button9.BackColor = Color.FromArgb(255, 255, 255);
                Cancel.BackColor = Color.FromArgb(255, 255, 255);
                Save.BackColor = Color.FromArgb(255, 255, 255);

                button1.ForeColor = Color.FromArgb(0, 0, 0);
                button2.ForeColor = Color.FromArgb(0, 0, 0);
                button3.ForeColor = Color.FromArgb(0, 0, 0);
                button4.ForeColor = Color.FromArgb(0, 0, 0);
                button8.ForeColor = Color.FromArgb(0, 0, 0);
                button9.ForeColor = Color.FromArgb(0, 0, 0);
                Cancel.ForeColor = Color.FromArgb(0, 0, 0);
                Save.ForeColor = Color.FromArgb(0, 0, 0);

                label1.ForeColor = Color.FromArgb(0, 0, 0);
                label2.ForeColor = Color.FromArgb(0, 0, 0);
                label3.ForeColor = Color.FromArgb(0, 0, 0);
                label4.ForeColor = Color.FromArgb(0, 0, 0);
                label5.ForeColor = Color.FromArgb(0, 0, 0);
                label6.ForeColor = Color.FromArgb(0, 0, 0);
                label7.ForeColor = Color.FromArgb(0, 0, 0);
                label8.ForeColor = Color.FromArgb(0, 0, 0);
                label9.ForeColor = Color.FromArgb(0, 0, 0);
                label10.ForeColor = Color.FromArgb(0, 0, 0);
                label11.ForeColor = Color.FromArgb(0, 0, 0);
                label12.ForeColor = Color.FromArgb(0, 0, 0);
                rbmale.ForeColor = Color.FromArgb(0, 0, 0);
                rbfemale.ForeColor = Color.FromArgb(0, 0, 0);

                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
            }
			Cancel_Click(null, EventArgs.Empty);
		}

        private void button1_Click(object sender, EventArgs e)
        {
			Admin a = new Admin(username);
			a.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
			Inventory i = new Inventory();
			i.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
			Sell s = new Sell();
			s.ShowDialog();
        }
    }
}
