using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_CalculaPoupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 11 - Calcula Poupança");

            double valorInvestido = 1000;
            int contadorMes = 1;
            while (contadorMes <= 12)
            {
                valorInvestido = valorInvestido + valorInvestido * 0.0036;
                Console.WriteLine("Após " + contadorMes + " meses, você terá R$" + valorInvestido);

                //contadorMes = contadorMes + 1;
                //contadorMes += 1;
                contadorMes++;
            }
            //0.36% = 0.0036
            Console.ReadLine();
        }
    }
}
