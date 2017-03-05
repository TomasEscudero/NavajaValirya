using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavajaValirya.FrasePalindromica
{
    /// <summary>
    /// Clase formulario que ejecuta la aplicación 3 que corresponde a FrasePalindromica
    /// </summary>
    public partial class formFrasePalindromica : Form
    {
        /// <summary>
        /// Formulario FrasePalindromica
        /// </summary>
        public formFrasePalindromica()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Función esPalindromo.
        /// <para>Analiza una frase y muestra si es palindrómica o no.</para>
        /// </summary>
        /// <param name="frase">El parámetro <paramref name="frase"/> es la secuencia de carácteres que se quiere analizar.</param>
        /// <remarks>Se pueden introducir letras, números y demás carácteres.</remarks>
        /// <returns name="palindromo">Devuelve el boleano <ref name="palindromo"/>.</returns>
        /// <value><ref name="palindromo"/> toma el valor TRUE si la frase es palindromica o FALSE si no lo es.</value>
        public bool esPalindromo(string frase)
        {
            int i, caracteres;
            bool palindromo;

            i = 0;
            caracteres = frase.Length - 1;
            palindromo = true;

            while (i < caracteres && palindromo == true)
            {
                while (frase[i] == ' ')
                {
                    i++;
                }

                while (frase[caracteres] == ' ')
                {
                    caracteres--;
                }

                if (frase[i] != frase[caracteres])
                {
                    palindromo = false;
                }
                else
                {
                    i++;
                    caracteres--;
                }

            }

            return palindromo;
        }

        /// <summary>
        /// Lee la frase de la caja de texto TFrase y ejecuta la función esPalindromo.
        /// </summary>
        /// <param name="sender">Lanza el evento del botón BPalindromica</param>
        /// <param name="e">Sin uso</param>
        private void BPalindromica_Click(object sender, EventArgs e)
        {
            string frase;
            bool palindromo;

            frase = TFrase.Text;
            palindromo = esPalindromo(frase);

            if (palindromo == true)
            {
                MessageBox.Show("La frase es PALINDRÓMICA");
            }
            else
            {
                MessageBox.Show("La frase NO es PALINDRÓMICA");
            }
        }
    }
}
