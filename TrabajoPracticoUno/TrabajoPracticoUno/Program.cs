using System;

namespace TrabajoPracticoUno
{
    #region Enunciado:
    /// <summary>
    /// 
    /// Crear una aplicación para obtener el factorial de un número.
    /// El factorial del número entero positivo n, denotado n!, se define como el producto de todos los números enteros positivos menores o iguales que n.
    ///
    /// Utilizar el depurador y obtener valores parciales para un cálculo solicitado.
    /// Restricciones:
    ///
    ///   ● La resolución se realiza en la misma clase Program
    ///   ● La lógica debe estar en un método independiente qué cumpla con la siguiente firma: 
    ///         decimal NombreDelMetodo (intparametro)
    ///         
    /// </summary>
    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            int aFactorear = 5;

            Console.WriteLine($"Factorial de {aFactorear}: {Factorial(aFactorear)}");
        }

        static decimal Factorial(int aFactorear)
        {
            int productoria = 1;

            for (int i = 1; i <= aFactorear; i++)
            {
                productoria = i * productoria;
            }

            return productoria;
        }
    }
}
