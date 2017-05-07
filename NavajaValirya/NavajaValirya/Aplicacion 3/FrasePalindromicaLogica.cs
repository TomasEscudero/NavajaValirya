using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Namespace de la Clase DisposicionEfectivoLogica del proyecto NavajaValirya.
/// </summary>
namespace NavajaValirya.FrasePalindromica
{
    /// <summary>
    /// Clase que ejecuta los métodos necesarios para la aplicación 3 que corresponde a FrasePalindromica.
    /// <para>Clase que analiza una frase y muestra si es palindrómica o no.</para>
    /// </summary>
    class FrasePalindromicaLogica
    {
        /// <summary>
        /// Función esPalindromo.
        /// <para>Analiza una frase y muestra si es palindrómica o no.</para>
        /// </summary>
        /// <param name="frase">El parámetro <paramref name="frase"/> es la secuencia de carácteres que se quiere analizar.</param>
        /// <remarks>Se pueden introducir letras, números y demás carácteres.</remarks>
        /// <returns name="palindromo">Devuelve el boleano <ref name="palindromo"/>.</returns>
        /// <value><ref name="palindromo"/> toma el valor TRUE si la frase es palindromica o FALSE si no lo es.</value>
        public static bool esPalindromo(string frase)
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
    }
}
