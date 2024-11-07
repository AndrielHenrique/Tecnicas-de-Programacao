using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public class Chuveiro
{
	public string Marca { get; set; }
	public double Temperatura { get; set; }
	public bool Ligado { get; set; }
	public string Modo { get; set; }
	public string Pressao { get; set; }
	public Chuveiro(string Marca, double Temperatura, bool Ligado, string Modo, string Pressao)
	{
		Marca = Marca;
		Temperatura = Temperatura;
		Ligado = Ligado;
		Modo = Modo;
		Pressao = Pressao;
	}

	public void Ligado()
	{
		if (!Ligado)
		{
			Ligado = true;
			Console.WriteLine("Chuveiro ligado!");
		}
		else
			Console.WriteLine("Chuveiro ja esta ligado");
	}

	public void Desligar()
	{
		if (Ligado)
		{
			Ligado = false;
			Console.WriteLine("Chuveiro desligado! Tempo de uso (" + TempoUso + ")minutos!");
			TempoUso = 0;
		}
		else
			Console.WriteLine("Chuveiro ja esta desligado!");
	}
	public void AumentarTemperatura()
	{
		if (Ligado)
		{
			Temperatura++;
			Console.WriteLine($"Temperatura foi aumentada para {Temperatura}°C.");
		}
		else
			Console.WriteLine("Chuveiro esta desligado!");
	}

	public void DiminuirTemperatura()
	{
		if (Ligado && Temperatura > 0)
		{
				Temperatura--;
            Console.WriteLine($"Temperatura foi diminuida para {Temperatura}°C.");
        }
		else
            Console.WriteLine("Chuveiro esta desligado! ou A temperatura ja esta em 0");
    }

	public void ChuveiroStatus()
	{
		string status = Ligado ? "ligado" : "desligado";
		Console.WriteLine("O chuveiro esta " + status);
	}
}
