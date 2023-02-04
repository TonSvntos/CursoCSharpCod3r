﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento
{
    public class SubCelebridade
    {
        //Todos
        public string InfoPublica = "Tenho um Instagram!";

        //Herança
        protected string CorDoOlho = "Verde";

        //mesmo projeto(assembly)
        internal ulong NumeroCelular = 5511999999999;

        //Herança ou mesmo projeto
        protected internal string JeitoDeFalar = "Uso muitas girias";

        //mesma class ou herança no mesmo projeto (c# >= 7.2)
        private protected string SegredoFamilia = "Bla bla";

        //private é o padrão só é visivel na mesma classe
        bool UsaMuitoPhotoshop = true;

        public void MeusAcessos()
        {
            Console.WriteLine("SubCelebridade...");

            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDoOlho);
            Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDeFalar);
            Console.WriteLine(SegredoFamilia);
            Console.WriteLine(UsaMuitoPhotoshop);
        }
    }
}
