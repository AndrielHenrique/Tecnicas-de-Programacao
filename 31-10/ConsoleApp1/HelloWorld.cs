using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ConsoleApp1
{
    internal class HelloWorld
    {
        private string nome;

        public HelloWorld()
        {
            nome = "Desconhecido";
        }

        public HelloWorld(string n)
        {
            nome = n;
        }

        public void sayHello()
        {
            Console.Write("Olá " + nome);
        }
    }
}
