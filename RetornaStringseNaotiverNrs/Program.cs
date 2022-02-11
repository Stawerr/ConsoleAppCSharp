using System;

namespace RetornaStringseNaotiverNrs
{
    class Program
    {
        static void Main(string[] args)
        {
            string n;

            Console.WriteLine("Introduza a palavra");
            n = Console.ReadLine();

            bool regresso = funcaoNumeros(n);
            if (regresso == true)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }

        }

        private static bool funcaoNumeros(string n)
        {

            foreach (char character in n)
            {
                if (character < 'a' || character > 'z')
                    return false;
            }
            return true;
        }
    }
}
