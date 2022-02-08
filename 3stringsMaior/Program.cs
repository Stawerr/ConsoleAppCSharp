using System;

namespace _3stringsMaior
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome, nome2, nome3;

            Console.WriteLine("Digite o seu nome ");
            nome = Console.ReadLine();

            Console.WriteLine("Digite o seu nome ");
            nome2 = Console.ReadLine();

            Console.WriteLine("Digite o seu nome ");
            nome3 = Console.ReadLine();

            maior(nome,nome2,nome3);
        }

        public static void maior(string nome, string nome2, string nome3)
        {
            int a = nome.Length;
            int b = nome2.Length;
            int c = nome3.Length;

            if (a>b && a > c)
            {
                Console.WriteLine("A que tem maior comprimento é a A");
            }
            else if (b > a && b > c)
            {
                Console.WriteLine("A que tem maior comprimento é a B");
            }
            else 
            {
                Console.WriteLine("A que tem maior comprimento é a C");
            }
        }
    }
}
