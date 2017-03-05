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
    /// <summary>
    /// Clase formulario que ejecuta la aplicación 1 que corresponde a CambioDivisa
    /// </summary>
    public partial class formCambioDivisa : Form
    {
        /// <summary>
        /// Formulario CambioDivisa
        /// </summary>
        public formCambioDivisa()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Es la constante para realizar el cambio entre las divisas.
        /// </summary>
        const double kVALOR = 166.386;

        /// <summary>
        /// Función cambioEuros.
        /// <para>Realiza el cambio de Euros a Pesetas.</para>
        /// </summary>
        /// <param name="cantidadEuros">El valor del parámetro <paramref name="cantidadEuros"/> es la cantidad de euros que se quiere cambiar a pesetas.</param>
        /// <remarks>Se pueden introducir cantidades con céntimos de euro.</remarks>
        /// <returns name="resultadoCambio">Devuelve la <paramref name="cantidadEuros"/> cambiada en pesetas.</returns>
        /// <value>El dinero cambiado a pesetas.</value>
        public double cambioEuros(double cantidadEuros)
        {
            double resultadoCambio;

            resultadoCambio = cantidadEuros / kVALOR;

            return resultadoCambio;
        }

        /// <summary>
        /// Función cambioPesetas.
        /// <para>Realiza el cambio de Pesetas a Euros.</para>
        /// </summary>
        /// <param name="cantidadPesetas">El valor del parámetro <paramref name="cantidadPesetas"/> es la cantidad de pesetas que se quiere cambiar a euros.</param>
        /// <remarks>No se pueden introducir cantidades con decimales ya que las pesetas no tenían centimos.</remarks>
        /// <returns name="resultadoCambio">Devuelve la <paramref name="cantidadPesetas"/> cambiada en euros.</returns>
        /// <value>El dinero cambiado a euros.</value>
        public double cambioPesetas(double cantidadPesetas)
        {
            double resultadoCambio;

            resultadoCambio = cantidadPesetas * kVALOR;

            return resultadoCambio;
        }

        /// <summary>
        /// Lee la cantidad de la caja de texto TCantidad y ejecuta la función cambioEuros.
        /// </summary>
        /// <param name="sender">Lanza el evento el botón BCambioEuros</param>
        /// <param name="e">Sin uso</param>        
        private void BCambioEnEuros_Click(object sender, EventArgs e)
        {
            double cantidadPesetas, resultadoEuros;

            cantidadPesetas = double.Parse(TCantidad.Text);

            resultadoEuros = cambioEuros(cantidadPesetas);

            MessageBox.Show("El cambio son: " + resultadoEuros + "€.");            
        }

        /// <summary>
        /// Lee la cantidad de la caja de texto TCantidad y ejecuta la función cambioPesetas.
        /// </summary>
        /// <param name="sender">Lanza el evento del botón BCambioEnPesetas</param>
        /// <param name="e">Sin uso</param>
        private void BCambioEnPesetas_Click(object sender, EventArgs e)
        {
            double cantidadEuros, resultadoPesetas;

            cantidadEuros = double.Parse(TCantidad.Text);

            resultadoPesetas = cambioPesetas(cantidadEuros);

            MessageBox.Show("El cambio son: " + resultadoPesetas + "ptas.");
        }
    }
}
