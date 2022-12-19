using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace exercicio_009
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 9) Tendo como dados de entrada a altura e o sexo de uma pessoa, construa um  algoritmo 
             * que calcule seu peso ideal, utilizando as seguintes fórmulas: 
             * ● para homens: (72.7 * h) – 58; 
             * ● para mulheres: (62.1 * h) – 44.7. */

            Console.WriteLine("Calcule o Peso Ideal");
            Console.WriteLine("_______________________");
            Console.WriteLine("Digite sua altura");
            double altura = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite F para feminino e M para masculino: ");
            char sexo = char.Parse(Console.ReadLine());
            
            if (sexo == 'f')
            {
                double pesomulher = (62.1 * altura) - 44.7;
                Console.WriteLine("O peso ideal para mulher que tem {0} de altura é: {1}", altura, pesomulher.ToString("f2", CultureInfo.InvariantCulture));

            }
            else if (sexo == 'm')
            {
                double pesohomem = (72.7 * altura) - 58;
                Console.WriteLine("O peso ideal para homem que tem {0} de altura é: {1}", altura, pesohomem.ToString("f2", CultureInfo.InvariantCulture));
            }
            Console.ReadLine();
        }
    }
}
