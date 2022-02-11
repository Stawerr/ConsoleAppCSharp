using System;

namespace StringPalidromo
{
    class Program
    {
        static void Main(string[] args)
        {
            string palavra;


            Console.WriteLine( "Digite uma palavra");
            palavra = Console.ReadLine();
            
            string novap = reverse(palavra);
            if (palavra == novap)
            {
                Console.WriteLine("São um Palindromo");
            }
            else
            {
                Console.WriteLine("Não é um Palindromo");
            }
        }

        private static string reverse(string palavra)
        {
            char[] charArray = palavra.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
