using System;

public class CaixaDeSom
{
	public string Marca {  get; set; }
	public string Volume { get; set; }
	public bool Ligado { get; set; }
	public string Tamanho { get; set; }
	public string Largura { get; set; }
	public CaixaDeSom(string marca, string volume, bool ligado, string tamanho, string largura)
	{
		Marca = marca;
		Volume = false;
		Ligado = ligado;
		Tamanho = tamanho;
		Largura = largura;
	}

	public void Ligar()
	{
		if (!Ligado)
		{
			Ligado = true;
			Console.WriteLine("A caixa de som foi ligada");
		}
		else
			Console.WriteLine("A caixa de som ja estava ligada");
	}

	public void Desligar()
	{
		if(Ligado)
		{
			Ligado = false;
            Console.WriteLine("A caixa de som foi desligada");
        }
        else
            Console.WriteLine("A caixa de som ja estava desligada");
    }

	public void AumentarVolume()
	{
        if (Ligada)
        {
            Volume++;
            Console.WriteLine("O volume da caixa de som aumentou e esta em " + Volume);
        }
        else
            Console.WriteLine("A caixa de som esta desligada, nao da para mexer no volume");
    }
    public void DiminuirVolume()
    {
        if (Ligada && Volume > 0)
        {
            Volume--;
            Console.WriteLine("O volume da caixa de som diminuiu e esta em " + Volume);
        }
        else
            Console.WriteLine("A caixa de som esta desligada, nao da para mexer no volume");
    }

    public void StatusCaixaDeSom()
    {
        string status = Ligado ? "ligado" : "desligado";
        Console.WriteLine($"A caixa de som esta {status}");
    }
}
