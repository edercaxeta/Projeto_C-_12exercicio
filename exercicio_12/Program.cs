using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_012
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 12) Escreva um algoritmo que leia o número de identificação, as 3 notas obtidas  por
             * um aluno nas 3 verificações e a média dos exercícios que fazem parte da  avaliação,
             * e calcule a média de aproveitamento, usando a fórmula: MA = (nota1 + nota 2 * 2 + nota 3 * 3 + ME)/7 
             * A atribuição dos conceitos obedece a tabela abaixo. O algoritmo deve escrever  o número do aluno,
             * suas notas, a média dos exercícios, a média de  aproveitamento, o conceito correspondente e 
             * a mensagem 'Aprovado' se o  conceito for A, B ou C, e 'Reprovado' se o conceito for D ou E. 
            *Média de aproveitamento Conceito 
            *>= 90 A 
            *>= 75 e < 90 B 
            *>= 60 e < 75 C 
            *>= 40 e < 60 D 
            *< 40 E */

            Console.WriteLine("Tabela de Aprovitamento de aluno da Unidesc");
            Console.WriteLine("________________________________________________________________");
            //cod do aluno
            Console.Write("Digite o codigo do aluno: ");
            string codaluno = Console.ReadLine();
            Console.WriteLine();

            //nota da provas
            Console.WriteLine("------------------Digite as notas das Provas-------------------");
            Console.WriteLine("Informe a nota da 1° prova");
            double nota1 = double.Parse(Console.ReadLine());
            while (nota1 < 0 || nota1 > 100)
            {
                Console.WriteLine("Nota invalida, Repita");
                nota1 = double.Parse(Console.ReadLine());

            }

            Console.WriteLine("Informe a nota da 2° prova");
            double nota2 = double.Parse(Console.ReadLine());
            while (nota2 < 0 || nota2 > 100)
            {
                Console.WriteLine("Nota invalida, Repita");
                nota2 = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("Informe a nota da 3° prova");
            double nota3 = double.Parse(Console.ReadLine());
            while (nota3 < 0 || nota3 > 100)
            {
                Console.WriteLine("Nota invalida, Repita");
                nota3 = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine();
            

            //nota das oats
            Console.WriteLine("-----Digite as notas das oats-----");
            Console.WriteLine("Informe a nota da 1° oat");
            double oat1 = double.Parse(Console.ReadLine());
            while (oat1 < 0 || oat1 > 100)
            {
                Console.WriteLine("Nota invalida, Repita");
                oat1 = double.Parse(Console.ReadLine());

            }

            Console.WriteLine("Informe a nota da 2° oat");
            double oat2 = double.Parse(Console.ReadLine());
            while (oat2 < 0 || oat2 > 100)
            {
                Console.WriteLine("Nota invalida, Repita");
                oat2 = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("Informe a nota da 3° oat");
            double oat3 = double.Parse(Console.ReadLine());
            while (oat3 < 0 || oat3 > 100)
            {
                Console.WriteLine("Nota invalida, Repita");
                oat3 = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("================================================================");
            Console.WriteLine();

            //saidas
            Console.WriteLine("________________________________________________________________");
            Console.WriteLine("O codigo do áluno é= {0}", codaluno);
            Console.WriteLine("A nota da primeira prova é: {0}", nota1);
            Console.WriteLine("A nota da segunda prova é: {0}", nota2);
            Console.WriteLine("A nota da terceira prova é: {0}", nota3);
            double somaOats = (oat1 + oat2 + oat3)/3;
            Console.WriteLine("A media das Oats é:{0:f2} ", somaOats);

            
            //media de aproveitamento
            double maproveitamento = (nota1 + (nota2*2) + (nota3*3) + somaOats)/ 7;
            Console.WriteLine("A media de aproveitamento é:{0:f2}", maproveitamento);
            Console.WriteLine();

            //condicionais de conceito de nota
            Console.Write("A nota é ");
            if (maproveitamento >= 90)
            {
                Console.WriteLine("Conceito A");
            }
            else if(maproveitamento >= 75)
            {
                Console.WriteLine("Conceito B");
            }
            else if(maproveitamento >=60)
            {
                Console.WriteLine("Conceito C");
            }
            else if (maproveitamento >= 40)
            {
                Console.WriteLine("Conceito D");
            }
            else
            {
                Console.WriteLine("Conceito E");
            }

            //condicionais de aprovação
            Console.Write("O aluno foi ");
            if(maproveitamento <= 100 && maproveitamento >= 60)
            {
                Console.WriteLine("Aprovado");
            }
            else
            {
                Console.WriteLine("Reprovado");
            }
            Console.ReadLine();
        }
    }
}
