using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConvercoesEoutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 4");
            double salario = 1200.50;
            Console.WriteLine(salario);

            int salarioEmInteiro;
            salarioEmInteiro = (int)salario;
            Console.WriteLine(salarioEmInteiro);
            //O long é uma variável de 64 bits
            //o int é um tio de variáver que suporta até 32 bits;
            //short é um tipo de variáver de 16 bits
            long idade = 130000000000;
            Console.WriteLine(idade);

            short quantidadeProduto = 150;
            //não usual usar um float o f é pra "ensinar ao código que você sabe o que está fazendo. Que não é um erro de digitação"
            float altura = 1.80f;
            Console.WriteLine(altura);
            Console.ReadLine();
        }
    }
}
