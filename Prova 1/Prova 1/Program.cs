using System.Globalization;
using System.Runtime.Serialization;

internal class Program {
    private static void Main(string[] args) {

        CultureInfo CI = CultureInfo.InvariantCulture;
        double peça1, peça2, Q1, Q2, v1, v2, soma;
        int produtos;

        Console.WriteLine("Quantos produtos: ");
        produtos = int.Parse(Console.ReadLine());

        if (produtos > 1 && produtos <= 2) {
            Console.WriteLine("Digite o Codigo das peças: ");
            peça1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a Quantidade: ");
            Q1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite valor: ");
            v1 = double.Parse(Console.ReadLine(), CI);

            Console.WriteLine("Digite o Codigo das peças: ");
            peça2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a Quantidade: ");
            Q2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite valor: ");
            v2 = double.Parse(Console.ReadLine(), CI);

            soma = v1 + v2;
            Console.WriteLine("Valor total a pagar = " + soma.ToString("F2", CI));

        }
        else {
            Console.WriteLine("Digite o Codigo das peças: ");
            peça1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite valor: ");
            v1 = double.Parse(Console.ReadLine(), CI);

            Console.WriteLine("Valor total a pagar " + v1.ToString("F2", CI));
        }












    }
}