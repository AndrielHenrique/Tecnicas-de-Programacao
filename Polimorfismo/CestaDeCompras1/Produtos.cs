using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CestaDeCompras1
{
    public abstract class Produtos
    {
        public string Nome {  get; set; }
        public double Preco {  get; set; }

        public Produtos (string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public abstract void ReajustarPreco();

        public virtual void ExibirProduto()
        {
            Console.WriteLine($"Nome do produto: {Nome}, Preco do Produto: {Preco}");
        }
    }
}
