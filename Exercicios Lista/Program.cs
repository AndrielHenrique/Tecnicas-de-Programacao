using System;
using System.Collections.Generic;
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
        exercicio1();
        exercicio2();
        exercicio3();
        exercicio4();
    }

    static void exercicio1()
    {
        Console.WriteLine("1) Construa um programa que utilize Lista para armazenar valores inteiros lidos (podem ser positivos ou negativos);\n• Se o usuário digitar 0, a leitura e armazenamento de valores deve terminar;\n• Em seguida, calcule a quantidade de números ímpares e pares informados, bem como suas respectivas somas.");
        int num = 0;
        List<int> inteiros = new List<int>();
        List<int> pares = new List<int>();
        List<int> impares = new List<int>();
        int somaPar = 0, somaImpar = 0;

        do
        {
            Console.WriteLine("Informe um valor para add na lista: ");
            num = Convert.ToInt32(Console.ReadLine());
            if (num != 0)
                inteiros.Add(num);

        } while (num != 0);

        foreach (int i in inteiros)
        {
            if (i % 2 == 0)
            {
                pares.Add(i);
                somaPar += i;
            }
            else
            {
                impares.Add(i);
                somaImpar += i;
            }
        }
        Console.WriteLine("Quantidade de valores pares: " + pares.Count);
        Console.WriteLine("A soma dos numeros pares deu: " + somaPar);

        Console.WriteLine("Quantidade de valores impares: " + impares.Count);
        Console.WriteLine("A soma dos numeros impares deu: " + somaImpar);
    }

    static void exercicio2()
    {
        Console.WriteLine("2) Gere uma lista de números e em seguida peça ao usuário remover um número especificado e mostre a lista após a remoção.");
        List<int> intList = new List<int>(5) { 1, 2, 3, 4, 5 };

        Console.WriteLine("Lista: ");
        for (int i = 0; i < intList.Count; i++)
        {
            Console.Write(intList[i] + " ");
        }
        Console.WriteLine("\nInforme um valor da lista para remover: ");
        int remover = Convert.ToInt32(Console.ReadLine());
        if (intList.Contains(remover))
            intList.Remove(remover);

        Console.WriteLine("Nova lista apos a remoção: ");
        for (int i = 0; i < intList.Count; i++)
        {
            Console.Write(intList[i] + " ");
        }

    }

    static void exercicio3()
    {
        Console.WriteLine();
        Console.WriteLine("3) Dada uma lista de números inteiros, encontre o maior e o menor número.");
        List<int> intList = new List<int>() { 3, 4, 5, 7, 13, 1, 2, 55 };
        Console.WriteLine("Lista: ");
        foreach (int i in intList)
        {
            Console.WriteLine(i + " ");
        }
        intList.Sort();
        int tam = intList.Count;
        Console.WriteLine("Menor valor: " + intList[0]);
        Console.WriteLine("Maior valor: " + intList[tam - 1]);
    }

    static void exercicio4()
    {
        Console.WriteLine("4) Crie uma lista de strings (nomes) e ordene os elementos em ordem alfabética.");
        List<string> stringList = new List<string>();
        string nome = "";
        do
        {
            Console.WriteLine("Informe um nome para add na lista e fim para encerrar: ");
            nome = Console.ReadLine();
            if (nome != "fim")
                stringList.Add(nome);
        } while (nome != "fim");
        Console.WriteLine("Lista: ");
        foreach (string i in stringList)
        {
            Console.Write(i + ", ");
        }

        stringList.Sort();

        Console.WriteLine("\nLista em ordem alfabetica: ");
        foreach (string i in stringList)
        {
            Console.Write(i + ", ");
        }
    }
}
