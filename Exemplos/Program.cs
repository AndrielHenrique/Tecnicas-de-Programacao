internal class Program
{
    private static void Main(string[] args)
    {
        //exemplo1();
        lambda();

    }
    static void exemplo1()
    {
        int num = 0, soma = 0;
        List<int> intList = new List<int>();

        do
        {
            Console.WriteLine("Informe um numero inteiro positivo: ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num > 0)
                intList.Add(num);

        } while (num > 0);

        foreach (int x in intList)
        {
            soma += x;
        }

        Console.WriteLine($"Quantidade de valores informados: {intList.Count}");

        if (intList.Count > 0)
            Console.WriteLine($"Media dos valores informados: {Convert.ToDouble(soma) / intList.Count}");
    }

    static void lambda()
    {
        List<string> disciplinas = new List<string>();
        List<string> discProg = new List<string>();

        string disc = String.Empty;

        do
        {
            Console.Write("Informe um nome da Disciplina: ");
            disc = Console.ReadLine();

            if (disc.ToUpper() != "FIM") 
                 disciplinas.Add(disc);

        } while (disc.ToUpper() != "FIM");

        discProg = disciplinas.FindAll(d => d.ToUpper().Contains("PROG"));

        Console.WriteLine("Disciplins de programação: ");

        foreach (string d in discProg)
            Console.WriteLine(d);
            
    }
}