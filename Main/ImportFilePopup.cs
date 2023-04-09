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
using Main;

namespace Main
{
    public partial class ImportFilePopup : Form
    {
        public static ImportFilePopup instance;

        public ImportFilePopup()
        {
            InitializeComponent();
            instance = this;
        }

        private void btnImportPP_Click(object sender, EventArgs e)
        {
            SqlConnection con = Connection.getConnection();
            con.Open();
            string pathStr = "'" + textBoxPP1.Text + "'";
            var SqlQuery = "";
            SqlQuery = @"BULK INSERT [dbo].[Items]
                        FROM " + pathStr + " WITH (FIELDTERMINATOR = ',', ROWTERMINATOR = '\\n')";



            SqlCommand cmd = new SqlCommand(SqlQuery, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("File uploaded");

            Products.instance.LoadView();
            Stock.instance.LoadView();
        }
    }
}
