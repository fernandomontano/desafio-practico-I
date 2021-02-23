using System;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Recolección de datos";
            double numeroUno, numeroDos, numeroTres, numeroCuatro, suma, multiplicacion;

            Console.WriteLine("Digite 4 numeros");

            Console.Write("1. ");
            numeroUno = double.Parse(Console.ReadLine());
            Console.Write("2. ");
            numeroDos = double.Parse(Console.ReadLine());
            Console.Write("3. ");
            numeroTres = double.Parse(Console.ReadLine());
            Console.Write("4. ");
            numeroCuatro = double.Parse(Console.ReadLine());

            Console.Title = "Presentación de resultados";
            suma = numeroUno + numeroDos;
            multiplicacion = numeroTres * numeroCuatro;

            Console.WriteLine($"La suma de los primeros dos números ({numeroUno} + {numeroDos}) es: {suma}. Y, el producto de los otros dos ({numeroTres} * {numeroCuatro}) es {multiplicacion}"); 
            Console.ReadKey();
        }
    }
}
