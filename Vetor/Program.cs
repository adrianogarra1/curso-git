using System;
using System.Globalization;

namespace Vetor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o tamanho do vetor: ");
            int n = int.Parse(Console.ReadLine());

            Product[] vect = new Product[n];

            for (int i = 0; i < n; i++)
            { 
                Console.Write("Infome o nome: ");
                string nome = Console.ReadLine();
                Console.Write("Infome o valor: ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vect[i] = new Product { Nome = nome, Preco = preco };

            }

            double sum = 0.0;
            for (int i = 0; i < n; i++)
            {
                sum = sum + vect[i].Preco;
            }
            double avg = sum / n;
            Console.WriteLine("Media: "+ avg.ToString("F2" , CultureInfo.InvariantCulture));

            Console.ReadKey();
        }
    }
}
