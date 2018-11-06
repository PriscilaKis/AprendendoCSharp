using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13__CalculaInvestimentoLongoPrazo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 13");
            double valorInvestido = 1000;
            double fatorRendimento = 1.0036;

            for (int contadorAno = 1; contadorAno <= 5; contadorAno++)
            {
                for (int contadorMes = 1; contadorMes <= 12; contadorMes++)
                {
                    valorInvestido *= fatorRendimento;
                }
                fatorRendimento += 0.0010;
               // não existe pois está fora do bloco correto,que seria o primeiro for Console.WriteLine("Tempo de investimento foi de " + contadorAno);
                Console.WriteLine("Ao término do investimento, você terá R$ " + valorInvestido);
            }
            Console.ReadLine();
        }
    }
}
