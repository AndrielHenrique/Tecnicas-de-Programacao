using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfismoProdutos
{
    public abstract class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public abstract void ReajustarPreco();
        public virtual void ExibirProduto()
        {
            Console.WriteLine($"Nome do Produto: {Nome}\n Preco do Produto: {Preco}");
        }

    }
}
