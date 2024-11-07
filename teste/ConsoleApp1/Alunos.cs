using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Alunos
    {
        public int Ra { get; set; }
        public string Nome { get; set; }
        public float[] Notas { get; set; }
        public float Media { get; private set; }

        static List<Alunos> alunos = new List<Alunos>();

        public Alunos()
        {
            Notas = new float[4];
        }
        public void CadastrarAluno()
        {
            Alunos aluno = new Alunos();
            Console.WriteLine("Informe o RA: ");
            aluno.Ra = (int)Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Informe o Nome: ");
            aluno.Nome = Console.ReadLine();
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Informe a " + (i + 1) + "a nota: ");
                aluno.Notas[i] = float.Parse(Console.ReadLine());
            }
            alunos.Add(aluno);
            Console.WriteLine("Aluno cadastrado com sucesso");
        }

        public float CalcularMedia()
        {
            float[] pesos = { 1, 1, 1, 7 };
            float somaPesos = pesos.Sum();
            float somaNotas = 0;
            for (int i = 0; i < Notas.Length; i++)
            {
                somaNotas += Notas[i] * pesos[i];
            }
            return somaNotas / somaPesos;
        }
        public void ExibirSituacao()
        {
            Console.WriteLine("Situacoes dos alunos: ");
            foreach (var aluno in alunos)
            {
                Console.WriteLine($"Aluno: {aluno.Nome}, Ra: {aluno.Ra}, Media: {aluno.Media} ");

                if (Media >= 6)
                    Console.WriteLine("Aprovado");
                else if (Media >= 4 && Media < 6)
                    Console.WriteLine("Recuperacao");
                else
                    Console.WriteLine("Reprovado");
            }


        }
        public void Main(string[] args)
        {
            int op;
            do
            {
                op = Menu();
                switch (op)
                {
                    case 1:
                        CadastrarAluno();
                        break;
                    case 2:
                        ExibirSituacao();
                        break;
                    case 3:
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Escolha uma opcao valida, de 1 a 3...");
                        break;
                }

            } while (op != 3);
        }
        public int Menu()
        {
            int op = 0;
            Console.WriteLine("Escolha uma opcao");
            Console.WriteLine("1 - Cadastrar aluno");
            Console.WriteLine("2 - Exibir situacoes");
            Console.WriteLine("3 - Sair");
            return op;
        }
    }
}
