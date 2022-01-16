using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _159
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, aux;
            string sir;
            n = int.Parse(Console.ReadLine());
            sir = Console.ReadLine();
            string[] v = sir.Split(' ');
            for (i = 0; i < v.Length; i++)
            {
                Console.Write(v[i] + ' ');
                aux = Convert.ToInt32(v[i]);
                if (aux % 2 == 0)
                    Console.Write(Convert.ToString(aux * 2) + ' ');
            }
            Console.ReadKey();
        }
    }
}