using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1) Faça um algoritmo que leia os valores A, B, C e imprima na
             * tela se a soma de  A + B é menor que C.*/

            Console.WriteLine("Digite o primeiro numero: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o terceiro bumero: ");
            int c = int.Parse(Console.ReadLine());
            
            int soma = a + b;

            if (soma > c)
            {
                Console.WriteLine("Soma é maior que c");
            }
            else
            {
                Console.WriteLine("C é maior que soma A+B");
            }
            Console.ReadLine();
        }
    }
}
