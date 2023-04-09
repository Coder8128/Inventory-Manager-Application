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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Main
{
    public partial class CategoriesManager : Form
    {
        public CategoriesManager()
        {
            InitializeComponent();
        }
        private void CategoriesManager_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            SqlConnection con = Connection.getConnection();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM [dbo].[ItemsCategory]", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            CatDatagridview.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = CatDatagridview.Rows.Add();
                CatDatagridview.Rows[n].Cells[0].Value = item["Category"].ToString();
            }
        }
        public string GetLastIndexRec()
        {
            SqlConnection con = Connection.getConnection();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT TOP 1 CatID FROM ItemsCategory ORDER BY CatID DESC;", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            string ind = "";
            foreach (DataRow item in dt.Rows)
            {
                ind = item["CatID"].ToString();
            }
            int.Parse(ind);
            ind += 1;
            return ind;
        }
        private void btnManPopup1_Click(object sender, EventArgs e)
        {
            SqlConnection con = Connection.getConnection();
            con.Open();

            string index = GetLastIndexRec();
            var SqlQuery = "";
            SqlQuery = @"INSERT INTO [dbo].[ItemsCategory]
                                                ([Category],[CatID]) 
                                 VALUES ('" + textBox1.Text + "', '" + index.ToString() + "')";

            SqlCommand cmd = new SqlCommand(SqlQuery, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Saved");
            LoadData();
        }

        private void btnManPopup2_Click(object sender, EventArgs e)
        {
            SqlConnection con = Connection.getConnection();
            var sqlQuery = "";
            con.Open();
            sqlQuery = @"DELETE FROM [ItemsCategory] 
                            WHERE [Category] = '"
                             + textBox1.Text + "'";
            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            cmd.ExecuteNonQuery();
            con.Close();
            LoadData();
            MessageBox.Show("Data has been deleted");
        }

        private void CatDatagridview_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                textBox1.Text = CatDatagridview.SelectedRows[0].Cells[0].Value.ToString();
            }
            catch (System.ArgumentOutOfRangeException)
            {
                //MessageBox.Show("Table is empty");
            }
        }
    }
}
