using System;
using Program;

namespace Projeto {
    internal class Program {
        static void Main(string[] args) {

            Produto p = new Produto();


            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), p.CI);
            Console.Write("Quantidade: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine();
            Console.WriteLine("Digite um numero de produto a ser adicionado ao estoque: ");
            int qtd = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qtd);

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine();
            Console.WriteLine("Digite um numero de produto a ser retirado do estoque: ");
            int qtd2 = int.Parse(Console.ReadLine());
            p.RetirarProdutos(qtd2);

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);    

        }
    }
}