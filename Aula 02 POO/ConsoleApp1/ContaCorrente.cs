using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ContaCorrente : ContaBancaria
    {
       double TaxaSaque { get; set; }
       public ContaCorrente(string a, string c, string t, double s) :base(a, c, t)
        { 
            TaxaSaque = s;
        }

        public override void SacarValor(double valor)
        {
            double valorCTaxa = valor + TaxaSaque;
            if (Saldo >= valorCTaxa)
            {
                Saldo -= valorCTaxa;
                Console.WriteLine($"{valorCTaxa} debitado da conta, saldo atual: {Saldo}");
            }
            else
                Console.WriteLine("Saldo insuficiente para debitar");
        }
    }
}
