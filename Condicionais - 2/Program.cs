using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 8 - Condicionais 2");
            int idadeJoao = 19;
            int quantidadePessoas = 2;
            //boll é a variável para Booleano no C#
            bool acompanhado = quantidadePessoas >= 2;
            //Barras na vertical são usadas para a palavra OU no C# a letra E no C# é usadao &&. Quer dizer que ambas as condicoes devem ser satisfeitas

            if (idadeJoao >= 18 && acompanhado == true)

            {
                Console.WriteLine("Pode entrar!");
            }
            else
            {
                Console.WriteLine("Não pode Entrar!");
            }
            Console.ReadLine();
        }
    }
}
