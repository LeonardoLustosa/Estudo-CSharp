using System;
using System.ComponentModel.Design;
using System.Globalization;


internal class Program {
    private static void Main(string[] args) {

        int i, N;
        CultureInfo CI = CultureInfo.InvariantCulture;
        Console.WriteLine("Quantos numeros vão ser digitados (MAX 10)? ");
        N = int.Parse(Console.ReadLine());


        while (N > 10 || N < 0) {
            Console.WriteLine("Erro, numero maior que 10 ");
            N = int.Parse(Console.ReadLine());

        }

        {
            double[] vet = new double[N];
            for (i = 0; i < N; i++) {

                Console.Write("Digite um numero: ");
                vet[i] = double.Parse(Console.ReadLine(), CI);

            }

            Console.WriteLine();
            Console.WriteLine("Numeros digitados: ");
            for (i = 0; i < N; i++) {

                Console.WriteLine(vet[i].ToString("F2", CI));



            }
        }
    }
}
