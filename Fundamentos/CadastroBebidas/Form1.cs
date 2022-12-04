using DataApp;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CadastroBebidas
{
    public partial class Form1 : Form
    {
        public List<Bebida> ListaBebidas { get; set; }
        public Form1()
        {
            InitializeComponent();
            this.ListaBebidas = new List<Bebida>();
            CarregaLista();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimpaTela();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Bebida bebida = new Bebida();
            bebida.Id = Convert.ToInt32(tbId.Text);
            bebida.Tipo = tbTipo.Text;
            bebida.Marca = tbMarca.Text;
            bebida.Valor = Convert.ToDecimal(tbValor.Text);

            this.ListaBebidas.Add(bebida);

            CarregaLista();

            LimpaTela();
        }

        private void LimpaTela()
        {
            tbId.Text = String.Empty;
            tbMarca.Text = String.Empty;
            tbTipo.Text = String.Empty;
            tbValor.Text = String.Empty;
        }

        private void CarregaLista()
        {
            this.dgBebidas.DataSource = null;
            this.dgBebidas.DataSource = this.ListaBebidas;
        }
    }
}