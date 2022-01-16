using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _510
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i;
            string sir;
            n = int.Parse(Console.ReadLine());
            sir = Console.ReadLine();
            string[] sir2 = sir.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] v = new int[n];
            for (i = 0; i < n; i++)
                v[i] = int.Parse(Convert.ToString(sir2[i]));
            Array.Sort(v);
            for (i = 0; i < n; i++)
                if(Prim(v[i])==1)
                    Console.Write(v[i]+" ");
            Console.ReadKey();
        }
        private static int Prim(int n)
        {
            int i, d = 0;
            if (n == 1)
                return 0;
            if (n % 2 == 0)
                return 0;
            for (i = 3; i<= n/2; i=i+2)
                if (n % i == 0)
                    d++;
            if (d == 0)
                return 1;
            return 0;
        }
    }
}