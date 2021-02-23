using System;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, nota3, prom;

            Console.Title = "Solicitud de datos";
            Console.WriteLine("Ingresa 3 notas a continuación:");

            Console.Write("1. ");
            nota1 = double.Parse(Console.ReadLine());
            Console.Write("2. ");
            nota2 = double.Parse(Console.ReadLine());
            Console.Write("3. ");
            nota3 = double.Parse(Console.ReadLine());

            prom = (nota1 + nota2 + nota3) / 3;

            Console.Title = "Presentación de resultados";
            if (prom >= 7) {
                Console.WriteLine("Promocionado");
            }
            else {
                if (prom >= 4)
                {
                    Console.WriteLine("Regular");
                }
                else
                {
                    Console.WriteLine("Reprobado");
                }
            }
            Console.ReadLine();
        }
    }
}
