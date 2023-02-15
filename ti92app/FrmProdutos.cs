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


        private void FrmProdutos_Load(object sender, EventArgs e)
        {
            var lista = Produto.Listar();
            int linha = 0;
            foreach (var item in lista)
            {
                dtgLista.Rows.Add();
                dtgLista.Rows[linha].Cells[0].Value = item.Id;
                dtgLista.Rows[linha].Cells[1].Value = item.CodBar;
                dtgLista.Rows[linha].Cells[2].Value = item.Descricao;
                dtgLista.Rows[linha].Cells[3].Value = item.Unidade;
                dtgLista.Rows[linha].Cells[4].Value = item.Preco;
                dtgLista.Rows[linha].Cells[5].Value = item.Desconto;
                dtgLista.Rows[linha].Cells[6].Value = item.Descontinuado;
                linha++;

            }
        }

        private void dtgLista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show("cliquei na célula");
            txtId.Text= dtgLista.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtCodBar.Text = dtgLista.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtDescricao.Text = dtgLista.Rows[e.RowIndex].Cells[2].Value.ToString();
            cmbUnidade.Text = dtgLista.Rows[e.RowIndex].Cells[3].Value.ToString();
            mskPreco.Text = dtgLista.Rows[e.RowIndex].Cells[4].Value.ToString();
            mskDesconto.Text = dtgLista.Rows[e.RowIndex].Cells[5].Value.ToString();
            chkDescontinuado.Checked = (bool)dtgLista.Rows[e.RowIndex].Cells[6].Value;
            chkDescontinuado.Enabled = true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto(
                int.Parse(txtId.Text),
                txtDescricao.Text,
                cmbUnidade.Text,
                txtCodBar.Text,
                double.Parse(mskPreco.Text),
                double.Parse(mskDesconto.Text),
                chkDescontinuado.Checked
                );
            produto.Atualizar();
            MessageBox.Show("Produto Atualizado com sucesso");
            FrmProdutos_Load(sender, e);
        }

        private void dtgLista_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            int id = (int)dtgLista.Rows[dtgLista.CurrentRow.Index].Cells[0].Value;
        }
    }
}
