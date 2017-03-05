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
    /// Clase formulario que ejecuta la aplicación 4 que corresponde a ContadorPalabras
    /// </summary>
    public partial class formContadorPalabras : Form
    {
        /// <summary>
        /// Formulario ContadorPalabras
        /// </summary>
        public formContadorPalabras()
        {
            InitializeComponent();
        }

        ArrayList palabrasOrdenadas = new ArrayList();
        ArrayList cantidadPalabras = new ArrayList();

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
                if (i == frase.Length || frase[i] == ' ') 
                {
                    añadirPalabraCantidad(palabra, palabrasOrdenadas, cantidadPalabras);
                    palabra = "";
                }

                else
                {
                    palabra = palabra + frase[i]; 
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
        public void añadirPalabraCantidad(string palabra, ArrayList listaPalabras, ArrayList listaCantidad)
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
                    listaPalabras.Insert(posicion, palabra); 

                    listaCantidad.Insert(posicion, 1);                    
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
        public int posicionPalabra(ArrayList listaPalabras, string palabra) 
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

        /// <summary>
        /// Lee la frase de la caja de texto TCantidad y muestra el resultado de la función mostrarPalabrasCantidades en un mensaje.
        /// </summary>
        /// <param name="sender">Lanza el evento el botón BContadorPalabras</param>
        /// <param name="e">Sin uso</param>   
        private void BContadorPalabras_Click(object sender, EventArgs e)
        {
            string frase;

            frase = TFrase.Text;

            leerPalabras(frase);

            MessageBox.Show(mostrarPalabrasCantidades(palabrasOrdenadas, cantidadPalabras));
        }
    }
}
