using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_006
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 6) Escreva um algoritmo que lê dois valores booleanos (lógicos) e 
             * então  determina se ambos são VERDADEIROS ou FALSOS.*/

            Console.WriteLine("Tabela Verdade");
           
            bool vv = true;     
            bool vf = false;    
            bool ff = false;
            bool fv = false;         
            bool VouV = true;
            bool VouF =true;
            bool FouF = false;
            bool FouV = true;

            Console.WriteLine();
            Console.WriteLine("Regras do V 'e' F(&&)");
            Console.WriteLine("V e V = " + vv);
            Console.WriteLine("V e F = " + vf);
            Console.WriteLine("F e F = " + ff);
            Console.WriteLine("F e V = " + fv);
            Console.WriteLine();

            Console.WriteLine("Regras do V 'ou' F(||)");
            Console.WriteLine("V ou V = " + VouV);
            Console.WriteLine("V ou F = " + VouF);
            Console.WriteLine("F ou f = " + FouF);
            Console.WriteLine("F ou V = " + FouV);

            Console.ReadLine(); 
        }
    }
}
