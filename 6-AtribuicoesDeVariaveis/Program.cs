using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_AtribuicoesDeVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 6");
            //colocar uma variável no valor de outra variável ele vai copiar o valor das duas vriáveis
            int idade = 32;
            int idadeGustavo = idade;

            idade = 20;
            Console.WriteLine(idade);
            Console.WriteLine(idadeGustavo);


            Console.ReadLine();
        }
    }
}
