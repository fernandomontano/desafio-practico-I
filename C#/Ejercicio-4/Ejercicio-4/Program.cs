using System;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Número mayor";
            double num1, num2, num3;

            Console.WriteLine("Digite 3 números");
            Console.Write("1. ");
            num1 = double.Parse(Console.ReadLine());
            Console.Write("2. ");
            num2 = double.Parse(Console.ReadLine());
            Console.Write("3. ");
            num3 = double.Parse(Console.ReadLine());

            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine($"El número mayor es: {num1}");
            }
            else 
            {
                if (num2 > num3)
                {
                    Console.WriteLine($"El mayor número es: {num2}");
                }
                else
                {
                    Console.WriteLine($"El mayor número es: {num3}");
                }
            }

            Console.ReadKey();
        }
    }
}
