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
/// Namespace de la Aplicación 1 del proyecto NavajaValirya.
/// </summary>
namespace NavajaValirya.CambioDivisa
{
    /// <summary>
    /// Clase formulario que ejecuta la aplicación 1 que corresponde a CambioDivisa.
    /// <para>Clase que realiza el cambio entre las divisas Euros y Pesetas y viceversa.</para>
    /// </summary>
    public partial class formCambioDivisa : Form
    {
        /// <summary>
        /// Inicializa los componentes del Formulario CambioDivisa.
        /// </summary>
        public formCambioDivisa()
        {
            InitializeComponent();
        }
        
    /// <summary>
    /// Lee la cantidad de la caja de texto TCantidad y ejecuta la función estática cambiarEuros de la clase CambioDivisaLogica.
    /// </summary>
    /// <param name="sender">Lanza el evento el botón BCambioEuros</param>
    /// <param name="e">Sin uso</param>        
    private void BCambioEnEuros_Click(object sender, EventArgs e)
    {
        double cantidadPesetas, resultadoEuros;

        cantidadPesetas = 0;
        resultadoEuros = 0;

        if (double.TryParse(TCantidad.Text, out cantidadPesetas))
        {
            resultadoEuros = CambioDivisaLogica.cambiarEuros(cantidadPesetas);
            MessageBox.Show("El cambio son: " + resultadoEuros + "€.");
        }

        else
        {
            MessageBox.Show("No ha introducido valor correcto, por favor, introduzca un número.");
        }

    }

    /// <summary>
    /// Lee la cantidad de la caja de texto TCantidad y ejecuta la función estática cambiarPesetas de la clase CambioDivisaLogica.
    /// </summary>
    /// <param name="sender">Lanza el evento del botón BCambioEnPesetas</param>
    /// <param name="e">Sin uso</param>
    private void BCambioEnPesetas_Click(object sender, EventArgs e)
    {
        double cantidadEuros, resultadoPesetas;

        cantidadEuros = 0;
        resultadoPesetas = 0;

        if (double.TryParse(TCantidad.Text, out cantidadEuros))
        {
            resultadoPesetas = CambioDivisaLogica.cambiarPesetas(cantidadEuros);
            MessageBox.Show("El cambio son: " + resultadoPesetas + "ptas.");
        }

        else
        {
            MessageBox.Show("No ha introducido un valor correcto, por favor, introduzca un número.");
        }


    }
    }
}
