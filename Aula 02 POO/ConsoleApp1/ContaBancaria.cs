using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ContaBancaria
    {

        public String Agencia { get; set; }
        public String Conta { get; set; }
        public double Saldo { get; set; }
        public String Titular { get; set; }

        public ContaBancaria(String a, String c, String t)
        {
            this.Agencia = a;
            this.Conta = c;
            this.Saldo = 0.0;
            this.Titular = t;
        }

        public virtual void AtribuirSaldo(double valor)
        {
            this.Saldo += valor;
            Console.WriteLine($"{valor} atribuido na conta de {Titular}. Saldo atual:{Saldo}");
        }
        public virtual void SacarValor(double valor)
        {
            if (Saldo >= valor)
            {
                this.Saldo -= valor;
                Console.WriteLine($"{valor} sacado da conta de {Titular}. Saldo atual:{Saldo}");
            }
        }

        public void ExibirSaldo()
        {
            Console.WriteLine($"Saldo: {Saldo} de {Titular}");
        }


    }

}
