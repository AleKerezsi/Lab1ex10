using System;

namespace Lab1ex10
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Scrieti un program care sa va afisa suma cifrelor unui numar intreg citit de la tastatura. */

            Console.WriteLine("Introduceti x");
            int x = int.Parse(Console.ReadLine());

            int ultimaCifra = x % 10;
            int primaCifra = x / 10;
            int sumaCifrelor = ultimaCifra + primaCifra;
            Console.WriteLine("Suma cifrelor este: " + sumaCifrelor);

        }
    }
}
