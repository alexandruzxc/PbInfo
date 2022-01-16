using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1749
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, n, s = 0, c;
            string sir;
            sir = Console.ReadLine();
            string[] v = sir.Split(' ');
            n = int.Parse(v[0]);
            c = int.Parse(v[1]);
            int[,] m = new int[n, n];
            Array.Resize(ref v, n);
            for (i = 0; i < n; i++)
            {
                sir = Console.ReadLine();
                v = sir.Split(' ');
                for (j = 0; j < n; j++)
                {
                    m[i, j] = int.Parse(v[j]);
                }
            }
            if (c == 1)
                for (i = 0; i < n; i++)
                    for (j = 0; j < n; j++)
                    {
                        if (i < j && i + j < n - 1)
                            s = s + m[i, j];
                    }
            if (c == 2)
                for (i = 0; i < n; i++)
                    for (j = 0; j < n; j++)
                    {
                        if (i < j && i + j > n - 1)
                            s = s + m[i, j];
                    }
            if (c == 3)
                for (i = 0; i < n; i++)
                    for (j = 0; j < n; j++)
                    {
                        if (i > j && i + j > n - 1)
                            s = s + m[i, j];
                    }
            if (c == 4)
                for (i = 0; i < n; i++)
                    for (j = 0; j < n; j++)
                    {
                        if (i > j && i + j < n - 1)
                            s = s + m[i, j];
                    }
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}