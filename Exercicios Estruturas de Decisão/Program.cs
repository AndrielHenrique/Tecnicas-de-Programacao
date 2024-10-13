using System;

namespace Exercicios_Estruturas_de_Decisão
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            exercicio1();
            exercicio2();
        }
        static void exercicio1()
        {
            // 1. Desenvolver um programa que leia duas notas entre 0 e 10, calcule a média e exiba:
            // • APROVADO – Se a nota está entre 6 e 10.
            // • RECUPERAÇÃO – Se a nota está entre 4 e 5.9.
            // • REPROVADO – Se a nota está abaixo de 4.

            Console.WriteLine("Informe a primeira nota: ");
            double n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe a segunda nota: ");
            double n2 = Convert.ToDouble(Console.ReadLine());
            double media = (n1 + n2) / 2;
            if (media > 6)
                Console.WriteLine("Aprovado " + media);
            else if (media >= 4 && media < 6)
                Console.WriteLine("Recuperação " + media);
            else
                Console.WriteLine("Reprovado " + media);
        }

        static void exercicio2()
        {
            // 2. Usando a estrutura If, desenvolva um programa que leia três números inteiros. Em seguida exiba-os em ordem crescente.
            Console.WriteLine("Informe o primeiro numero: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe o segundo numero: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe o terceiro numero: ");
            int n3 = Convert.ToInt32(Console.ReadLine());

            if (n1 > n2 && n1 > n3)
            {
                Console.Write(n1 + " ");
                if (n2 > n3)
                    Console.Write(n2 + " " + n3);
                else
                    Console.Write(n3 + " " + n2);
            }
            else if (n2 > n3 && n2 > n1)
            {
                Console.Write(n2 + " ");
                if (n3 > n1)
                    Console.Write(n3 + " " + n1);
                else
                    Console.Write(n1 + " " + n3);
            }
            else
            {
                Console.Write(n3 + " ");
                if (n1 > n2)
                    Console.Write(n1 + " " + n2);
                else
                    Console.Write(n2 + " " + n1);
            }
        }

        static void exercicio3()
        {

        }
    }
}
