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
/// Namespace de la Aplicación 3 del proyecto NavajaValirya.
/// </summary>
namespace NavajaValirya.FrasePalindromica
{
    /// <summary>
    /// Clase formulario que ejecuta la aplicación 3 que corresponde a FrasePalindromica.
    /// <para>Clase que analiza una frase y resuelve si es palindrómica o no.</para>
    /// </summary>
    public partial class formFrasePalindromica : Form
    {
        /// <summary>
        /// Inicializa los componentes del Formulario FrasePalindromica.
        /// </summary>
        public formFrasePalindromica()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// Lee la frase de la caja de texto TFrase y ejecuta la función esPalindromo de la Clase FrasePalindromicaLogica.
        /// </summary>
        /// <param name="sender">Lanza el evento del botón BPalindromica</param>
        /// <param name="e">Sin uso</param>
        private void BPalindromica_Click(object sender, EventArgs e)
        {
            string frase;
            bool palindromo;

            frase = TFrase.Text;

            if (String.IsNullOrEmpty(frase))
            {
                MessageBox.Show("La caja de texto está vacía, por favor, introduzca una frase.");
            }
            else
            {
                palindromo = FrasePalindromicaLogica.esPalindromo(frase);

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
}
