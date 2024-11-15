using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CestaDeCompras1
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int op;
            Console.WriteLine("Bem-vindo ao MENU, escolha uma Opcao: ");
            do
            {
                Console.WriteLine("1 - Incluir um dos produtos na cesta\n 2 - Reajustar o preço de todos os produtos\n3 - Exibir a cesta de produtos\n4 - Exibir total da compra");
                string opString = Console.ReadLine();
                op = Convert.ToInt32(opString);
                switch (op)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opcao invalida, informe um numero de 1 a 5!");
                        break;
                }
            } while (op != 5) ;

        }

    }
}
