using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

/// <summary>
/// Namespace de la Clase PruebasUnitariasNavajaValirya del proyecto NavajaValirya.
/// </summary>
namespace PruebasUnitariasNavajaValirya
{
    /// <summary>
    /// Clase de pruebas que comprueba las aplicaciones contenidas en el proyecto NavajaValirya.
    /// </summary>
    [TestClass]
    public class PruebaUnitariasTest
    {
        /// <summary>
        /// Clase de pruebas que comprueba la aplicación 1 que corresponde a CambioDivisa.
        /// <para>Aplicación que realiza el cambio entre las divisas Euros y Pesetas y viceversa.</para>
        /// </summary>
        [TestClass]
        public class PruebaUnitariasCambioDivisa
        {
            /// <summary>
            /// Método de pruebas que comprueba si realiza correctamente el cambio entre las divisas Pesetas y Euros.            
            /// </summary>
            [TestMethod]
            public void TestCambiarEuros()
            {
                //Escenario de Prueba
                double cantidadPesetas = 10000;
                double resultadoEsperado = 60.101210438378232;
                double resultadoObtenido = 0;

                //Acción a Probar
                resultadoObtenido = NavajaValirya.CambioDivisa.CambioDivisaLogica.cambiarEuros(cantidadPesetas);

                //Afirmación de la Prueba
                Assert.AreEqual(resultadoEsperado, resultadoObtenido);
            }

            /// <summary>
            /// Método de pruebas que comprueba si realiza correctamente el cambio entre las divisas Euros y Pesetas.            
            /// </summary>
            [TestMethod]
            public void TestCambiarPesetas()
            {
                //Escenario de Prueba
                double cantidadEuros = 6;
                double resultadoEsperado = 998.316;
                double resultadoObtenido = 0;

                //Acción a Probar
                resultadoObtenido = NavajaValirya.CambioDivisa.CambioDivisaLogica.cambiarPesetas(cantidadEuros);

                //Afirmación de la Prueba
                Assert.AreEqual(resultadoEsperado, resultadoObtenido);
            }
        }

        /// <summary>
        /// Clase de pruebas que comprueba la aplicación 2 que corresponde a DisposicionEfectivo.
        /// <para>Aplicación que devuelve el menor número de billetes y monedas posible.</para>
        /// </summary>
        [TestClass]
        public class PruebaUnitariasDisposicionEfectivo
        {
            /// <summary>
            /// Método de pruebas que comprueba si realiza correctamente la devolución con el menor nuúmero de billetes y monedas.            
            /// </summary>
            [TestMethod]
            public void TestDisposicionEfectivo()
            {
                //Escenario de Prueba
                NavajaValirya.DisposicionEfectivo.DisposicionEfectivoLogica OdisposicionEfectivo = new NavajaValirya.DisposicionEfectivo.DisposicionEfectivoLogica();
                int cantidadPesetas = 18691;
                string resultadoEsperado = "La disposición es: \nEntregar 1 billete/s de 10.000 pts.\n" +
                                            "Entregar 1 billete/s de 5.000 pts.\n" +
                                            "Entregar 1 billete/s de 2.000 pts.\n" +
                                            "Entregar 1 billetea/s de 1.000 pts.\n" +
                                            "Entregar 1 moneda/s de 500 pts.\n" +
                                            "Entregar 1 moneda/s de 100 pts.\n" +
                                            "Entregar 1 moneda/s de 50 pts.\n" +
                                            "Entregar 1 moneda/s de 25 pts.\n" +
                                            "Entregar 1 moneda/s de 10 pts.\n" +
                                            "Entregar 1 moneda/s de 5 pts.\n" +
                                            "Entregar 1 moneda/s de 1 pts.";
                string resultadoObtenido = "";

                //Acción a Probar
                resultadoObtenido = OdisposicionEfectivo.disponerEfectivo(cantidadPesetas);

                //Afirmación de la Prueba
                Assert.AreEqual(resultadoEsperado, resultadoObtenido);
            }
        }

        /// <summary>
        /// Clase de pruebas que comprueba la aplicación 3 que corresponde a FrasePalindromica.
        /// <para>Aplicación que analiza una frase y muestra si es palindrómica o no.</para>
        /// </summary>
        [TestClass]
        public class PruebaUnitariasFrasePalindromica
        {
            /// <summary>
            /// Método de pruebas que comprueba si analiza correctamente una frase y muestra que si es palindrómica.            
            /// </summary>
            [TestMethod]
            public void TestFrasePalindromicaCorrecta()
            {
                //Escenario de Prueba
                string frase = "dabale arroz a la zorra el abad";
                bool resultadoEsperado = true;
                bool resultadoObtenido = true;

                //Acción a Probar
                resultadoObtenido = NavajaValirya.FrasePalindromica.FrasePalindromicaLogica.esPalindromo(frase);

                //Afirmación de la Prueba
                Assert.AreEqual(resultadoEsperado, resultadoObtenido);
            }

            /// <summary>
            /// Método de pruebas que comprueba si analiza correctamente una frase y muestra que no es palindrómica.            
            /// </summary>
            [TestMethod]
            public void TestFrasePalindromicaIncorrecta()
            {
                //Escenario de Prueba
                string frase = "canta la rana";
                bool resultadoEsperado = false;
                bool resultadoObtenido = false;

                //Acción a Probar
                resultadoObtenido = NavajaValirya.FrasePalindromica.FrasePalindromicaLogica.esPalindromo(frase);

                //Afirmación de la Prueba
                Assert.AreEqual(resultadoEsperado, resultadoObtenido);
            }
        }

        /// <summary>
        /// Clase de pruebas que comprueba la aplicación 4 que corresponde a ContadorPalabras.
        /// <para>Aplicación que cuenta las palabras diferentes que hay en una frase y las muestra ordenadas alfabeticamente.</para>
        /// </summary>
        [TestClass]
        public class PruebaUnitariasContadorPalabras
        {
            /// <summary>
            /// Método de pruebas que comprueba si analiza correctamente una frase y muestra la cantidad de palabras diferentes ordenadas alfabeticamente.            
            /// </summary>
            [TestMethod]
            public void TestContadorPalabras()
            {
                //Escenario de Prueba
                NavajaValirya.ContadorPalabras.ContadorPalabrasLogica OPalabrasContadas = new NavajaValirya.ContadorPalabras.ContadorPalabrasLogica();                
                string frase = "   perro perro   perro  gato   gato oso   ";
                string resultadoEsperado = "El número de cada palabra diferente que hay en la frase es: \n" + "gato = 2\n" + "oso = 1\n" + "perro = 3\n";
                string resultadoObtenido = "";

                //Acción a Probar
                OPalabrasContadas.leerPalabras(frase);
                resultadoObtenido = OPalabrasContadas.mostrarPalabrasCantidades(OPalabrasContadas.palabrasOrdenadas, OPalabrasContadas.cantidadPalabras);

                //Afirmación de la Prueba
                Assert.AreEqual(resultadoEsperado, resultadoObtenido);
            }
        }
    }
}
