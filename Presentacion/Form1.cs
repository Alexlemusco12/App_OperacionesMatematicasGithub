using System;
using System.Windows.Forms;
using Negocio;

namespace Presentacion
{
    public partial class Form1 : Form
    {
        clsOperaciones objOperaciones = new clsOperaciones();
        public Form1()
        {
            InitializeComponent();
        }

        private void ptbGrabarN1_Click(object sender, EventArgs e)
        {
            objOperaciones.setNumero1(Convert.ToDouble(txtNumero1.Text));
        }

        private void ptbGrabarN2_Click(object sender, EventArgs e)
        {
            objOperaciones.setNumero2(Convert.ToDouble(txtNumero2.Text));
        }

        private void ptbCalcular_Click(object sender, EventArgs e)
        {
            objOperaciones.setCalcularOperaciones(cmbOperaciones.SelectedIndex);
            lblResultado.Text = Convert.ToString(objOperaciones.getResultado());
            if(objOperaciones.getMensaje() != null)
            {
                MessageBox.Show(objOperaciones.getMensaje());
            }
        }
    }
}
