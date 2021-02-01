using System;
using System.Globalization;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
           

            Console.WriteLine("Entre os dados do produto");
            Console.Write("Nome: ");
            String nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse (Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());

            Produto p = new Produto(nome, preco, quantidade);


            Console.WriteLine();
            Console.WriteLine("Dados do produto:  " + p);

            Console.WriteLine(" ");
            Console.Write("Digite a número de produtos a ser adicionado em estoque:  " );
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProduto(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados:  " + p);


            Console.WriteLine(" ");
            Console.Write("Digite a número de produtos a ser removido em estoque:  ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProduto(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados:  " + p);



        }
    }
}
