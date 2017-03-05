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
    public partial class formFrasePalindromica : Form
    {
        public formFrasePalindromica()
        {
            InitializeComponent();
        }

        bool esPalindromo(string frase)
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
