using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_008
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 8) Escreva um algoritmo que leia três valores inteiros e diferentes e 
             * mostre-os  em ordem decrescente. */

            int a = 1, b = 5, c = 2;


            if (a < b)
            {
                if (b < c)
                {
                    Console.WriteLine("A ordem crescente é: {0},{1},{2}",c, b, a);
                }
                else if (a < c)
                {
                    Console.WriteLine("A ordem crescente é: {0},{1},{2}", b, c, a);
                }
                else
                {
                    Console.WriteLine("A ordem crescente é: {0},{1},{2}", b, a, c);
                }
            }
            else if (b < c)
            {
                if (a < c)
                {
                    Console.WriteLine("A ordem crescente é: {0},{1},{2}", c, a, b);
                }
                else
                {
                    Console.WriteLine("A ordem crescente é: {0},{1},{2}", a, c, b);
                }
            }
            else
            {
                Console.WriteLine("A ordem crescente é: {0},{1},{2}", c, b, a);
            }

            Console.ReadLine();
        }
    }
}
