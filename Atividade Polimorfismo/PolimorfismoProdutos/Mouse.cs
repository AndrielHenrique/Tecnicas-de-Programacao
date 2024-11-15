using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfismoProdutos
{
    public class Mouse : Produto
    {
        public Mouse(string nome, double preco): base(nome, preco) { }

        public override void ReajustarPreco()
        {
            Preco += Preco * 0.05;
        }
    }
}
