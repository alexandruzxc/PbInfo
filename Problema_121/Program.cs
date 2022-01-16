using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_121
{
    class Program
    {
        static void Main(string[] args)
        {
            long x; 
            long max = 0;
            long nrap = 0;
            long aux;

            x = long.Parse(Console.ReadLine());
            aux = x;

            if (x == 0)
                Console.WriteLine("Introduceti un numar mai mare decat 0");
            else 
            {
                while (x != 0)
                {
                    if (x % 10 > max)
                    {
                        max = x % 10;                       
                    }
                    x = x / 10;
                }
                while (aux != 0)
                {
                    if ((aux % 10) == max) nrap++;
                    aux = aux / 10;
                }
                Console.WriteLine("Cifra maxima este: ");
                Console.WriteL(max) ; 
                Console.WriteLine("Si numarul ei de aparitii este : ");
                Console.WriteL(nrap);
                Console.ReadKey();
            }

        }
    }
}
