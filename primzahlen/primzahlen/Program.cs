using System;
using System.Collections.Generic;

namespace primzahlen
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 101;
            int[] sieb = new int[max];

            for (int i = 2; i < sieb.Length; i++)
            {
                sieb[i] = i;
            }

            for (int i = 2; i < Math.Sqrt(max); i++)
            {
                for (int k = i+i; k < max; k= k+i)
                {
                    sieb[k] = 0;
                }
            }

            for (int i = 0; i < sieb.Length; i++)
            {
                if (sieb[i]!=0)
                {
                    Console.WriteLine(sieb[i]+",");
                }
            }
        }
    }
}
