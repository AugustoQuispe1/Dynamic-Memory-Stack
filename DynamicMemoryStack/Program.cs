using System.Collections.Generic;
using System.Collections;
using System;

class Program
    {
    static void Main()
        {
        Stack<string> pilaDeCadenas = new Stack<string>();

        Console.WriteLine("Introduce cadenas (deja vacío para mostrar en orden inverso):");

        while (true)
            {
            Console.Write("Ingrese una cadena (o vacío para salir): ");
            string entrada = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(entrada))
                {
                break;
                }

            pilaDeCadenas.Push(entrada);
            }

        Console.WriteLine("Cadenas introducidas en orden inverso:");
        while (pilaDeCadenas.Count > 0)
            {
            string cadena = pilaDeCadenas.Pop();
            Console.WriteLine(cadena);
            }
        }
    }
