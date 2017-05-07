using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Namespace de la Clase DisposicionEfectivoLogica del proyecto NavajaValirya.
/// </summary>
namespace NavajaValirya.DisposicionEfectivo
{
    /// <summary>
    /// Clase que ejecuta los métodos necesarios para la aplicación 2 que corresponde a DisposicionEfectivo.
    /// <para>Clase que devuelve el menor número de billetes y monedas posible.</para>
    /// </summary>
    public class DisposicionEfectivoLogica
    {
        /// <summary>
        /// Función disponerEfectivo.
        /// <para>Devuelve la cantidad de billetes y monedas más efectiva.</para>
        /// </summary>
        /// <param name="cantidadPesetas">El valor del parámetro <paramref name="cantidadPesetas"/> es la cantidad de pesetas que se quiere entregar de manera más efectiva.</param>
        /// <remarks>Siempre intentará entregar el mínimo número de billetes y monedas.</remarks>
        /// <returns name="disposicionFinal">Devuelve la <ref name="disposicionFinal"/>, que es el menor número de billetes y monedas posible.</returns>
        /// <value>Cantidad de billetes y monedas.</value>
        public string disponerEfectivo(int cantidadPesetas)
        {
            int cantidadEfectivo, billeteMoneda;
            string disposicionFinal;

            cantidadEfectivo = cantidadPesetas;
            disposicionFinal = "La disposición es: ";

            if (cantidadEfectivo >= 10000)
            {
                billeteMoneda = cantidadEfectivo / 10000;

                cantidadEfectivo = cantidadEfectivo % 10000;

                disposicionFinal = disposicionFinal + "\n" + "Entregar " + billeteMoneda + " billete/s de 10.000 pts.";
            }

            if (cantidadEfectivo >= 5000)
            {
                billeteMoneda = cantidadEfectivo / 5000;

                cantidadEfectivo = cantidadEfectivo % 5000;

                disposicionFinal = disposicionFinal + "\n" + "Entregar " + billeteMoneda + " billete/s de 5.000 pts.";
            }

            if (cantidadEfectivo >= 2000)
            {
                billeteMoneda = cantidadEfectivo / 2000;

                cantidadEfectivo = cantidadEfectivo % 2000;

                disposicionFinal = disposicionFinal + "\n" + "Entregar " + billeteMoneda + " billete/s de 2.000 pts.";
            }

            if (cantidadEfectivo >= 1000)
            {
                billeteMoneda = cantidadEfectivo / 1000;

                cantidadEfectivo = cantidadEfectivo % 1000;

                disposicionFinal = disposicionFinal + "\n" + "Entregar " + billeteMoneda + " billetea/s de 1.000 pts.";
            }

            if (cantidadEfectivo >= 500)
            {
                billeteMoneda = cantidadEfectivo / 500;

                cantidadEfectivo = cantidadEfectivo % 500;

                disposicionFinal = disposicionFinal + "\n" + "Entregar " + billeteMoneda + " moneda/s de 500 pts.";
            }

            if (cantidadEfectivo >= 100)
            {
                billeteMoneda = cantidadEfectivo / 100;

                cantidadEfectivo = cantidadEfectivo % 100;

                disposicionFinal = disposicionFinal + "\n" + "Entregar " + billeteMoneda + " moneda/s de 100 pts.";
            }

            if (cantidadEfectivo >= 50)
            {
                billeteMoneda = cantidadEfectivo / 50;

                cantidadEfectivo = cantidadEfectivo % 50;

                disposicionFinal = disposicionFinal + "\n" + "Entregar " + billeteMoneda + " moneda/s de 50 pts.";
            }

            if (cantidadEfectivo >= 25)
            {
                billeteMoneda = cantidadEfectivo / 25;

                cantidadEfectivo = cantidadEfectivo % 25;

                disposicionFinal = disposicionFinal + "\n" + "Entregar " + billeteMoneda + " moneda/s de 25 pts.";
            }

            if (cantidadEfectivo >= 10)
            {
                billeteMoneda = cantidadEfectivo / 10;

                cantidadEfectivo = cantidadEfectivo % 10;

                disposicionFinal = disposicionFinal + "\n" + "Entregar " + billeteMoneda + " moneda/s de 10 pts.";
            }

            if (cantidadEfectivo >= 5)
            {
                billeteMoneda = cantidadEfectivo / 5;

                cantidadEfectivo = cantidadEfectivo % 5;

                disposicionFinal = disposicionFinal + "\n" + "Entregar " + billeteMoneda + " moneda/s de 5 pts.";
            }

            if (cantidadEfectivo >= 1)
            {
                billeteMoneda = cantidadEfectivo / 1;

                cantidadEfectivo = cantidadEfectivo % 1;

                disposicionFinal = disposicionFinal + "\n" + "Entregar " + billeteMoneda + " moneda/s de 1 pts.";
            }

            return disposicionFinal;
        }
    }
}
