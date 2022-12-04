using DataApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroBebidas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
        }

        private void LimpaTela()
        {
            tbId.Text = String.Empty;
            tbMarca.Text = String.Empty;
            tbTipo.Text = String.Empty;
            tbValor.Text = String.Empty;
        }
    }
}
