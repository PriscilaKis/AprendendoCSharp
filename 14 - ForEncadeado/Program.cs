using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14___ForEncadeado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 14");
            //Uma forma diferente de fazer asteriscos
            for (int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
            {
                for (int contadorColuna = 0; contadorColuna < 10; contadorColuna++)
                {
                    Console.Write("*");
                    if (contadorColuna >= contadorLinha)
                        break;
                }
                Console.WriteLine();
            }
            //Uma forma diferente de desenhar com asteriscos
            for (int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
            {
                for (int contadorColuna = 0; contadorColuna <= contadorLinha; contadorColuna++)
                {
                    Console.Write("*");

                }
                Console.WriteLine();
            }




            Console.ReadLine();
        }
    }
}
