using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavajaValirya.CambioDivisa
{
    public partial class formCambioDivisa : Form
    {
        public formCambioDivisa()
        {
            InitializeComponent();
        }

        const double kVALOR = 166.386;
        double cambioeuros(double numero)
        {
            double res;
            res = numero / kVALOR;
            return res;
        }

        double cambiopesetas(double numero)
        {
            double res;
            res = numero * kVALOR;
            return res;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double numero, resultado;

            numero = double.Parse(TNumero.Text);

            resultado = cambioeuros(numero);

            MessageBox.Show("El cambio son: " + resultado + "€.");


        }

        private void button2_Click(object sender, EventArgs e)
        {
            double numero, resultado;

            numero = double.Parse(TNumero.Text);

            resultado = cambiopesetas(numero);

            MessageBox.Show("El cambio son: " + resultado + "ptas.");
        }
    }
}
