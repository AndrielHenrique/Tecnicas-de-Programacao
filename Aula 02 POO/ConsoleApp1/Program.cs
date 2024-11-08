using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaPoupanca contaPoupanca = new ContaPoupanca("1", "333", "Andriel", 0.5);
            Console.WriteLine("Atribuindo saldo na conta poupanca");
            contaPoupanca.AtribuirSaldo(1000);
            contaPoupanca.TaxarJuros();
            contaPoupanca.SacarValor(23);

            ContaCorrente contaCorrente = new ContaCorrente("2", "444", "Andriel", 5);
            Console.WriteLine("Atribuindo saldo na conta corrente");
            contaCorrente.AtribuirSaldo(1000);
            contaCorrente.SacarValor(300);

            Console.WriteLine("Saldo conta poupanca");
            contaPoupanca.ExibirSaldo();
            Console.WriteLine("Saldo conta corrente: ");
            contaCorrente.ExibirSaldo();
        }
    }
}
