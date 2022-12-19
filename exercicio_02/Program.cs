using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 2) Faça um algoritmo que leia o nome, o sexo e o estado civil de uma pessoa. 
             * Caso sexo seja “F” e estado civil seja “CASADA”, solicitar o tempo de casada  (anos).  */

            Console.WriteLine("Escreva seu nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite F para feminino e M para masculino: ");
            char sexo = char.Parse(Console.ReadLine());
            Console.WriteLine("Escreva seu estado civil: ");
            string estado = Console.ReadLine();

            if ((sexo == 'f') && (estado == "casada"))
            {
                Console.WriteLine("Digite quantos anos você tem de casada");
                int casad = int.Parse(Console.ReadLine());
                 Console.WriteLine("Seu nome é: {0} seu sexo {1} e você tem {2} anos de casada: ", nome, sexo, casad);
            }
            else
            {
                Console.WriteLine("{0} você está aproveitando a vida", nome);

            }
            Console.ReadLine();
        }
    }
}
