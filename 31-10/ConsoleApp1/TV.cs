using System;

public class TV
{
	public boolean Ligada { get; set; }
	public int Volume { get; set; }
	public string Canais { get; set; }
	public int Polegadas { get; set; }
	public string Marca { get; set; }
	public TV(boolean ligada, int volume, string canais, int polegadas, string marca)
	{
		Ligada = false;
		Volume = volume;
		Canais = canais;
		Polegadas = polegadas;
		Marca = marca;
	}

	public void Ligar()
	{
		if (!Ligada)
		{
			Ligada = true;
			Console.WriteLine("A TV foi ligada!");
		}
		else
			Console.WriteLine("A tv ja estava ligada!");
	}
	public void Desligar()
	{
		if (Ligada)
		{
			Ligada = false;
			Console.WriteLine("A TV foi desligada!");
		}
		else
			Console.WriteLine("A TV ja esta desligada!");
	}

	public void AumentarVolume()
	{
		if (Ligada)
		{
			Volume++;
			Console.WriteLine("O volume da TV aumentou e esta em " + Volume);
		}
		else
			Console.WriteLine("A TV esta desligada, nao da para aumentar o volume");
		
	}

	public void DiminuirVolume()
	{
		if(Ligada && Volume > 0) {
			Volume--;
            Console.WriteLine("O volume da TV diminuiu e esta em " + Volume);
        }
		Console.WriteLine("A TV esta desligada ou o volume ja esta em 0");
    }

	public void StatusTV()
	{
		string status = Ligada ? "ligado" : "desligado";
		Console.WriteLine($"A TV esta {status}");
	}
}
