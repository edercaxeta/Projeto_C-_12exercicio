using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 4) Faça um algoritmo que leia dois valores inteiros A e B se os valores forem 
             * iguais deverá se somar os dois, caso contrário multiplique A por B. Ao final 
             * de  qualquer um dos cálculos deve-se atribuir o resultado para uma variável C
             * e  mostrar seu conteúdo na tela.*/

            Console.WriteLine("Escreva um numero: ");
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine("Escreva outro numero: ");
            int B = int.Parse(Console.ReadLine());

            if (A == B)
            {
                int C = A + B;
                Console.WriteLine("A soma de {0} e {1} é: {2}", A, B, C);
            }
            else
            {
                int C = A*B;
                Console.WriteLine("A Multiplicação entre {0} e {1} é: {2}", A,B,C);

            }
            Console.ReadLine();
        }
    }
}
