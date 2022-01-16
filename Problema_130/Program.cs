using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Problema_130
{
    class Program
    {
        static int sumacif(int n)

        {
            int sum = 0;
           while (n != 0)
           {
                sum += n % 10;
                n /= 10;
            }
            return sum;
        }

        static void Main(string[] args)
        {

            int i, j; 
            int aux = 0;
            string[] linii = System.IO.File.ReadAllLines(@"..\..\TextFile1.txt");
            //TextReader load1 = new StreamReader(@"..\..\TextFile1.txt");
            //string buffer0 = load1.ReadLine();
            int numarElemente = int.Parse(linii[0]);
            string[] elemente = linii[1].Split(' ');
            int[] numere = new int[numarElemente];
            for (i = 0; i < numarElemente; i++)
            {

                numere[i] = int.Parse(elemente[i]);
            }
            
                for (i = 0; i < numarElemente -1 ; i++)
                    for (j = i + 1; j < numarElemente; j++)
                        if (sumacif(numere[i]) > sumacif(numere[j]))
                        {
                            aux = numere[i];
                        numere[i] = numere[j];
                        numere[j] = aux;
                        }

                for (i = 0; i < numarElemente; i++)
            {
                Console.WriteLine(numere[i]);

            }
        }
       

    }
}
