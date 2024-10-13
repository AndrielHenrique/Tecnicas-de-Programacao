using System;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
        // exercicio1();
        // exercicio2();
        // exercicio3();
        // exercicio4();
        exercicio5();
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
        //3) Escreva um algoritmo que leia o código de um determinado produto e mostre a sua classificação. Use a estrutura switch.
        Console.WriteLine("Informe o código do produto: ");
        int cod = Convert.ToInt32(Console.ReadLine());

        switch (cod)
        {
            case 1:
                Console.WriteLine("Alimento não-perecível.");
                break;
            case 2:
            case 3:
            case 4:
                Console.WriteLine("Alimento perecível.");
                break;
            case 5:
            case 6:
                Console.WriteLine("Vestuário.");
                break;
            case 7:
                Console.WriteLine("Higiene Pessoal.");
                break;
            case 8:
            case 9:
            case 10:
            case 11:
            case 12:
            case 13:
            case 14:
            case 15:
                Console.WriteLine("Limpeza.");
                break;
            default:
                Console.WriteLine("Inválido.");
                break;
        }
    }

    static void exercicio4()
    {
        //4. Desenvolva um programa que leia um número inteiro qualquer e informe se o número é par ou ímpar
        Console.WriteLine("Informe um numero: ");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(x % 2 == 0 ? x + " é par" : x + " é impar");
    }

    static void exercicio5()
    {
        //5. Crie um algoritmo que leia a idade de uma pessoa e, caso ela informe 65 anos ou mais escreva
        // “Permitido aposentar”, caso contrário escreva quantos anos faltam para chegar aos 65.

        Console.WriteLine("Informe a idade da pessoa: ");
        int idd = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(idd >= 65 ? "Pode aposentar, ja tem " + idd + " anos" : "Não pode aposentar, faltam " + (65 - idd) + " anos ainda!");
    }
}

