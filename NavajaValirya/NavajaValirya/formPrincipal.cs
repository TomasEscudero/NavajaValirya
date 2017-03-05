using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavajaValirya
{
    /// <summary>
    /// Clase formulario que es el formulario principal de la aplicación NavajaValiria.
    /// </summary>
    public partial class formPrincipal : Form
    {
        /// <summary>
        /// Formulario principal de la aplicación NavajaValiria.
        /// </summary>
        public formPrincipal()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Llama a la Aplicación 1 CambioDivisa
        /// </summary>
        /// <param name="sender">Lanza el evento del botón BCambioDivisa</param>
        /// <param name="e">Sin uso</param>
        private void BCambioDivisa_Click(object sender, EventArgs e)
        {
            CambioDivisa.formCambioDivisa OCambioDivisa = new CambioDivisa.formCambioDivisa();
            OCambioDivisa.ShowDialog();
            
        }

        /// <summary>
        /// Llama a la Aplicación 2 DisposicionEfectivo
        /// </summary>
        /// <param name="sender">Lanza el evento del botón BDisposicionEfectivo</param>
        /// <param name="e">Sin uso</param>
        private void BDisposicionEfectivo_Click(object sender, EventArgs e)
        {
            DisposicionEfectivo.formDisposicionEfectivo ODisposicionEfectivo = new DisposicionEfectivo.formDisposicionEfectivo();
            ODisposicionEfectivo.ShowDialog();
        }

        /// <summary>
        /// Llama a la Aplicación 3 FrasePalindromica
        /// </summary>
        /// <param name="sender">Lanza el evento del botón BFrasePalindromica</param>
        /// <param name="e">Sin uso</param>
        private void BFrasePalindromica_Click(object sender, EventArgs e)
        {
            FrasePalindromica.formFrasePalindromica OFrasePalindromica = new FrasePalindromica.formFrasePalindromica();
            OFrasePalindromica.ShowDialog();
        }

        /// <summary>
        /// Llama a la Aplicación 4 ContadorPalabras
        /// </summary>
        /// <param name="sender">Lanza el evento del botón BContadorPalabras</param>
        /// <param name="e">Sin uso</param>
        private void BContadorPalabras_Click(object sender, EventArgs e)
        {
            ContadorPalabras.formContadorPalabras OContadorPalabras = new ContadorPalabras.formContadorPalabras();
            OContadorPalabras.ShowDialog();
        }
    }
}
