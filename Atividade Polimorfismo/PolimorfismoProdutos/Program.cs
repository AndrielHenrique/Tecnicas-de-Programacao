using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfismoProdutos
{
    public class Program
    {
        static List<Produto> ListaProdutos = new List<Produto>
        {
            new Televisor("\nTV SAMSUMG", 4000.00),
            new VideoGames("\nPS5", 4500.00),
            new Notebook("\nIDEAPAD 3", 3500.00),
            new Mouse("\nLOGITECH G3", 280.00),
            new Teclado("\nLOGITECH G PRO X", 910.00)
        };

        static void Main(string[] args)
        {
            int op = 0;
            List <CestaDeCompras> compras = new List<CestaDeCompras>();
            CestaDeCompras cesta = new CestaDeCompras();
            Console.WriteLine("BEM VINDO AO MENU, ESCOLHA UMA OPCAO");

            do
            {
                Console.WriteLine("1 - Incluir um dos produtos na cesta\n2 - Reajustar o preço de todos os produtos\n3 - Exibir a cesta de produtos\n4 - Exibir total da compra\n5 - Sair");
                string opString = Console.ReadLine();
                op = Convert.ToInt32(opString);
                switch (op)
                {
                    case 1:
                        AdicionarProdutos(cesta);
                        break;
                    case 2:
                        ReajustarPreco();
                        break;
                    case 3:
                        cesta.ExibirProdutos();
                        break;
                    case 4:
                        cesta.ExibirTotal();
                        break;
                    case 5:
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opcao invalida, informe um numero de 1 a 5!");
                        break;
                }
            } while (op != 5);

        }

        static void AdicionarProdutos(CestaDeCompras compras)
        {
            Console.WriteLine("Produtos disponiveis");
            for (int i = 0; i < ListaProdutos.Count; i++)
            {
                Console.WriteLine($"{i + 1} - {ListaProdutos[i].Nome}, \n Preco: {ListaProdutos[i].Preco}");
            }
            Console.WriteLine("Qual numero do produto voce quer por na sua cesta?");
            int escolha = Convert.ToInt32(Console.ReadLine());
            if(escolha >= 1 && escolha <= ListaProdutos.Count)
            {
                Produto produtoAddCesta = ListaProdutos[escolha - 1];
                compras.AdicionarProduto(produtoAddCesta);
                Console.WriteLine($"Produto {produtoAddCesta.Nome} adicionado na cesta");
            } else
                 Console.WriteLine("Opcao invalida, escolha um numero valido");
        }

        static void ReajustarPreco()
        { foreach(var produto in ListaProdutos)
            {
                produto.ReajustarPreco();
            }
            Console.WriteLine("Preco reajustado");
         }

    }
}
