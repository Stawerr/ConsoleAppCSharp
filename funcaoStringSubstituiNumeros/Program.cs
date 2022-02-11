using System;

namespace funcaoStringSubstituiNumeros
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
                Console.WriteLine("São todos numeros");
            }
            else
            {
                Console.WriteLine("Não são todos numeros");
            }
            
        }

        private static bool funcaoNumeros(string n)
        {

            foreach (char character in n)
            {
                if (character < '0' || character > '9')
                    return false;
            }

            return true;
        }
    }
}
