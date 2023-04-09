using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
    public partial class StockMain : Form
    {
        public StockMain()
        {
            InitializeComponent();
            Products pro = new Products();
            pro.MdiParent = this;
            pro.Show();
        }
        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Products pro = new Products();
            pro.MdiParent = this;
            pro.Show();
        }

        private void StockMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stock stk = new Stock();
            stk.MdiParent = this;
            stk.Show();
        }

        private void txtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImportFilePopup ppup = new ImportFilePopup();
            ppup.Show();
        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoriesManager manager = new CategoriesManager();
            //manager.MdiParent = this;
            manager.Show();
        }
    }
}
