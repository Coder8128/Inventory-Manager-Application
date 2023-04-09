using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
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
    public partial class Stock : Form
    {
        public static Stock instance;

        public Stock()
        {
            InitializeComponent();
            instance = this;
        }

        private void Stock_Load(object sender, EventArgs e)
        {
            this.ActiveControl = dateTimePicker1;
            comboBoxS1.SelectedIndex = 0;
            //LoadData();
            LoadView();
            Loadcategories();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void ResetRcords()
        {
            dateTimePicker1.Value = DateTime.Now;
            textBoxS1.Clear();
            textBoxS2.Clear();
            textBoxS3.Clear();
            comboBoxS1.SelectedIndex = -1;
            comboBoxS2.SelectedIndex = -1;
            btnSAdd.Text = "Add";
            dateTimePicker1.Focus();
        }

        private void btnSReset_Click(object sender, EventArgs e)
        {
            ResetRcords();
        }

        private bool Validation()
        {
            bool result = false;
            if(string.IsNullOrEmpty(textBoxS1.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(textBoxS1, "Product Code Required");
            }
            else if (string.IsNullOrEmpty(textBoxS2.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(textBoxS2, "Product Name Required");
            }
            else if (string.IsNullOrEmpty(textBoxS3.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(textBoxS3, "Quantity Required");
            }
            else if (comboBoxS1.SelectedIndex == -1)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(comboBoxS1, "Product Name Required");
            }
            else
            {
                errorProvider1.Clear();
                result = true;
            }
            return result;
        }
        private bool IfProductExists(SqlConnection con, string productCode)
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select 1 FROM [Items] WHERE [ProductCode]='" + productCode + "' ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
                return true;
            else 
                return false;
        }

        private void btnSAdd_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                SqlConnection con = Connection.getConnection();
                con.Open();
                bool status = false;
                if(comboBoxS1.SelectedIndex == 0)
                {
                    status = true;
                }
                else
                {
                    status = false;
                }

                var SqlQuery = "";
                if(IfProductExists(con, textBoxS1.Text))
                {
                    SqlQuery = @"UPDATE [dbo].[Items] 
                                    SET 
                                        [ProductName] = '" + textBoxS2.Text + "', " +
                                        "[Quantity] = '" + textBoxS3.Text + "', " +
                                        "[ProductStatus] = '" + status + "', " +
                                        "[Category] = '" + comboBoxS2.Text + "' " +
                                  "WHERE [ProductCode]= '" + textBoxS1.Text + "' ";
                }
                else
                {
                    SqlQuery = @"INSERT INTO [dbo].[Items]
                                                ([ProductCode],[ProductName],[TransDate],[Quantity],[Category], [ProductStatus]) 
                                 VALUES ('" + textBoxS1.Text + "', '" + textBoxS2.Text + "', '" + dateTimePicker1.Value.ToString("MM/dd/yyyy") + "', '" + textBoxS3.Text + "','" + comboBoxS2.Text + "', '" + status + "')";
                }
                SqlCommand cmd = new SqlCommand(SqlQuery, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Saved");
                ResetRcords();
            }
            LoadView();
        }
        public void LoadData()
        {
            SqlConnection con = Connection.getConnection();
            SqlDataAdapter sda = new SqlDataAdapter("Select * From [Stock].[dbo].[Stock] ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.Rows.Clear();
            foreach(DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells["Column1"].Value = n + 1;
                dataGridView1.Rows[n].Cells["Column2"].Value = item["ProductCode"].ToString();
                dataGridView1.Rows[n].Cells["Column3"].Value = item["ProductName"].ToString();
                dataGridView1.Rows[n].Cells["Column4"].Value = float.Parse(item["Quantity"].ToString());
                dataGridView1.Rows[n].Cells["Column5"].Value = Convert.ToDateTime(item["TransDate"].ToString()).ToString("dd/MM/yyyy");
                if ((bool)item["ProductStatus"])
                {
                    dataGridView1.Rows[n].Cells["Column6"].Value = "Active";
                }
                else
                {
                    dataGridView1.Rows[n].Cells["Column6"].Value = "Inactive";
                }
            }
            if(dataGridView1.Rows.Count > 0)
            {
                labelS1.Text = dataGridView1.Rows.Count.ToString();
                float totQty = 0;
                for(int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    totQty += float.Parse(dataGridView1.Rows[i].Cells["Column4"].Value.ToString());
                    labelS2.Text = totQty.ToString();
                }
            }
            else
            {
                labelS1.Text = "0";
                labelS2.Text = "0";
            }
        }

        public void LoadView()
        {
            SqlConnection con = Connection.getConnection();
            SqlDataAdapter sda = new SqlDataAdapter("Select * From [Stock].[dbo].[StockView] ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells["Column1"].Value = n + 1;
                dataGridView1.Rows[n].Cells["Column2"].Value = item["ProductCode"].ToString();
                dataGridView1.Rows[n].Cells["Column3"].Value = item["ProductName"].ToString();
                dataGridView1.Rows[n].Cells["Column4"].Value = float.Parse(item["Quantity"].ToString());
                dataGridView1.Rows[n].Cells["Column5"].Value = Convert.ToDateTime(item["TransDate"].ToString()).ToString("dd/MM/yyyy");
                dataGridView1.Rows[n].Cells["Column6"].Value = item["Category"].ToString();
                if ((bool)item["ProductStatus"])
                {
                    dataGridView1.Rows[n].Cells["Column7"].Value = "Active";
                }
                else
                {
                    dataGridView1.Rows[n].Cells["Column7"].Value = "Inactive";
                }
            }
            if (dataGridView1.Rows.Count > 0)
            {
                labelS1.Text = dataGridView1.Rows.Count.ToString();
                float totQty = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    totQty += float.Parse(dataGridView1.Rows[i].Cells["Column4"].Value.ToString());
                    labelS2.Text = totQty.ToString();
                }
            }
            else
            {
                labelS1.Text = "0";
                labelS2.Text = "0";
            }
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                btnSAdd.Text = "Update";

                textBoxS1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                textBoxS2.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                textBoxS3.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString(); 
                dateTimePicker1.Text = DateTime.Parse(dataGridView1.SelectedRows[0].Cells["Column5"].Value.ToString()).ToString("dd/MM/yyyy");
                comboBoxS2.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                if (dataGridView1.SelectedRows[0].Cells[2].Value.ToString() == "Active")
                {
                    comboBoxS1.SelectedIndex = 1;
                }
                else
                {
                    comboBoxS1.SelectedIndex = 0;
                }
            }
            catch (System.ArgumentOutOfRangeException)
            {
                //MessageBox.Show("Table is empty");
            }
        }

        private void btnSDelete_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Are you sure?", "Message", MessageBoxButtons.YesNo);
            if(dg == DialogResult.Yes)
            {
                if (Validation())
                {
                    SqlConnection con = Connection.getConnection();
                    var sqlQuery = "";
                    if (IfProductExists(con, textBoxS1.Text))
                    {
                        con.Open();
                        sqlQuery = @"DELETE FROM [Items] 
                            WHERE [ProductCode] = '"
                        + textBoxS1.Text + "'";
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
            LoadView();
        }
        public void Loadcategories()
        {
            comboBoxS2.Items.Clear();
            SqlConnection con = Connection.getConnection();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT [Category] FROM [dbo].[ItemsCategory]", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboBoxS2.Items.Add(dt.Rows[i]["Category"]);
            }
        }
        private void comboBoxS2_MouseClick(object sender, MouseEventArgs e)
        {
            comboBoxS2.Items.Clear();
            Loadcategories();
        }

        private void SearchBarS1_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = Connection.getConnection();
            SqlDataAdapter sda = new SqlDataAdapter("Select * from Items WHERE " +
                "(ProductCode like '" + SearchBarS1.Text + "%') or " +
                "(ProductName like '%" + SearchBarS1.Text + "%') or " +
                "(Quantity like '" + SearchBarS1.Text + "%') or " +
                "(Category like '" + SearchBarS1.Text + "%') or " +
                "(ProductStatus like '%" + SearchBarS1.Text + "%')", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[1].Value = item[0].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item[1].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item[2].ToString();
                dataGridView1.Rows[n].Cells[4].Value = item[3].ToString();
                dataGridView1.Rows[n].Cells[5].Value = item[4].ToString();
                if ((bool)item["ProductStatus"])
                {
                    dataGridView1.Rows[n].Cells[6].Value = "Active";
                }
                else
                {
                    dataGridView1.Rows[n].Cells[6].Value = "Inacive";
                }

            }
        }

        private void SearchBarS1_MouseClick(object sender, MouseEventArgs e)
        {
            SearchBarS1.Clear();
        }
    }
}
