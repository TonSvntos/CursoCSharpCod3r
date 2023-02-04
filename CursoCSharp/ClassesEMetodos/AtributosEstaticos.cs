﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{

    public class Produto
    {
        public string Nome;
        public double Preco;
        public static double Desconto = 0.1; 
        // a partir do momento que eu deixo o atributo estatico
        // ele pertence a classe e não a instância

        public Produto(string nome, double preco, double desconto)
        {
            Nome = nome;
            Preco = preco;
            Desconto = desconto;
        }

        public Produto()
        {

        }

        public double CalcularDesconto()
        {
            return Preco - Preco * Desconto;
        }
    }
    internal class AtributosEstaticos
    {
        public static void Executar()
        {
            var produto1 = new Produto("caneta", 3.2, 0.1);

            var produto2 = new Produto()
            {
                Nome = "Borracha",
                Preco = 5.3,
                //Desconto = 0.1
            };

            Produto.Desconto = 0.5;

            Console.WriteLine("Preço com desconto: {0}",
                produto1.CalcularDesconto());
            Console.WriteLine("Preço com desconto: {0}", 
                produto2.CalcularDesconto());

            Produto.Desconto = 0.05;

            Console.WriteLine("Preço com desconto: {0}",
                produto1.CalcularDesconto().ToString("F2"));
            Console.WriteLine("Preço com desconto: {0}",
                produto2.CalcularDesconto().ToString("F2"));

        }
    }
}