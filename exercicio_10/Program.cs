using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace exercicio_010
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 10) O IMC – Índice de Massa Corporal é um critério da Organização Mundial de  Saúde 
             * para dar uma indicação sobre a condição de peso de uma pessoa adulta.  A fórmula é:
             * IMC = peso / ( altura )2 
             *Elabore um algoritmo que leia o peso e a altura de um adulto e mostre sua  condição de acordo com a tabela abaixo. 
            *IMC em adultos Condição 
            *Abaixo de 18,5 Abaixo do peso 
            *Entre 18,5 e 25 Peso normal 
            *Entre 25 e 30 Acima do peso 
            *Acima de 30 obeso */

            decimal peso = 0;
            decimal altura = 0;
            decimal imc = 0;

            Console.WriteLine("Entre com sua altura");
            altura = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Entre com seu peso");
            peso = decimal.Parse(Console.ReadLine());

            imc = peso / (altura * altura);
            Console.WriteLine("O IMC é: " + imc.ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine("O IMC é: {0} e o peso é: {1} e a altura é {2}", imc.ToString("f2", CultureInfo.InvariantCulture), peso.ToString("f2", CultureInfo.InvariantCulture), altura.ToString("f2", CultureInfo.InvariantCulture));
            Console.ReadLine();

            if (imc < decimal.Parse("18,5"))
            {
                Console.WriteLine("Você esta abaixo do peso");
            }
            else if (imc > decimal.Parse("18,5") && imc < decimal.Parse("25"))
            {
                Console.WriteLine("Seu peso está normal");

            }
            else if (imc > decimal.Parse("25") && imc < decimal.Parse("30"))
            {
                Console.WriteLine("Você esta acima do peso");

            }
            else
            {
                Console.WriteLine("Você esta obeso");
            }
            Console.ReadLine();
        }
    }
}
