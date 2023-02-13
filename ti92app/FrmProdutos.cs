using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ti92class;

namespace ti92app
{
    public partial class FrmProdutos : Form
    {
        public FrmProdutos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto(
                txtDescricao.Text, cmbUnidade.Text,txtCodBar.Text, double.Parse(mskPreco.Text), double.Parse(mskDesconto.Text));
            produto.Inserir();
            txtId.Text = produto.Id.ToString();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
