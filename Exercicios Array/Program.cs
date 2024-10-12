using System;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        exercicio1();
        exercicio2();
        exercicio3();

        int[,] matriz = new int[,]{
            { 1, 0, 0, 0, 0 },
            { 0, 1, 0, 0, 0 },
            { 0, 0, 1, 0, 0 },
            { 0, 0, 0, 1, 0 },
            { 0, 0, 0, 0, 1 }
        };
        int[,] matrizNIdentidade = new int[,]{
            { 1, 2, 0, 0, 0 },
            { 0, 1, 0, 0, 0 },
            { 0, 0, 1, 1, 0 },
            { 0, 0, 0, 1, 0 },
            { 0, 0, 0, 0, 1 }
        };
        exercicio4(matriz);
        exercicio4(matrizNIdentidade);

        exercicio5();

    }
    static void exercicio1()
    {
        Console.WriteLine("Exercicio 1 - Faça um programa em C# que leia um array unidimensional de tamanho 10 e calcule e exiba a média dos valores informados. ");
        int[] valores = new int[10];
        float media = 0;
        int TAM = 10;

        for (int i = 0; i < valores.Length; i++)
        {
            Console.WriteLine("Informe o " + (i + 1) + " valor: ");
            valores[i] = Convert.ToInt32(Console.ReadLine());
            media += valores[i];

        }
        Console.WriteLine("A media deu: " + media);

        Console.WriteLine($"A media dos valores deu: {media / TAM}");
    }

    static void exercicio2()
    {
        Console.WriteLine("Exercicio 2 - Faça um programa em C# que leia um array unidimensional (tamanho 10) de inteiros e determine quais dos valores lidos são primos");

        int[] valores = new int[10];

        for (int i = 0; i < valores.Length; i++)
        {
            Console.WriteLine("informe o " + (i + 1) + " valor: ");
            valores[i] = Convert.ToInt32(Console.ReadLine());

        }
        foreach (int v in valores)
        {
            bool ehPrimo = true;
            int j = 2;
            while (j <= v / 2)
            {
                if (v % j == 0)
                {
                    ehPrimo = false;
                    break;
                }
                j++;
            }
            if (ehPrimo)
                Console.WriteLine(v + " é primo!");
        }
    }

    static void exercicio3()
    {
        Console.WriteLine("3.Faça um programa em C# que seja capaz de ler uma matriz 5x5 de inteiros. Após a leitura da matriz, calcule e exiba: \n• O total da soma de cada linha\n• A média de valores de cada linha\n• O total da soma de cada coluna\n• A média de valores de cada coluna\n• O total da soma da matriz toda\n• A média de valores da matriz toda");
        int[,] matriz = new int[5, 5];
        int somaLinha = 0, somaColuna = 0, somaTotal = 0;
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.WriteLine("Digite o valor para preencher a linha [" + i + "] e a coluna [" + j + "]:");
                matriz[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.WriteLine("\nMatriz preenchida: ");
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }

        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            somaLinha = 0;
            for (int j = 0; j < matriz.GetLength(1); j++)
                somaLinha += matriz[i, j];

            Console.WriteLine("Soma da linha [" + i + "]: " + somaLinha);
            Console.WriteLine("Média da soma da linha [" + i + "]: " + (float)somaLinha / matriz.GetLength(1));
            Console.WriteLine();
        }


        for (int i = 0; i < matriz.GetLength(1); i++)
        {
            somaColuna = 0;
            for (int j = 0; j < matriz.GetLength(0); j++)
                somaColuna += matriz[i, j];

            Console.WriteLine("Soma das Coluna [" + i + "]: " + somaColuna);
            Console.WriteLine("Media da soma das Colunas[" + i + "]: " + (float)somaColuna / matriz.GetLength(0));
            Console.WriteLine();
        }
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                somaTotal += matriz[i, j];
            }
        }

        int TAM = 25;
        Console.WriteLine("Soma total da matriz: " + somaTotal);
        Console.WriteLine("Media total da matriz: " + (float)somaTotal / TAM);
    }

    static void exercicio4(int[,] matriz)
    {
        Console.WriteLine("Exercicio 4 - Faça um programa em C# que leia uma matriz 5x5 de inteiros e, em seguida, determine se a matriz lida é uma matriz identidade");

        bool ehIdentidade = true;
        if (matriz.GetLength(0) != matriz.GetLength(1))
            ehIdentidade = false;
        else
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        if (matriz[i, j] != 1)
                        {
                            ehIdentidade = false;
                            break;
                        }
                    }
                    else
                    {
                        if (matriz[i, j] != 0)
                        {
                            ehIdentidade = false;
                            break;
                        }
                    }
                }
                if (!ehIdentidade) break;
            }
        }
        if (ehIdentidade)
            Console.WriteLine("É uma matriz identidade.");
        else
        {
            Console.WriteLine("Nao é uma matriz identidade.");
        }

    }

    static void exercicio5()
    {
        Console.WriteLine("5. Faça um programa em C# que leia uma matriz de tamanho NxM quaisquer (vocês podem definir M e N). Em seguida, crie a matriz transposta à matriz lida. Exiba ambas.\n• Seja A uma matriz, A^t é a inversão de linhas e colunas de A.Assim, se A é uma matriz 3x2, A^t será uma matriz 2x3");

        Console.WriteLine("Informe o numero de linhas da Matriz: ");
        int nLinhas = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Informe o numero de colunas da Matriz: ");
        int nColunas = Convert.ToInt32(Console.ReadLine());

        int[,] matriz = new int[nLinhas, nColunas];
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.WriteLine("Informe um valor para a linha [" + i + "] e para a coluna [" + j + "]: ");
                matriz[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        int[,] matrizT = new int[nColunas, nLinhas];

        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                matrizT[j, i] = matriz[i, j];
            }
        }
        Console.WriteLine("Matriz: ");
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine("Matriz Transposta: ");
        for (int i = 0; i < matrizT.GetLength(0); i++)
        {
            for (int j = 0; j < matrizT.GetLength(1); j++)
            {
                Console.Write(matrizT[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

}