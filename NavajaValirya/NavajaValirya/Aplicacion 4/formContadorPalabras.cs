using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;


namespace NavajaValirya.ContadorPalabras
{
    /// <summary>
    /// Clase formulario que ejecuta la aplicación 4 que corresponde a ContadorPalabras.
    /// <para>Clase que cuenta las palabras diferentes que hay en una frase y las muestra ordenadas alfabeticamente.</para>
    /// </summary>
    public partial class formContadorPalabras : Form
    {
        /// <summary>
        /// Inicializa los componentes del Formulario ContadorPalabras.
        /// </summary>
        public formContadorPalabras()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Lee la frase de la caja de texto TCantidad y muestra el resultado de la función mostrarPalabrasCantidades en un mensaje ambas contenidasen la Clase ContadorPalabrasLogica.
        /// </summary>
        /// <param name="sender">Lanza el evento el botón BContadorPalabras</param>
        /// <param name="e">Sin uso</param>   
        private void BContadorPalabras_Click(object sender, EventArgs e)
        {
            string frase;
            ContadorPalabrasLogica OPalabrasContadas = new ContadorPalabrasLogica();

            frase = TFrase.Text;

            if (String.IsNullOrEmpty(frase))
            {
                MessageBox.Show("La caja de texto está vacía, por favor, introduzca una frase.");
            }

            else
            {
                OPalabrasContadas.leerPalabras(frase);

                MessageBox.Show(OPalabrasContadas.mostrarPalabrasCantidades(OPalabrasContadas.palabrasOrdenadas, OPalabrasContadas.cantidadPalabras));
            }            

            OPalabrasContadas.palabrasOrdenadas.Clear();
            OPalabrasContadas.cantidadPalabras.Clear();
        }
    }
}
