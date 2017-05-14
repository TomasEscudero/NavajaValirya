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
            try
            {
                if (double.TryParse(TCantidad.Text, out cantidadPesetas))
                {
                    if (cantidadPesetas > 0)
                    {
                        resultadoEuros = CambioDivisaLogica.cambiarEuros(cantidadPesetas);
                        MessageBox.Show(CadenasTexto.ResultadoCambio + resultadoEuros + CadenasTexto.Euros);
                    }

                    else
                    {
                        MessageBox.Show(CadenasTexto.ValorIncorrectoCambioDivisa);
                    }
                }

                else
                {
                    MessageBox.Show(CadenasTexto.ValorIncorrectoCambioDivisa);
                }
            }

            catch (Exception ExCambioEnEuros)
            {
                MessageBox.Show(CadenasTexto.ErrorException + ExCambioEnEuros.Message);
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
            try
            {
                if (double.TryParse(TCantidad.Text, out cantidadEuros))
                {
                    if (cantidadEuros > 0)
                    {
                        resultadoPesetas = CambioDivisaLogica.cambiarPesetas(cantidadEuros);
                        MessageBox.Show(CadenasTexto.ResultadoCambio + resultadoPesetas + CadenasTexto.Pesetas);
                    }

                    else
                    {
                        MessageBox.Show(CadenasTexto.ValorIncorrectoCambioDivisa);

                    }
                }

                else
                {
                    MessageBox.Show(CadenasTexto.ValorIncorrectoCambioDivisa);
                }
            }

            catch (Exception ExCambioEnPesetas)
            {
                MessageBox.Show(CadenasTexto.ErrorException + ExCambioEnPesetas.Message);
            }
        }
    }
}
