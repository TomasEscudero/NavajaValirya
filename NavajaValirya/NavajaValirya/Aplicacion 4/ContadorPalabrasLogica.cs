using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

/// <summary>
/// Namespace de la Clase ContadorPalabrasLoica del proyecto NavajaValirya.
/// </summary>
namespace NavajaValirya.ContadorPalabras
{
    /// <summary>
    /// Clase que ejecuta los métodos necesarios para la aplicación 4 que corresponde a ContadorPalabras.
    /// <para>Clase que cuenta las palabras diferentes que hay en una frase y las muestra ordenadas alfabeticamente.</para>
    /// </summary>
    public class ContadorPalabrasLogica
    {
        /// <summary>
        /// Lista donde se añadirán las palabras.
        /// <para>Lista donde se añadirán las diferentes palabras que aparecen en la frase ordenadas alfabeticamente.</para>
        /// </summary>
        public ArrayList palabrasOrdenadas = new ArrayList();

        /// <summary>
        /// Lista donde se añadirán las cantidades de cada palabra.
        /// <para>Lista donde se añadirá las veces que aparece cada palabra, cada posición es la cantidad correpondiente a la palabra de la lista palabrasOrdenadas.</para>
        /// </summary>
        public ArrayList cantidadPalabras = new ArrayList();

        /// <summary>
        /// Función leerPalabras.
        /// <para>Recorre la frase y cuando obtiene una palabra llama a la función añadirPalabraCantidad para insertarla en la lista de palabras/>.</para>
        /// </summary>
        /// <param name="frase">El parámetro <paramref name="frase"/> es el conjunto de caracteres introducidos mediante la caja de texto.</param>
        /// <remarks>Siempre que encuentre un espacio seleccionará una palabra.</remarks>        
        public void leerPalabras(string frase)
        {
            int i;
            string palabra;

            palabra = "";

            i = 0;           

            while (i <= frase.Length)
            {               
                
                if (i > 0 && (i == frase.Length || (frase[i] == ' ' && frase[i - 1] != ' ' && i != frase.Length -1)))
                {
                    añadirPalabraCantidad(palabra, palabrasOrdenadas, cantidadPalabras);
                    palabra = "";
                }

                else
                {
                    if (frase[i] != ' ')
                    {
                        palabra = palabra + frase[i];
                    }
                }

                i++;
            }
        }
    

        /// <summary>
        /// Función añadirPalabrasCantidad.        
        /// <para>Añade la <paramref name="palabra"/> a la lista de palabras <ref name="palabrasOrdenadas"/> alfabeticamente y añade la cantidad de veces que aparece cada palabra en la lista de cantidades <ref name="cantidadPalabras"/>.</para>
        /// </summary>
        /// <param name="palabra">El parámetro <paramref name="palabra"/> es cada una de las palabras de la frase.</param>
        /// <param name="listaPalabras">El parámetro <paramref name="listaPalabras"/> es la lista donde se añaden las diferentes palabras.</param>
        /// <param name="listaCantidad">El parámetro <paramref name="listaCantidad"/> es la lista donde se añade la catidad de veces que aparece cada palabra.</param>
        /// <remarks>Si la palabra no esta en la lista de palabras <paramref name="listaPalabras"/> la añade, pero si existe suma 1 en la posicion correspondiente de la lista de cantidades <paramref name="listaCantidad"/>.</remarks>        
        private void añadirPalabraCantidad(string palabra, ArrayList listaPalabras, ArrayList listaCantidad)
        {
            int posicion;

            posicion = (posicionPalabra(listaPalabras, palabra));

            if (posicion == listaPalabras.Count)
            {
                listaPalabras.Add(palabra);

                listaCantidad.Add(1);
            }

            else
            {
                if (String.Compare((string)listaPalabras[posicion], palabra) == 0)
                {
                    listaCantidad[posicion] = (int)listaCantidad[posicion] + 1;
                }

                else
                {
                    if (palabra != "")
                    {
                        listaPalabras.Insert(posicion, palabra);

                        listaCantidad.Insert(posicion, 1);
                    }
                }

            }

        }

        /// <summary>
        /// Función posicionPalabra.
        /// <para>Compara las palabras de la lista de palabras <paramref name="listaPalabras"/> e indica la posición donde insertar el parámetro <paramref name="palabra"/> en la lista.</para>
        /// </summary>
        /// <param name="listaPalabras">El parámetro <paramref name="listaPalabras"/> es la lista de palabras donde busca el parámetro <paramref name="palabra"/>.</param>
        /// <param name="palabra">El parámetro <paramref name="palabra"/> es lo que utiliza para comparar en la <paramref name="listaPalabras"/> e indicar la posición a insertar.</param>
        /// <remarks>Si no hay palabras en la lista devolvera un 0.</remarks>
        /// <returns name="posicion">Devuelve la posicion donde insertar la palabra en la lista de palabras <paramref name="listaPalabras"/>.</returns>
        /// <value>Posicion donde insertar la palabra en la lista de palabras.</value>
        private int posicionPalabra(ArrayList listaPalabras, string palabra)
        {
            int i, busqueda, posicion;
            bool encontrada;

            i = 0;
            encontrada = false;

            while (i < listaPalabras.Count && encontrada == false)
            {
                busqueda = String.Compare((string)listaPalabras[i], palabra);

                if (busqueda >= 0)
                {
                    encontrada = true;
                }

                else
                {
                    i++;
                }
            }

            posicion = i;

            return posicion;
        }

        /// <summary>
        /// Función mostrarPalabrasCantidades.
        /// <para>Muestra las palabras de la lista de palabras <paramref name="listaPalabras"/> e indica la cantidad de cada una de ellas en la frase.</para>
        /// </summary>
        /// <param name="listaPalabras">El parámetro <paramref name="listaPalabras"/> es la lista de palabras diferentes que hay en la frase.</param>
        /// <param name="listaCantidad">El parámetro <paramref name="listaCantidad"/> es la lista de Cantidades que hay de cada palabra.</param>        
        /// <returns name="texto">Devuelve las palabras y las veces que aparecen en la frase.</returns>
        /// <value>Listado de palabras y las veces que aparecenen la frase.</value>
        public string mostrarPalabrasCantidades(ArrayList listaPalabras, ArrayList listaCantidad)
        {
            int i;
            string texto;

            texto = "El número de cada palabra diferente que hay en la frase es: \n";

            for (i = 0; i < listaPalabras.Count; i++)
            {
                texto = texto + listaPalabras[i] + " = " + listaCantidad[i] + "\n";
            }

            return texto;

        }
    }
}
