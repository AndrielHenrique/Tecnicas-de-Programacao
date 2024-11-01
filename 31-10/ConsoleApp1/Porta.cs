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
        string cor = " ";
        string origem = " ";
        Boolean fechado = false;
        string madeira = " ";
        int tamanho = 0;

        public Porta(string cor, string origem, bool fechado, string madeira, int tamanho)
        {
            this.cor = cor;
            this.origem = origem;
            this.fechado = fechado;
            this.madeira = madeira;
            this.tamanho = tamanho;
        }

        public string getCor{ get { return cor; } }
        public string getrigem{ get { return origem; } }  
        public Boolean getFechado{ get {   return fechado; } }
        public int getTamanho{ get { return tamanho; } }

        

    }
}
