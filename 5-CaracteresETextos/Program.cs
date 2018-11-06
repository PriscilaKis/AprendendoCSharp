using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 5 - Caracteres e textos");
            //chacter
            char primeiraLetra = ' ';
            Console.WriteLine(primeiraLetra);
            primeiraLetra = (char)61;
            Console.WriteLine(primeiraLetra);
            //Cast para o char
            primeiraLetra = (char)(primeiraLetra + 1); //Compila
            Console.WriteLine(primeiraLetra);
            //C# atinge grande variedade de níves
            string titulo = "Alura Cursos de Tecnologia " + 2018;
            string cursosProgramacao = @" 
 - .NET
 -Java;
 -JavaScript";

            Console.WriteLine(titulo);
            Console.WriteLine(cursosProgramacao);
            //Usa-se o simbolo de @ para fazer a quebra de linha da string
        //string vazia podem ser criadas
            Console.ReadLine();        
         }
    }
}
