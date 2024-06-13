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
using System.Web;
using System.Security.AccessControl;

namespace Shop_n_Savor
{
	public partial class Cart : Form
	{
		DataTable dt;
		int row;

		public Cart()
		{
			InitializeComponent();
		}

		void GetProducts()
		{
			SqlConnection conn = null;
			try
			{
				conn = new SqlConnection(@"Data Source=DESKTOP-NO4RLJM\SQLEXPRESS;Initial Catalog=ShopNSavor;Integrated Security=True");
				conn.Open();

				string query = "select * from Cart;";
				SqlCommand cmd = new SqlCommand(query, conn);
				DataSet ds = new DataSet();
				SqlDataAdapter adp = new SqlDataAdapter(cmd);
				adp.Fill(ds);
				dt = ds.Tables[0];
				dt.DefaultView.RowFilter = $"Quantity <> '0'";
				dgvproducts.DataSource = dt;
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

		private void Cart_Load(object sender, EventArgs e)
		{
			GetProducts();
		}

		private string totalPrice(string a, string b)
		{
			double price = Convert.ToDouble(a) * Convert.ToInt32(b); ;
			return Convert.ToString(price);
		}

		private void dgvproducts_CellEnter(object sender, DataGridViewCellEventArgs e)
		{
			tbcount.Text = "1";
			row = dgvproducts.CurrentRow.Index;
			tbpid.Text = dgvproducts.CurrentRow.Cells[0].Value.ToString();
			tbname.Text = dgvproducts.CurrentRow.Cells[1].Value.ToString();
			tbcomp.Text = dgvproducts.CurrentRow.Cells[2].Value.ToString();
			tbprice.Text = dgvproducts.CurrentRow.Cells[3].Value.ToString();
			tbquant.Text = dgvproducts.CurrentRow.Cells[4].Value.ToString();
            productPic.Image = Image.FromFile("C:\\Users\\tanbi\\OneDrive\\Codes\\Supermarket Inventory Management System\\Products\\" + tbpid.Text + ".jpg");
            totprice.Text = totalPrice(tbprice.Text, tbquant.Text);
            int sum = 0;
            for (int i = 0; i < dgvproducts.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dgvproducts.Rows[i].Cells[3].Value)*Convert.ToInt32(dgvproducts.Rows[i].Cells[4].Value);
            }
            FinPrice.Text = sum.ToString();

        }

		private void bexit_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void tbsearch_TextChanged(object sender, EventArgs e)
		{
			try
			{
				DataView dv = dt.DefaultView;
				dv.RowFilter = string.Format("ProductName Like '%{0}%' or Company Like '%{0}%'", tbsearch.Text);
				dgvproducts.DataSource = dv;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			if (row <= dgvproducts.RowCount - 1)
			{
				if (row != dgvproducts.RowCount - 1)
				{
					dgvproducts.CurrentCell = dgvproducts.Rows[++row].Cells[0];
				}
				else
				{
					MessageBox.Show("This is the last product on list");
				}
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (row >= 0)
			{
				if (row != 0)
				{
					dgvproducts.CurrentCell = dgvproducts.Rows[--row].Cells[0];
				}
				else
				{
					MessageBox.Show("This is the first product on list");
				}
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (row >= 0)
			{
				if (row != 0)
				{
					row = 0;
					dgvproducts.CurrentCell = dgvproducts.Rows[row].Cells[0];
				}
				else
				{
					MessageBox.Show("This is the first product on list");
				}
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			if (row <= dgvproducts.RowCount - 1)
			{
				if (row != dgvproducts.RowCount - 1)
				{
					row = dgvproducts.RowCount - 1;
					dgvproducts.CurrentCell = dgvproducts.Rows[row].Cells[0];
				}
				else
				{
					MessageBox.Show("This is the last product on list");
				}
			}
		}

		private void button6_Click(object sender, EventArgs e)
		{
			tbcount.Text = Convert.ToString(1 + Convert.ToInt32(tbcount.Text));
		}

		private void button7_Click(object sender, EventArgs e)
		{
			int c = Convert.ToInt32(tbcount.Text);
			if (c > 1)
			{
				tbcount.Text = Convert.ToString(c - 1);
			}
			else
			{
				tbcount.Text = "1";
			}
		}

		private void button8_Click(object sender, EventArgs e)
		{
			int c = Convert.ToInt32(tbcount.Text);
			int q = Convert.ToInt32(tbquant.Text);

			if (c >= 1 && c <= q)
			{
				SqlConnection conn = null;
				try
				{
					conn = new SqlConnection(@"Data Source=DESKTOP-NO4RLJM\SQLEXPRESS;Initial Catalog=ShopNSavor;Integrated Security=True");
					conn.Open();

					string query = $"update cart set Quantity -= '{c}' where ProductID = '{tbpid.Text}';";
					SqlCommand cmd = new SqlCommand(query, conn);
					cmd.ExecuteNonQuery();
					MessageBox.Show("Items removed");
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
				finally
				{
					conn.Close();
				}
				GetProducts();
			}
			else
			{
				MessageBox.Show($"Please select an appropriate value in range of 1 to {q}");
				tbcount.Text = "1";
			}
		}

		private void button5_Click(object sender, EventArgs e)
		{
			SqlConnection conn = null;
			try
			{
				conn = new SqlConnection(@"Data Source=DESKTOP-NO4RLJM\SQLEXPRESS;Initial Catalog=ShopNSavor;Integrated Security=True");
				conn.Open();

				string query = "UPDATE Products SET Products.Quantity -= Cart.Quantity FROM Products Left JOIN Cart ON Products.ProductID = Cart.ProductID;";
				SqlCommand cmd = new SqlCommand(query, conn);
				cmd.ExecuteNonQuery();
				MessageBox.Show("Thanks for shopping with us!");
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

		private void button9_Click(object sender, EventArgs e)
		{
			if (button9.Text == "🌙")
			{
				button9.Text = "☀️";
				this.BackColor = Color.FromArgb(64, 64, 64);
				dgvproducts.BackgroundColor = Color.FromArgb(64, 64, 64);

				logoblack.Visible = false;
				logowhite.Visible = true;

				panel3.ForeColor = Color.FromArgb(255, 255, 255);
				label11.ForeColor = Color.FromArgb(255, 255, 255);
				label7.ForeColor = Color.FromArgb(255, 255, 255);
				label8.ForeColor = Color.FromArgb(255, 255, 255);
				label10.ForeColor = Color.FromArgb(255, 255, 255);
                label12.ForeColor = Color.FromArgb(255, 255, 255);
                label13.ForeColor = Color.FromArgb(255, 255, 255);
                totprice.ForeColor = Color.FromArgb(255, 255, 255);
                FinPrice.ForeColor = Color.FromArgb(255, 255, 255);

                bexit.ForeColor = Color.FromArgb(255, 255, 255);
				bexit.BackColor = Color.FromArgb(0, 0, 0);

				button1.ForeColor = Color.FromArgb(255, 255, 255);
				button2.ForeColor = Color.FromArgb(255, 255, 255);
				button3.ForeColor = Color.FromArgb(255, 255, 255);
				button4.ForeColor = Color.FromArgb(255, 255, 255);
				button5.ForeColor = Color.FromArgb(255, 255, 255);
				button6.ForeColor = Color.FromArgb(255, 255, 255);
				button7.ForeColor = Color.FromArgb(255, 255, 255);
				button8.ForeColor = Color.FromArgb(255, 255, 255);
				button9.ForeColor = Color.FromArgb(255, 255, 255);

				button1.BackColor = Color.FromArgb(0, 0, 0);
				button2.BackColor = Color.FromArgb(0, 0, 0);
				button3.BackColor = Color.FromArgb(0, 0, 0);
				button4.BackColor = Color.FromArgb(0, 0, 0);
				button5.BackColor = Color.FromArgb(0, 0, 0);
				button6.BackColor = Color.FromArgb(0, 0, 0);
				button7.BackColor = Color.FromArgb(0, 0, 0);
				button8.BackColor = Color.FromArgb(0, 0, 0);
				button9.BackColor = Color.FromArgb(0, 0, 0);
			}
			else
			{
				button9.Text = "🌙";
				this.BackColor = Color.FromArgb(235, 235, 235);
				dgvproducts.BackgroundColor = Color.FromArgb(235, 235, 235);

				logoblack.Visible = true;
				logowhite.Visible = false;

				panel3.ForeColor = Color.FromArgb(0, 0, 0);
				label11.ForeColor = Color.FromArgb(0, 0, 0);
				label7.ForeColor = Color.FromArgb(0, 0, 0);
				label8.ForeColor = Color.FromArgb(0, 0, 0);
				label10.ForeColor = Color.FromArgb(0, 0, 0);
                label12.ForeColor = Color.FromArgb(0, 0, 0);
                label13.ForeColor = Color.FromArgb(0, 0, 0);
                totprice.ForeColor = Color.FromArgb(0, 0, 0);
                FinPrice.ForeColor = Color.FromArgb(0, 0, 0);

                bexit.ForeColor = Color.FromArgb(0, 0, 0);
				bexit.BackColor = Color.FromArgb(255, 255, 255);

				button1.BackColor = Color.FromArgb(255, 255, 255);
				button2.BackColor = Color.FromArgb(255, 255, 255);
				button3.BackColor = Color.FromArgb(255, 255, 255);
				button4.BackColor = Color.FromArgb(255, 255, 255);
				button5.BackColor = Color.FromArgb(255, 255, 255);
				button6.BackColor = Color.FromArgb(255, 255, 255);
				button7.BackColor = Color.FromArgb(255, 255, 255);
				button8.BackColor = Color.FromArgb(255, 255, 255);
				button9.BackColor = Color.FromArgb(255, 255, 255);

				button1.ForeColor = Color.FromArgb(0, 0, 0);
				button2.ForeColor = Color.FromArgb(0, 0, 0);
				button3.ForeColor = Color.FromArgb(0, 0, 0);
				button4.ForeColor = Color.FromArgb(0, 0, 0);
				button5.ForeColor = Color.FromArgb(0, 0, 0);
				button6.ForeColor = Color.FromArgb(0, 0, 0);
				button7.ForeColor = Color.FromArgb(0, 0, 0);
				button8.ForeColor = Color.FromArgb(0, 0, 0);
				button9.ForeColor = Color.FromArgb(0, 0, 0);
			}
		}
    }
}
