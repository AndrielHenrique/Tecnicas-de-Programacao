using System;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        exercicio1();
    }
    static void exercicio1()
    {
        int[] valores = new int[10];
        float media = 0;
        int TAM = 10;

        foreach (int i in valores)
        {

            Console.WriteLine("Informe o " + (i + 1) + "valor: ");
            valores[i] = Convert.ToInt32(Console.ReadLine());
            media += valores[i];

        }
        Console.WriteLine(media);

        Console.WriteLine($"A media dos valores deu: {media / TAM}");
    }
}
