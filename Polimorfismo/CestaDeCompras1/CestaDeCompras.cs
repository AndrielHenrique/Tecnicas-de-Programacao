using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CestaDeCompras1
{
    public class CestaDeCompras
    {
        List<Produtos> produto = new List<Produtos>();

        public void AdicionarProduto(Produtos produtos)
        {
            produto.Add(produtos);
            Console.WriteLine($"Produto adicionado {produtos}");
        }
        //public void Reajuste(List<Produtos> produtos)
        //{
        //    foreach (var produto in produtos)
        //    {
        //        produto.ReajustarPreco();
        //    }
        //}
        public void ExibirCompras(List<Produtos> produtos)
        {
            Console.WriteLine("Exibindo produtos na cesta");
            foreach (var produto in produtos)
            {
                produto.ExibirProduto();
            }
        }

        public void ExibirTotal(List<Produtos> produtos)
        {
            double precoTotal = 0;
            foreach (var produto in produtos)
            {
                 precoTotal += produto.Preco;
            }
            Console.WriteLine($"Preco total da cesta: {precoTotal}");
        }


    }
}
