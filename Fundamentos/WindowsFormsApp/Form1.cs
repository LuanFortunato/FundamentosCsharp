using System;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnValores_Click(object sender, EventArgs e)
        {
            if (lbByteMin.Text == "*****")
            {
                lbByteMin.Text = byte.MinValue.ToString();
                lbByteMax.Text = byte.MaxValue.ToString();
            }
            else
            {
                lbByteMin.Text = "*****";
                lbByteMax.Text = "*****";
            }
        }
    }
}
