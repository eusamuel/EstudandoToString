using System;
using System.Globalization;

namespace LearnToString {
    class Program {
        static void Main(string[] args) {
            // Fazer um programa para ler os dados de um produto em estoque (nome, preço e
            // quantidade no estoque).

            Produto p = new Produto();

            Console.WriteLine("Entre os dados do produto: ");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("\nDados do produto: " + p);

            Console.Write("\nDigite o número de produtos a ser adicionados ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);
            Console.WriteLine("\nDados atualizados: " + p);

            Console.Write("\nDigite o número de produtos a ser removidos ao estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);
            Console.Write("\nDados atualizados: " + p +"\n\n\n\n");

        }
    }
}