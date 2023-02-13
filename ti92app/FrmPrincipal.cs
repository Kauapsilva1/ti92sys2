using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ti92app
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

       

        private void operaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void statusStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = Environment.UserDomainName + "\\" +Environment.UserName;
        }

        private void novoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmProdutos frmProdutos = new FrmProdutos();
            frmProdutos.MdiParent= this;
            frmProdutos.Show();
            //frmProdutos.ShowDialog();
        }
    }
}
