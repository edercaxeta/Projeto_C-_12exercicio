using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_007
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 7) Faça um algoritmo que leia uma variável e some 5, caso seja par ou some 8,
             * caso seja ímpar, imprimir o resultado desta operação. */

            Console.WriteLine("Digite um Numero");
            double numero = double.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                double resultado = numero + 5;
                Console.WriteLine("O seu numero digitado é PAR:");
                Console.WriteLine("E a soma de {0} + 5 = {1}",numero,resultado );
            }
            else
            {
                double resultado = numero + 8;
                Console.WriteLine("O seu numero digitado é IMPAR:");
                Console.WriteLine("E a soma de {0} + 8 = {1}", numero,resultado);
            }
            Console.ReadLine();
        }
    }
}
