using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 5) Encontrar o dobro de um número caso ele seja positivo
             * e o seu triplo caso  seja negativo, imprimindo o resultado.*/

            Console.WriteLine("Digite um numero");
            int numero = int.Parse(Console.ReadLine());

            if (numero >= 0)
            {
                int dobro = numero * numero;
                Console.WriteLine("O dobro de {0} é: {1}", numero, dobro);
            }
            else
            {
                int triplo = numero * numero * numero;
                Console.WriteLine("O triplo de{0} é: {1}", numero, triplo);

            }
            Console.ReadLine();
        }
    }
}
