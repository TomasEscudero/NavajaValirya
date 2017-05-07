using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Namespace de la Aplicación 2 del proyecto NavajaValirya.
/// </summary>
namespace NavajaValirya.DisposicionEfectivo
{
    /// <summary>
    /// Clase formulario que ejecuta la aplicación 2 que corresponde a DisposicionEfectivo.
    /// <para>Clase que devuelve la cantidad de billetes y monedas mínimos para la alcanzar la cantidad introducida.</para>
    /// </summary>
    public partial class formDisposicionEfectivo : Form
    {
        /// <summary>
        /// Inicializa los componentes del Formulario DisposicionEfectivo.
        /// </summary>
        public formDisposicionEfectivo()
        {
            InitializeComponent();
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        /// <summary>
        /// Lee la cantidad de la caja de texto TCantidad y muestra el resultado de la función disponerEfectivo en el label LDisposicion.
        /// </summary>
        /// <param name="sender">Lanza el evento el botón button_1</param>
        /// <param name="e">Sin uso</param>       
        private void BDisposicionEfectivo_Click(object sender, EventArgs e)
        {
            int cantidadEfectivo;
            DisposicionEfectivoLogica OdisposicionEfectivo;

            if (int.TryParse(TCantidad.Text, out cantidadEfectivo))
            {
                OdisposicionEfectivo = new DisposicionEfectivoLogica();
                LDisposicion.Text = OdisposicionEfectivo.disponerEfectivo(cantidadEfectivo);                
            }

            else
            {
                MessageBox.Show("No ha introducido valor correcto, por favor, introduzca un número.");
            }                 
        }
    }
}
