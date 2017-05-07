using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Namespace de la Clase CambioDivisaLogica del proyecto NavajaValirya.
/// </summary>
namespace NavajaValirya.CambioDivisa
{
    /// <summary>
    /// Clase que ejecuta los métodos necesarios para la aplicación 1 que corresponde a CambioDivisa.
    /// <para>Clase que realiza el cambio entre las divisas Euros y Pesetas y viceversa.</para>
    /// </summary>
    public class CambioDivisaLogica
    {
        /// <summary>
        /// Es la constante para realizar el cambio entre las divisas.
        /// </summary>
        /// <value>1 Euro = 166.386 pesetas</value>
        const double kVALOR = 166.386;

        /// <summary>
        /// Función cambiarEuros.
        /// <para>Realiza el cambio de Euros a Pesetas.</para>
        /// </summary>
        /// <param name="cantidadEuros">El valor del parámetro <paramref name="cantidadEuros"/> es la cantidad de euros que se quiere cambiar a pesetas.</param>
        /// <remarks>Se pueden introducir cantidades con céntimos de euro.</remarks>
        /// <returns name="resultadoCambio">Devuelve la <paramref name="cantidadEuros"/> cambiada en pesetas.</returns>
        /// <value>El dinero cambiado a pesetas.</value>
        public static double cambiarEuros(double cantidadEuros)
        {
            double resultadoCambio;

            resultadoCambio = cantidadEuros / kVALOR;

            return resultadoCambio;
        }

        /// <summary>
        /// Función cambiarPesetas.
        /// <para>Realiza el cambio de Pesetas a Euros.</para>
        /// </summary>
        /// <param name="cantidadPesetas">El valor del parámetro <paramref name="cantidadPesetas"/> es la cantidad de pesetas que se quiere cambiar a euros.</param>
        /// <remarks>No se pueden introducir cantidades con decimales ya que las pesetas no tenían centimos.</remarks>
        /// <returns name="resultadoCambio">Devuelve la <paramref name="cantidadPesetas"/> cambiada en euros.</returns>
        /// <value>El dinero cambiado a euros.</value>
        public static double cambiarPesetas(double cantidadPesetas)
        {
            double resultadoCambio;

            resultadoCambio = cantidadPesetas * kVALOR;

            return resultadoCambio;
        }
    }
}
