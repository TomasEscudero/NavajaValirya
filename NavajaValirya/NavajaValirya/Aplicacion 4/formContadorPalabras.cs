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
    public partial class formContadorPalabras : Form
    {
        public formContadorPalabras()
        {
            InitializeComponent();
        }

        ArrayList palabrasOrdenadas = new ArrayList();
        ArrayList cantidadPalabras = new ArrayList();

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

        public int ordenarPalabras(ArrayList listaPalabras, string palabra) //ordena palabras alfabeticamente devolviendo la posicion en la listaPalabras
        {
            int i, busqueda;
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

            return i;
        }

        public void añadirPalabraCantidad(string palabra, ArrayList listaPalabras, ArrayList listaCantidad)
        {
            int posicion;

            posicion = (ordenarPalabras(listaPalabras, palabra)); //encuentra en que posicion debe insertar la palabra ordenada alfabeticamente

            if (posicion == listaPalabras.Count)
            {
                listaPalabras.Add(palabra);

                listaCantidad.Add(1);
            }

            else
            {
                if (String.Compare((string)listaPalabras[posicion], palabra) == 0) // si la palabra  está en la listaPalabras
                {
                    listaCantidad[posicion] = (int)listaCantidad[posicion] + 1; //añade un +1 a en la posicion de la listaPalabras numeros
                }

                else // si la palabra NO esta en la listaPalabras
                {
                    listaPalabras.Insert(posicion, palabra); //añade la palabra en la posicion alfabeticamente

                    listaCantidad.Insert(posicion, 1); //añade 1 a la posicion donde ha insertado la palabra                    
                }

            }

        }

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

        private void BContadorPalabras_Click(object sender, EventArgs e)
        {
            string frase;

            frase = TFrase.Text;

            leerPalabras(frase);

            MessageBox.Show(mostrarPalabrasCantidades(palabrasOrdenadas, cantidadPalabras));
        }
    }
}
