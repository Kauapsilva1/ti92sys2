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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var nivel = Nivel.ObterPorId(2);
            //label1.Text = nivel.Id + " - " + nivel.Nome + "-"+ nivel.Sigla;

            List<Nivel> list = Nivel.Listar();
            foreach (var item in list)
            {
                listBox1.Items.Add(item.Id +" - "+ item.Nome);
            }

            
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnInsereNIvel_Click(object sender, EventArgs e)
        {
            Nivel nivel = new Nivel(txtNomeNivel.Text,txtSiglaNivel.Text);
            nivel.Inserir();
            txtIdNivel.Text = nivel.Id.ToString();
            AtualizaListBox();
            MessageBox.Show("Nivel inserido com sucesso \n ID: "+ nivel.Id.ToString());
            txtIdNivel.Clear();
            txtSiglaNivel.Clear();
            txtNomeNivel.Clear();
            txtNomeNivel.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (btnEditar.Text == "Editar")
            {
                txtIdNivel.ReadOnly = false;
                txtIdNivel.Focus();
                btnEditar.Text = "Gravar";
                btnInsereNIvel.Enabled = false;
            }
            else
            {
                Nivel nivel = new Nivel();
                nivel.Id = int.Parse(txtIdNivel.Text);
                nivel.Nome= txtNomeNivel.Text;
                nivel.Sigla= txtSiglaNivel.Text;
                Nivel.Atualizar(nivel);
                txtIdNivel.ReadOnly = true;
                txtNomeNivel.Focus();
                btnEditar.Text = "Editar";
                AtualizaListBox();
            }
        }

        private void txtIdNivel_TextChanged(object sender, EventArgs e)
        {
            if (txtIdNivel.Text != String.Empty)
            { 
            
            }
            int id = int.Parse(txtIdNivel.Text);
            var nivel = Nivel.ObterPorId(id);
            txtNomeNivel.Text = nivel.Nome;
            txtSiglaNivel.Text = nivel.Sigla;
        }
        private void AtualizaListBox()
        {
            List<Nivel> list = Nivel.Listar();
            listBox1.Items.Clear();
            foreach (var item in list)
            {
                listBox1.Items.Add(item.Id + " - NOME: " + item.Nome +"- SIGLA:" +item.Sigla);
            }
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            // se txtBusca.Text for diferente de vazio
            //e (&&) txtBuscar.Text.Length for maior ou igual
            if (txtBusca.Text != string.Empty || txtBusca.Text.Length>=2)
            {
                listBox1.Items.Clear();
                var niveis = Nivel.BuscarPorNome(txtBusca.Text);
                if (niveis.Count > 0)
                {
                    foreach (var nivel in niveis)
                    {
                        listBox1.Items.Add(nivel.Id + " - " + nivel.Sigla);
                    }

                }
                else
                { 
                    listBox1.Items.Clear();
                    listBox1.Items.Add("Não há registros para está consulta...");
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtIdNivel.Text != string.Empty)
            {
                Nivel nivel = Nivel.ObterPorId(int.Parse(txtIdNivel.Text));
                if (nivel.Excluir(nivel.Id))
                {
                    MessageBox.Show("Nivel exclúido com sucesso!","Exclusão de nivel");
                    AtualizaListBox();
                }
            }
        }

        private void txtIdUsuario_TextChanged(object sender, EventArgs e)
        {
                if (txtIdUsuario.Text != String.Empty)
                {

                }
                int id = int.Parse(txtIdUsuario.Text);
                var usuario = Usuario.ObterPorId(id);
                txtNomeNivel.Text = usuario.Nome;
                txtSiglaNivel.Text = usuario.Sigla;
        }
    }
}
