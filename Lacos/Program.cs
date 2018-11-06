using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main(String args[])
    {
        for (int i = 3; i < 100; i += 3)
        {
            Console.WriteLine(i);
        }
    }
}

//Você se lembra do fatorial? Não? Sem problemas, seguem as regras:
// O fatorial de 0 é 1.
//O fatorial de 1 é(0!) * 1 = 1.
//O fatorial de 2 é(1!) * 2 = 2
//O fatorial de 3 é(2!) * 3 = 6
//O fatorial de 4 é(3!) * 4 = 24
//O fatorial de um número n é n * n-1 * n-2 ... até n = 1.

//O fatorial de 0 é 1.
//O fatorial de 1 é(0!) * 1 = 1.
//O fatorial de 2 é(1!) * 2 = 2
//O fatorial de 3 é(2!) * 3 = 6
//O fatorial de 4 é(3!) * 4 = 24
//O fatorial de um número n é n * n-1 * n-2 ... até n = 1.