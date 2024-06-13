using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Shop_n_Savor
{
    internal class Validations
    {
        public static bool Pass_validate(string a)
        {
            int flag = 0;
            if (a.Length < 6) { return false; }
            foreach (char c in a)
            {
                if (c >= 'a' && c <= 'z') { flag++; break; }
            }
            if (flag != 1) { return false; }
            foreach (char c in a)
            {
                if (c >= 'A' && c <= 'Z') { flag++; break; }
            }
            if (flag != 2) { return false; }
            foreach (char c in a)
            {
                if (c >= '0' && c <= '9') { flag++; break; }
            }
            if (flag != 3) { return false; }
            foreach (char c in a)
            {
                if (!(c >= 'a' && c <= 'z') && !(c >= 'A' && c <= 'Z') && !(c >= '0' && c <= '9')) { flag++; break; }
            }
            if (flag != 4) { return false; }

            return true;
        }

        public static bool User_validate(string a)
        {
            string val = "";
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(@"Data Source=DESKTOP-NO4RLJM\SQLEXPRESS;Initial Catalog=ShopNSavor;Integrated Security=True");
                conn.Open();

                string query = $"SELECT COUNT(Username) FROM Employees WHERE Username = '{a}';";
                SqlCommand cmd = new SqlCommand(query, conn);
                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];
                val = dt.Rows[0][0].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            if (val == "0") { return true; }
            else { return false; }

        }
    }
}
