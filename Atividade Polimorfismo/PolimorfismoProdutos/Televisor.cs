using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfismoProdutos
{
    public class Televisor : Produto
    {
        public Televisor(string nome, double preco): base(nome, preco) { }

        public override void ReajustarPreco()
        {
            Preco += Preco * 0.01;
        }
    }
}
