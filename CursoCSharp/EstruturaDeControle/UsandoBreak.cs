﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle
{
    internal class UsandoBreak
    {
        public static void Executar()
        {
            Random random = new Random();
            int numero = random.Next(1, 51);

            Console.WriteLine("O número que queremos é {0}.", numero);

            for (int i = 1; i <= 50; i++)
            {
                Console.WriteLine("{0} é o número que queremos? ", i);
                if (i == numero)
                {
                    Console.WriteLine("Sim!");
                    break;// serve para parar de executar quando chegar nessa condição

                }
                else
                {
                    Console.WriteLine("Não!");
                }
            }

            Console.WriteLine("Fim!");
        }
    }
}
