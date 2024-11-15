using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CestaDeCompras1
{
    public class DVD : Produtos
    {
        public DVD(string nome, double preco) : base(nome, preco) { }

        public override void ReajustarPreco()
        {
            this.Preco = Preco * 0.1;
        }
    }
}
