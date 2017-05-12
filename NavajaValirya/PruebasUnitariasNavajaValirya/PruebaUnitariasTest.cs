using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace PruebasUnitariasNavajaValirya
{
    /// <summary>
    /// Realiza las pruebas Unitarias a la Aplicación 1 CambioDivisa
    /// </summary>
    [TestClass]
    public class PruebaUnitariasTest
    {
        [TestClass]
        public class PruebaUnitariasCambioDivisa
        {
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
        
        [TestClass]
        public class PruebaUnitariasDisposicionEfectivo
        {
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
    }
}
