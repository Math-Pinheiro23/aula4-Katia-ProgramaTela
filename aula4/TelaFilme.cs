using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula4
{
    public partial class TelaFilme : Form
    {
        public TelaFilme()
        {
            InitializeComponent();
        }

        private void TelaFilme_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Titulo_Click(object sender, EventArgs e)
        {

        }
        Filme f = new Filme();// instanciação objeto
        Filme[] vet = new Filme[5]; //declaração do vetor de objetos
        int i = 0;

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (i == 5)
            {
                MessageBox.Show("Não foi possível gravar");
            }
            else
            {
                f.Titulo = txtTitulo.Text;
                f.Classificacao = txtClassificacao.Text;
                f.Genero = txtGenero.Text;
                f.Sinopse = txtSinopse.Text;
                vet[i] = f;
                i++;          
            }
            limpar();
        }

        private void limpar()
        {
            txtSinopse.Text = null;
            txtTitulo.Text = null;
            txtGenero.Text = null;
            txtClassificacao.Text = null;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            for (int x=0; x<5; x++)
            {
                if (txtTitulo.Text.Equals(vet[x].Titulo))
                {
                    txtClassificacao.Text = vet[x].Classificacao;
                    txtGenero.Text = vet[x].Genero;
                    txtSinopse.Text = vet[x].Sinopse;
                }
                else
                {
                    if (x == 4)
                    {
                        MessageBox.Show("Titulo não existe");
                    }
                }
            }
        }
    }
}
