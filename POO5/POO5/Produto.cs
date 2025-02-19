using System.Globalization;

namespace Program {
    internal class Produto {

        public CultureInfo CI = CultureInfo.InvariantCulture;
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque() {

            return (Preco * Quantidade);
        }
        public void AdicionarProdutos(int qtd) {

            Quantidade = Quantidade + qtd;

        }
        public void RetirarProdutos(int qtd2) {

            Quantidade = Quantidade - qtd2;

        }
        public override string ToString() {
            return Nome + ", $" + Preco.ToString("F2", CI)
                + ", " + Quantidade + " Unidades, " + "Total: $"
                + ValorTotalEmEstoque().ToString("F2", CI);


        }


    }
}

