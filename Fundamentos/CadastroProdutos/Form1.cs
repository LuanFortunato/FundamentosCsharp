using DataApp;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CadastroProdutos
{
    public partial class Form1 : Form
    {
        public List<Produto> Produtos { get; set; }
        public Form1()
        {
            InitializeComponent();
            this.Produtos = new List<Produto>();
            CarregaProdutos();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();
            produto.Id = Convert.ToInt32(tbId.Text);
            produto.Nome = tbNome.Text;
            produto.Tipo = tbTipo.Text;
            produto.Valor = Convert.ToDecimal(tbValor.Text);

            this.Produtos.Add(produto);

            CarregaProdutos();

            LimpaTela();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimpaTela();
        }

        private void LimpaTela()
        {
            tbId.Text = String.Empty;
            tbNome.Text = String.Empty;
            tbTipo.Text = String.Empty;
            tbValor.Text = String.Empty;
        }

        private void CarregaProdutos()
        {
            this.dgProdutos.DataSource = null;
            this.dgProdutos.DataSource = this.Produtos;
        }
    }
}
