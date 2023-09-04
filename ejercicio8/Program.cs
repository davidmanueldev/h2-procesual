// Introducir n números hasta que se ingrese el 9 y mostrar su sumatoria

using System;

namespace ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, sumatoria = 0;
            Console.WriteLine("Ingrese un numero: ");
            n = int.Parse(Console.ReadLine());
            while (n != 9)
            {
                sumatoria += n;
                Console.WriteLine("Ingrese un numero: ");
                n = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("La sumatoria es: " + sumatoria);
        }
    }
}