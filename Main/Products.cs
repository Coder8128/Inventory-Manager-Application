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
    public partial class Products : Form
    {
        public static Products instance;

        public Products()
        {
            InitializeComponent();
            instance = this;
        }

        private void Products_Load(object sender, EventArgs e)
        {
            comboBox1P.SelectedIndex = 0;
            //LoadData();
            LoadView();
            LoadCategories();
        }
        //Update button
        private void btnPAdd_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                SqlConnection con = Connection.getConnection();
                con.Open();
                bool status = false;
                if (comboBox1P.SelectedIndex == 0)
                {
                    status = true;
                }
                else
                {
                    status = false;
                }

                var sqlQuery = "";
                sqlQuery = @"UPDATE [Items] 
                            SET [ProductName] = '" + textBoxPProdName.Text + "'," +
                                "   [ProductStatus] = '" + status + "'," +
                                "   [Category] = '" + comboBoxP2.Text + "'" +
                                "WHERE [ProductCode] = '" + textBoxPProdCode.Text + "'";

                //if (IfProductExists(con, textBoxPProdCode.Text))
                //{
                //    sqlQuery = @"UPDATE [ProductsView] 
                //            SET [ProductName] = '" + textBoxPProdName.Text + "'," +
                //                "   [ProductStatus] = '" + status + "' " +
                //                "WHERE [ProductCode] = '" + textBoxPProdCode.Text + "'";
                //}
                //else
                //{
                //    sqlQuery = @"INSERT INTO [dbo].[ProductsView]
                //                                     ([ProductCode]
                //                                    ,[ProductName]
                //                                    ,[ProductStatus])
                //                              VALUES
                //                                     ('" + textBoxPProdCode.Text + "'," +
                //                                          "'" + textBoxPProdName.Text + "'," +
                //                                          "'" + status + "')";
                //}

                SqlCommand cmd = new SqlCommand(sqlQuery, con);
                cmd.ExecuteNonQuery();
                con.Close();

                //Reading data
                //LoadData();
                LoadView();
                ResetRecords();
            }
        }
        private bool IfProductExists(SqlConnection con, string productCode)
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select 1 FROM [Items] WHERE [ProductCode] ='"+ productCode+"'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
              return true;
            else
                return false;
        }

        public void LoadData()
        {
            SqlConnection con = Connection.getConnection();
            SqlDataAdapter sda = new SqlDataAdapter("Select * FROM [Stock].[dbo].[Products]", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            dataGridView1P.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1P.Rows.Add();
                dataGridView1P.Rows[n].Cells[0].Value = item["ProductCode"].ToString();
                dataGridView1P.Rows[n].Cells[1].Value = item["ProductName"].ToString();
                if ((bool)item["ProductStatus"])
                {
                    dataGridView1P.Rows[n].Cells[2].Value = "Active";
                }
                else
                {
                    dataGridView1P.Rows[n].Cells[2].Value = "Inacive";
                }
            }
        }

        public void LoadView()
        {
            SqlConnection con = Connection.getConnection();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM [dbo].[ProductsView]", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            dataGridView1P.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1P.Rows.Add();
                dataGridView1P.Rows[n].Cells[0].Value = item["ProductCode"].ToString();
                dataGridView1P.Rows[n].Cells[1].Value = item["ProductName"].ToString();
                dataGridView1P.Rows[n].Cells[2].Value = item["Category"].ToString();
                if ((bool)item["ProductStatus"])
                {
                    dataGridView1P.Rows[n].Cells[3].Value = "Active";
                }
                else
                {
                    dataGridView1P.Rows[n].Cells[3].Value = "Inacive";
                }
            }
        }

        private void dataGridView1P_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                //btnPAdd.Text = "Update";

                textBoxPProdCode.Text = dataGridView1P.SelectedRows[0].Cells[0].Value.ToString();
                textBoxPProdName.Text = dataGridView1P.SelectedRows[0].Cells[1].Value.ToString();
                comboBoxP2.Text = dataGridView1P.SelectedRows[0].Cells[2].Value.ToString();
                if (dataGridView1P.SelectedRows[0].Cells[3].Value.ToString() == "Active")
                {
                    comboBox1P.SelectedIndex = 0;
                }
                else
                {
                    comboBox1P.SelectedIndex = 1;
                }
            }
            catch (System.ArgumentOutOfRangeException)
            {
                //MessageBox.Show("Table is empty");
            }
            
        }
        private void btnPDel_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                SqlConnection con = Connection.getConnection();
                var sqlQuery = "";
                if (IfProductExists(con, textBoxPProdCode.Text))
                {
                    con.Open();
                    sqlQuery = @"DELETE FROM [Items] 
                            WHERE [ProductCode] = '"
                    + textBoxPProdCode.Text + "'";
                    SqlCommand cmd = new SqlCommand(sqlQuery, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Record does not exist");
                }
                LoadView();
            }
        }
        private void ResetRecords()
        {
            textBoxPProdCode.Clear();
            textBoxPProdName.Clear();
            comboBox1P.SelectedIndex = -1;
            comboBoxP2.SelectedIndex = -1;
            //btnPAdd.Text = "Add";
        }

        private void btnPReset_Click(object sender, EventArgs e)
        {
            ResetRecords();
        }

        private bool Validation()
        {
            bool result = false;
            if (!string.IsNullOrEmpty(textBoxPProdName.Text) && !string.IsNullOrEmpty(textBoxPProdCode.Text) && comboBox1P.SelectedIndex > -1)
            {
                result = true;
            }
            return result;
        }

        private void textBoxPProdCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnPClearAll_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to clear table?", "Warning", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                SqlConnection con = Connection.getConnection();
                var sqlQuery = "";
                con.Open();
                sqlQuery = @"DELETE FROM [Items]";
                SqlCommand cmd = new SqlCommand(sqlQuery, con);
                cmd.ExecuteNonQuery();
                con.Close();
                LoadView();
                ResetRecords();
            }
            else if (dialogResult == DialogResult.No)
            {
                LoadView();
            }
        }

        private void btnPUpdateData_Click(object sender, EventArgs e)
        {
            LoadView();
        }

        public void LoadCategories()
        {
            SqlConnection con = Connection.getConnection();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT [Category] FROM [dbo].[ItemsCategory]", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboBoxP2.Items.Add(dt.Rows[i]["Category"]);
            }
        }
        private void comboBoxP2_MouseClick(object sender, MouseEventArgs e)
        {
            comboBoxP2.Items.Clear();
            LoadCategories();
        }
    }
}
