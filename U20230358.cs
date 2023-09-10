﻿using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n----> Estructura de control selectivas en C# <----");
            Console.WriteLine("\n-----Opciones:");
            Console.WriteLine("\n1 - Determinar si el numero es positivo, negativo o igual a cero");
            Console.WriteLine("\n2 - Muestra fecha y hora actual");
            Console.WriteLine("\n3 - Determinar si puede votar y conducir legalmente");
            Console.WriteLine("\n4 - Determinar si el numero es par o impar");
            Console.WriteLine("\nElija una opcion:");
            Console.ForegroundColor = ConsoleColor.Red;
            int opcion = Convert.ToInt32(Console.ReadLine());

            if (opcion == 1){
                Console.WriteLine("\nIngrese un numero:");
                int numero = Convert.ToInt32(Console.ReadLine());
                if (numero > 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nSu numero es positivo.\n");
                }

                else if (numero < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nSu numero es negativo.\n");
                }

                else{
                     Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nSu numero es igual a cero.\n");
                }
            }

            else if (opcion == 2)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                DateTime fechaHora = DateTime.Now;
                Console.WriteLine("\nLa fecha y hora actual es: " + fechaHora + "\n");
            }

            else
            {
                switch (opcion)
                {
                    case 3:
                        Console.WriteLine("Ingrese su edad:");
                        int edad = Convert.ToInt32(Console.ReadLine());

                        if (edad >= 18)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nEres mayor de edad, puedes votar y conducir legalmente.\n");
                        }

                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\n No eres menor de edad, no puedes votar ni conducir legalmente.\n");  
                        }
                        break;

                        case 4:
                        Console.WriteLine("Ingrese un numero:");
                        int numero = Convert.ToInt32(Console.ReadLine());

                        if (numero % 2 == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nEl numero ingresado es par.\n");
                        }

                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nEl numero ingresado es impar.\n");  
                        }
                        break;
                    default:
                        Console.WriteLine("\nLa opcion no se encuentra.\n");
                        break;
                }
            }
            Console.ReadKey();
            Console.ResetColor();
        }
    }
}