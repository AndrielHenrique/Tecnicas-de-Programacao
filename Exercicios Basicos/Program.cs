using System;

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
        Console.WriteLine("1. Desenvolva uma calculadora que leia dois números do usuário (double) e em seguida imprima a soma, subtração, multiplicação e divisão do primeiro pelo segundo.");
        double n1 = 0, n2 = 0;
        Console.WriteLine("Calculadora Simples:\nInforme o primeiro numero: ");
        n1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Informe o segundo numero: ");
        n2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Primeiro valor é: " + n1 + "\nSegundo valor é: " + n2 + "\nSoma: " + (n1 + n2) + "\nSubtração: " + (n1 - n2) + "\nMultiplicação: " + (n1 * n2) + "\nDivisão: " + (n1 / n2));
    }

    static void exercicio2()
    {
        Console.WriteLine("2. Crie programa que leia o raio de uma circunferência e então calcule sua área e a apresente.");
        Console.WriteLine("Informe o raio da circunferência: ");
        double r = Convert.ToDouble(Console.ReadLine());
        double area = (Math.PI * Math.Pow(r, 2));
        Console.WriteLine("A área da circunferência é: " + area);
    }

    static void exercicio3()
    {
        Console.WriteLine("3. Leia as medidas dos catetos de um triângulo retângulo e calcule a medida da hipotenusa.");
        Console.WriteLine("Informe a medida do cateto A do triângulo retângulo: ");
        double catetoA = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("informe a medida do cateto B do triângulo retângulo: ");
        double catetoB = Convert.ToDouble(Console.ReadLine());

        double h = Math.Sqrt(Math.Pow(catetoA, 2) + Math.Pow(catetoB, 2));
        Console.WriteLine("Hipotenusa do triangulo retangulo: " + h);
    }

    static void exercicio4()
    {
        Console.WriteLine("4. Leia a altura e o raio de uma lata de óleo e calcule seu volume.");
        Console.WriteLine("Informe a altura da lata de óleo: ");
        double h = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Informe o raio da lata de óleo: ");
        double r = Convert.ToDouble(Console.ReadLine());

        double v = (Math.PI * Math.Pow(r, 2) * h);
        Console.WriteLine("O volume do cilindro de altura " + h + " e raio " + r + " é = " + v);

    }
}

