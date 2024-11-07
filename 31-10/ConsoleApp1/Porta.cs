using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp1
{
    internal class Porta
    {
        public string Cor { get; set; }
        public string Material { get; set; }
        public string Altura { get; set; }
        public string Largura { get; set; }
        public bool EstaAberta { get; set; }

        public Porta(string cor, string material, string altura, string largura, bool estaAberta)
        {
            this.Cor = cor;
            this.Material = material;
            this.Altura = altura;
            this.Largura = largura;
            this.EstaAberta = false;
        }
        public void Abrir()
        {
            if (!EstaAberta)
            {
                EstaAberta = true;
                Console.WriteLine("A porta foi aberta!");
            }
            else
                Console.WriteLine("A porta ja esta aberta.");
        }

        public void Fechar()
        {
            if (EstaAberta)
            {
                EstaAberta = false;
                Console.WriteLine("A porta foi fechada!");
            }
            else
                Console.WriteLine("A porta ja esta fechada!");
        }

        public void Trancar()
        {
            string trancar = EstaAberta ? "Nao é possivel fechar a porta com ela aberta!" : "A porta foi trancada!";
            Console.WriteLine(trancar);
        }

        public void Destrancar()
        {
            Console.WriteLine("A porta foi destrancada!");
        }

        public void StatusPorta()
        {
            string status = EstaAberta ? "aberta" : "fechada";
            Console.WriteLine($"A porta esta {status}.");
        }
    }
}
