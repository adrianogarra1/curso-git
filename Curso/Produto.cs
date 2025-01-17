﻿using System.Globalization;

namespace Curso
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto (string nome, double preco, int quantidade) 
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = 0;
        }


        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProduto(int quantidade)
        {
            Quantidade = Quantidade + quantidade;
        }


        public void RemoverProduto(int quantidade)
        {
            Quantidade = Quantidade - quantidade;
        }



        public override string ToString()
        {
            return Nome + " , $ " + Preco.ToString("F2", CultureInfo.InvariantCulture) + " , " + Quantidade + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
