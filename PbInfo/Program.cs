using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PbInfo
{
    class Program
    {
        private static int Prim(int n)
        {
            int i, d = 0;
            if (n == 1)
                return 0;
            if (n % 2 == 0)
                return 0;
            for (i = 3; i <= n / 2; i = i + 2)
                if (n % i == 0)
                    d++;
            if (d == 0)
                return 1;
            return 0;
        }
        static void Main(string[] args)
        {
           
            Console.Write("N= ");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];

            Console.WriteLine("Introduceti elementele vectorului: ");
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
               
            }
            Array.Sort(v);

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(v[i]+ ' ');
            }






        }
    }


    // declaring and initializing the array
    //int[] arr = new int[] { 1, 9, 6, 7, 5, 9 };

    // Sort array in ascending order.
    //Array.Sort(arr);

    // reverse array
    //Array.Reverse(arr);


} 
