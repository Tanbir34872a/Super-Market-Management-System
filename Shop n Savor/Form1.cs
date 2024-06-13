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

namespace Shop_n_Savor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            label3.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            linkLabel1.Visible = true;
            Log.Visible = true;
            Back.Visible = true;
            button1.Visible = false;
            button2.Visible = false;
            label4.Visible = false;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            label3.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            linkLabel1.Visible = false;
            Log.Visible = false;
            Back.Visible = false;
            button1.Visible = true;
            button2.Visible = true;
            label4.Visible = true;
        }

        private void Log_Click(object sender, EventArgs e)
        {
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(@"Data Source=DESKTOP-NO4RLJM\SQLEXPRESS;Initial Catalog=ShopNSavor;Integrated Security=True");
                conn.Open();

                string query = "select * from Employees where Username = '"+textBox1.Text+"';";
                SqlCommand cmd = new SqlCommand(query, conn);
                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];
                string pass = dt.Rows[0]["Passcode"].ToString();
                if (pass == textBox2.Text)
                {
                    MessageBox.Show("Access Granted");
                    //label4.Text = "...!Welcome!...";
                    LogIn l = new LogIn(textBox1.Text);
                    l.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Incorrect Password");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Incorrect Username");
            }
            finally
            {
                conn.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Inventory i = new Inventory();
            i.ShowDialog();
        }

        private void bexit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(@"Data Source=DESKTOP-NO4RLJM\SQLEXPRESS;Initial Catalog=ShopNSavor;Integrated Security=True");
                conn.Open();

                string query = "select * from Employees where Username = '" + textBox1.Text + "';";
                SqlCommand cmd = new SqlCommand(query, conn);
                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];
                string pass = dt.Rows[0]["Passcode"].ToString();
                Random rnd = new Random();
                int num = rnd.Next(100000, 999999);
                MessageBox.Show($"Your temporary password is {num}\nPlease Change password and login again!");
                LogIn fpl = new LogIn(textBox1.Text, num);
                fpl.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Incorrect Username");
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
