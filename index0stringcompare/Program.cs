using System;

namespace index0stringcompare
{
    class Program
    {
        static void Main(string[] args)
        {
            string n;
            string m;

            Console.WriteLine("Introduza a palavra");
            n = Console.ReadLine();
            Console.WriteLine("Introduza outra palavra");
            m = Console.ReadLine();

            int regresso = funcaoNumeros(n,m);
            if (regresso <0)
            {
                Console.WriteLine("O primeiro é " + n);
            }
            else
            {
                Console.WriteLine("O primeiro é " + m);
            }
        }

        private static int funcaoNumeros(string n,string m)
        {
            int cont = 0;
            int valor;
            do
            {
                valor=n[cont].CompareTo(m[cont]);
                cont++;
            } while (valor == 0);

            return valor;
        }
    }
}