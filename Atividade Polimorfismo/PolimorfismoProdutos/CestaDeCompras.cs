using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfismoProdutos
{
    public class CestaDeCompras
    {
        List<Produto> produtos = new List<Produto>();

        public void AdicionarProduto(Produto produto)
        {
            Produto copiaProduto = new ProdutoCopia(produto.Nome, produto.Preco);
            produtos.Add(copiaProduto);
            Console.WriteLine($"Produto {copiaProduto.Nome} com Preco {copiaProduto.Preco} foi adicionado na cesta!");
        }

        public void ExibirProdutos()
        {
            if (produtos.Count != 0)
            {
                Console.WriteLine("Exibindo produtos na Cesta");
                foreach (var produto in produtos)
                {
                    produto.ExibirProduto();
                }
            }
            else
                Console.WriteLine("A cesta ta vazia.");
        }

        public void ExibirTotal()
        {
            if (produtos.Count != 0)
            {
                double total = 0;
                foreach (var produto in produtos)
                {
                    total += produto.Preco;
                }
                Console.WriteLine($"O total do preco na cesta eh {total}");
            }
            else
                Console.WriteLine("A cesta ta vazia.");
        }
    }
}
