using System;

namespace Ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string nombreUno, nombreDos, nombreTres;
                int cargoUno, cargoDos, cargoTres, masDeTrescientos = 0;
                double horasUno, horasDos, horasTres, salarioUno, salarioDos, salarioTres,
                    salarioTotalUno, salarioTotalDos, salarioTotalTres, afpUno, afpDos, afpTres,
                    isssUno, isssDos, isssTres, rentaUno, rentaDos, rentaTres, descuentoUno, descuentoDos, descuentoTres;

                Console.Title = "Recolección de datos";
                Console.WriteLine("A continuación, se solicitarán datos de 3 trabajadores.");
                Console.WriteLine("Cargo: digite '1' si es Gerente, '2' si es asistente, " +
                    "'3' si es secretario/a y '4' cumple otro cargo no mencionado. (sin los '')");

                Console.WriteLine("\nTrabajador 1:");
                Console.Write("Nombres y apellidos: ");
                nombreUno = Console.ReadLine();
                Console.Write("Cargo: ");
                cargoUno = Int32.Parse(Console.ReadLine());
                Console.Write("Horas trabajadas: ");
                horasUno = double.Parse(Console.ReadLine());
                if (horasUno <= 0)
                {
                    Console.WriteLine("Horas ingresadas no válidas");
                }
                else
                {
                    Console.WriteLine("\nTrabajador 2:");
                    Console.Write("Nombres y apellidos: ");
                    nombreDos = Console.ReadLine();
                    Console.Write("Cargo: ");
                    cargoDos = Int32.Parse(Console.ReadLine());
                    Console.Write("Horas trabajadas: ");
                    horasDos = double.Parse(Console.ReadLine());

                    if (horasDos <= 0)
                    {
                        Console.WriteLine("Horas ingresadas no válidas");
                    }
                    else
                    {
                        Console.WriteLine("\nTrabajador 3:");
                        Console.Write("Nombres y apellidos: ");
                        nombreTres = Console.ReadLine();
                        Console.Write("Cargo: ");
                        cargoTres = Int32.Parse(Console.ReadLine());
                        Console.Write("Horas trabajadas: ");
                        horasTres = double.Parse(Console.ReadLine());

                        if (horasTres <= 0)
                        {
                            Console.WriteLine("Horas ingresadas no válidas");
                        }
                        else
                        {
                            //Salario sin descuentos
                            if (horasUno > 160)
                            {
                                salarioUno = (160 * 9.75) + ((horasUno - 160) * 11.50);
                            }
                            else
                            {
                                salarioUno = (horasUno * 9.75);
                            }
                            if (horasDos > 160)
                            {
                                salarioDos = (160 * 9.75) + ((horasDos - 160) * 11.50);
                            }
                            else
                            {
                                salarioDos = (horasDos * 9.75);
                            }
                            if (horasTres > 160)
                            {
                                salarioTres = (160 * 9.75) + ((horasTres - 160) * 11.50);
                            }
                            else
                            {
                                salarioTres = (horasDos * 9.75);
                            }

                            afpUno = Math.Round((salarioUno * 0.0525), 2);
                            afpDos = Math.Round((salarioDos * 0.0525), 2);
                            afpTres = Math.Round((salarioTres * 0.0525), 2);

                            isssUno = Math.Round((salarioUno * 0.0688), 2);
                            isssDos = Math.Round((salarioDos * 0.0688), 2);
                            isssTres = Math.Round((salarioTres * 0.0688), 2);

                            rentaUno = Math.Round((salarioUno * 0.10), 2);
                            rentaDos = Math.Round((salarioDos * 0.10), 2);
                            rentaTres = Math.Round((salarioTres * 0.10), 2);

                            descuentoUno = Math.Round((afpUno + isssUno + rentaUno), 2);
                            descuentoDos = Math.Round((afpDos + isssDos + rentaDos), 2);
                            descuentoTres = Math.Round((afpTres + isssTres + rentaTres), 2);

                            salarioTotalUno = Math.Round((salarioUno - descuentoUno), 2);
                            salarioTotalDos = Math.Round((salarioDos - descuentoDos), 2);
                            salarioTotalTres = Math.Round((salarioTres - descuentoTres), 2);

                            if (cargoUno == 1 && cargoDos == 2 && cargoTres == 3)
                            {
                                Console.WriteLine("\nNO HAY BONO");
                            }
                            else
                            {
                                //Cargo 1
                                if (cargoUno == 1)
                                {
                                    salarioTotalUno = Math.Round((salarioTotalUno + (salarioTotalUno * 0.10)), 2);
                                }
                                else if (cargoUno == 2)
                                {
                                    salarioTotalUno = Math.Round((salarioTotalUno + (salarioTotalUno * 0.05)), 2);
                                }
                                else if (cargoUno == 3)
                                {
                                    salarioTotalUno = Math.Round((salarioTotalUno + (salarioTotalUno * 0.03)), 2);
                                }
                                else if (cargoUno == 4)
                                {
                                    salarioTotalUno = Math.Round((salarioTotalUno + (salarioTotalUno * 0.02)), 2);
                                }

                                // Cargo Dos
                                if (cargoDos == 1)
                                {
                                    salarioTotalDos = Math.Round((salarioTotalDos + (salarioTotalDos * 0.10)), 2);
                                }
                                else if (cargoDos == 2)
                                {
                                    salarioTotalDos = Math.Round((salarioTotalDos + (salarioTotalDos * 0.05)), 2);
                                }
                                else if (cargoDos == 3)
                                {
                                    salarioTotalDos = Math.Round((salarioTotalDos + (salarioTotalDos * 0.03)), 2);
                                }
                                else if (cargoDos == 4)
                                {
                                    salarioTotalDos = Math.Round((salarioTotalDos + (salarioTotalDos * 0.02)), 2);
                                }

                                // Cargo Tres
                                if (cargoTres == 1)
                                {
                                    salarioTotalTres = Math.Round((salarioTotalTres + (salarioTotalTres * 0.10)), 2);
                                }
                                else if (cargoTres == 2)
                                {
                                    salarioTotalTres = Math.Round((salarioTotalTres + (salarioTotalTres * 0.05)), 2);
                                }
                                else if (cargoTres == 3)
                                {
                                    salarioTotalTres = Math.Round((salarioTotalTres + (salarioTotalTres * 0.03)), 2);
                                }
                                else if (cargoTres == 4)
                                {
                                    salarioTotalTres = Math.Round((salarioTotalTres + (salarioTotalTres * 0.02)), 2);
                                }
                            }
                            Console.Title = "Presentación de resultados";
                            Console.WriteLine("\nTrabajador 1");
                            Console.WriteLine($"Nombre: {nombreUno}");
                            Console.WriteLine($"Descuentos: AFP: ${afpUno}, ISSS: ${isssUno}, Renta: ${rentaUno}");
                            Console.WriteLine($"Suma de descuentos: {descuentoUno}");
                            Console.WriteLine($"El sueldo líquido a pagarte es de: {salarioTotalUno}\n");

                            Console.WriteLine("Trabajador 2");
                            Console.WriteLine($"Nombre: {nombreDos}");
                            Console.WriteLine($"Descuentos: AFP: ${afpDos}, ISSS: ${isssDos}, Renta: ${rentaDos}");
                            Console.WriteLine($"Suma de descuentos: {descuentoDos}");
                            Console.WriteLine($"El sueldo líquido a pagarte es de: {salarioTotalDos}\n");

                            Console.WriteLine("Trabajador 3");
                            Console.WriteLine($"Nombre: {nombreTres}");
                            Console.WriteLine($"Descuentos: AFP: ${afpTres}, ISSS: ${isssTres}, Renta: ${rentaTres}");
                            Console.WriteLine($"Suma de descuentos: {descuentoTres}");
                            Console.WriteLine($"El sueldo líquido a pagarte es de: {salarioTotalTres}\n");

                            if (salarioTotalUno > salarioTotalDos && salarioTotalDos >= salarioTotalTres)
                            {
                                Console.WriteLine($"El empleado que más dinero gana es '{nombreUno}' y el empleado que menos " +
                                    $"dinero gana es '{nombreTres}'");
                            }
                            else if (salarioTotalUno > salarioTotalTres && salarioTotalTres >= salarioTotalDos)
                            {
                                Console.WriteLine($"El empleado que más dinero gana es '{nombreUno}' y el empleado que menos " +
                                    $"dinero gana es '{nombreDos}'");
                            }
                            else if (salarioTotalDos > salarioTotalUno && salarioTotalUno >= salarioTotalTres)
                            {
                                Console.WriteLine($"El empleado que más dinero gana es '{nombreDos}' y el empleado que menos " +
                                    $"dinero gana es '{nombreTres}'");
                            }
                            else if (salarioTotalDos > salarioTotalTres && salarioTotalTres >= salarioTotalUno)
                            {
                                Console.WriteLine($"El empleado que más dinero gana es '{nombreDos}' y el empleado que menos " +
                                    $"dinero gana es '{nombreUno}'");
                            }
                            else if (salarioTotalTres > salarioTotalDos && salarioTotalDos >= salarioTotalUno)
                            {
                                Console.WriteLine($"El empleado que más dinero gana es '{nombreTres}' y el empleado que menos " +
                                    $"dinero gana es '{nombreUno}'");
                            }
                            else
                            {
                                Console.WriteLine($"El empleado que más dinero gana es '{nombreTres}' y el empleado que menos " +
                                    $"dinero gana es '{nombreDos}'");
                            }

                            if (salarioTotalUno > 300)
                            {
                                masDeTrescientos++;
                            }
                            if(salarioTotalDos > 300)
                            {
                                masDeTrescientos++;
                            }
                            if(salarioTotalTres > 300)
                            {
                                masDeTrescientos++;
                            }
                            Console.WriteLine($"Hay {masDeTrescientos} empleados que ganan más de $300");
                        }
                    }
                }
                Console.ReadKey();
            }
            catch (FormatException)
            {
                Console.WriteLine("El tipo de dato ingresado no es aceptado.");
            }
        }
    }
}
