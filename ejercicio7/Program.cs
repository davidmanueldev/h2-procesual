// Escribir un programa que imprima la suma de todos los números que van del 1 al 100.

using System;

namespace ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumatoria = 0;
            for (int i = 1; i <= 100; i++)
            {
                sumatoria += i;
            }
            Console.WriteLine("La sumatoria es: " + sumatoria);
        }
    }
}