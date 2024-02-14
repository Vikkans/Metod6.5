using System;

namespace forratinite
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett ord");
            string ord1 = Console.ReadLine();
            Console.WriteLine("Skriv in ett till ord");
            string ord2 = Console.ReadLine();

            Console.WriteLine(Längst(ord1, ord2));

            


        }

        static string Längst(string ord1, string ord2)
        {
            if (ord1.Length > ord2.Length)
            {
                return ord1;
            }

            if (ord1.Length < ord2.Length)
            {
                return ord2;
            }
            else
            {
                return ord1;
            }

        }
          
    }
}