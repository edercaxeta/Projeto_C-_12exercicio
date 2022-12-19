using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 3) Faça um algoritmo para receber um número qualquer e 
             * informar na tela se é  par ou ímpar. */

            Console.WriteLine("Par ou impar");
            Console.WriteLine("______________");
            Console.WriteLine("Digite um numero: ");
            int n1 = int.Parse(Console.ReadLine());

            
            if (n1 % 2 == 0)
            {
                Console.WriteLine("Par");
            }
            else
            {
                Console.WriteLine("Impar");
            }

            Console.ReadLine();

        }
    }
}
