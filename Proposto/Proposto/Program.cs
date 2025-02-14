using System;
using System.Globalization;
namespace MyApp {
    internal class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            string nome, sobrenome;
            int Quartos, idade;
            double produto, altura;
            

            Console.WriteLine("Entre com seu nome completo: ");
            nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa: ");
            Quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Dê um preço pra vc: ");
            produto = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com sobrenome, idade e altura");
            string[] vet = Console.ReadLine().Split(' ');

            sobrenome = vet[0];
            idade = int.Parse(vet[1]);
            altura = double.Parse(vet[2], CI);


            Console.WriteLine();
            Console.WriteLine("Sua lista de corno: ");
            Console.WriteLine(nome);
            Console.WriteLine(Quartos);
            Console.WriteLine(produto);
            Console.WriteLine(sobrenome + " " + idade + " " + altura.ToString("F2", CI) );



        }
    }
}