using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfismoProdutos
{
    public class ProdutoCopia : Produto
    {
        public ProdutoCopia(string nome, double preco) : base(nome, preco) { }
        public override void ReajustarPreco()
        {
            Console.WriteLine("Produto que foi adicionado na cesta e nao vai ser alterado");
        }
    }
}
