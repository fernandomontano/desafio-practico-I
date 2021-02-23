using System;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Alumnos: Fernando Josué Montano González MG210111
                       José Carlos Sequeira Alvarado SA211247*/

            double precio, total;
            int cantidad;

            Console.Title = "Solicitud de datos";

            Console.WriteLine("Ingresa el precio del artículo que deseas comprar.");
            Console.Write("$");
            precio = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa la cantidad de artículos que comprarás");
            cantidad = Int32.Parse(Console.ReadLine());

            total = Math.Round((precio * cantidad),2);

            Console.Title = "Presentación de datos";
            Console.WriteLine($"Pagarás ${total} por {cantidad} articulo(s) que cuestan ${precio} cada uno.");

            Console.ReadLine();
        }
    }
}
