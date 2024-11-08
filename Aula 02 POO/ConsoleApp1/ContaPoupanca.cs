using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ContaPoupanca : ContaBancaria
    {
        public double TaxaJuros { get; set; }
        public ContaPoupanca(string a, string c, string t, double j) : base(a, c, t)
        {
            TaxaJuros = j;
        }

        public void TaxarJuros()
        {
            double juros = Saldo * TaxaJuros / 100;
            AtribuirSaldo(juros);
            Console.WriteLine($"Juros inserido {juros}");
        }
    }
}
