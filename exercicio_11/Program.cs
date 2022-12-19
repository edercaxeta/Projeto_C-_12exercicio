using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_011
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 11) Elabore um algoritmo que calcule o que deve ser pago por um produto,  considerando o 
             * preço normal de etiqueta e a escolha da condição de pagamento. Utilize os códigos da tabela
             * a seguir para ler qual a condição de pagamento  escolhida e efetuar o cálculo adequado. 
            *Código Condição de pagamento 
            *1 À vista em dinheiro ou cheque, recebe 10% de desconto 
            *2 À vista no cartão de crédito, recebe 15% de desconto 
            *3 Em duas vezes, preço normal de etiqueta sem juros 
            *4 Em duas vezes, preço normal de etiqueta mais juros de 10% */

            Console.WriteLine("Digite o valor do Produto:");
            decimal valorp = decimal.Parse(Console.ReadLine());

            Console.WriteLine("              Tabela de condeções de pagamento");
            Console.WriteLine("________________________________________________________________");
            Console.WriteLine("Opção|          Descrição                                      |");
            Console.WriteLine("  1  |À vista em dinheiro ou cheque, recebe 10% de desconto    |");
            Console.WriteLine("  2  |À vista no cartão de crédito, recebe 15% de desconto     |");
            Console.WriteLine("  3  |Em duas vezes, preço normal de etiqueta sem juros        |");
            Console.WriteLine("  4  |Em duas vezes, preço normal de etiqueta mais juros de 10%|");
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("Escolha uma forma de Pagamento");
            string opcao = Console.ReadLine();

            switch(opcao)
            {
                case "1":
                    decimal valor10 = valorp - (valorp * 10) / 100;
                    Console.WriteLine("O valor do produto com 10% de desconto é: R$ {0:f2} ", valor10);
                break;

                case "2":
                    decimal valor15 = valorp - (valorp * 15) / 100;
                    Console.WriteLine("O valor do produto com 15% de desconto é: R$ {0:f2} ", valor15);
                break;

                case "3":
                    decimal valor2x = valorp / 2;
                    Console.WriteLine("O valor da parcela do produto dividido de 2x é: R$ {0:f2} ", valor2x);
                break;

                case "4":
                    decimal valor2x10 = (valorp + (valorp * 10) / 100)/2;
                    Console.WriteLine("O valor do produto com 10% de desconto e divido em 2x é: R$ {0:f2} ", valor2x10);
                break;
                    
                default:
                    Console.WriteLine("Opção invalida, o programa será encerrado");
                break;

            }
            Console.WriteLine();
            Console.WriteLine("Volte Sempre!!!!!!");
            Console.ReadLine();
        }
    }
}
