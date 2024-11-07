using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public class Chuva
{
	public string Intensidade { get; set; }
	public double Horas { get; set; }
	public string Localizacao { get; set; }
	public int Probabilidade { get; set; }
	public double Volume { get; set; }
	public bool Chovendo { get; set; }

	public Chuva(string Intensidade, double Horas, string Localizacao, int Probabilidade, double Volume, bool chovendo)
	{
		Intensidade = Intensidade;
		Horas = Horas;		
		Localizacao = Localizacao;	
		Probabilidade = Probabilidade;
        Volume = Volume;
		this.Chovendo = false;
    }

	public void Iniciar()
	{
		Chovendo = true;
		Console.WriteLine($"Chuva iniciando em {Localizacao} com intensidade{Intensidade}.");
	}

	public void Parar()
	{
		string parar = Chovendo ? "A chuva parou!" : "Nao ta chovendo para parar!";
		Console.WriteLine(parar);
	}

	public void AumentarIntensidade()
	{
		Intensidade = "forte";
		Console.WriteLine($"A intensidade da chuva esta {Intensidade}");
	}

	public void DiminuirIntensidade()
	{
		Intensidade = "leve";
		Console.WriteLine($"A intensidade da chuva esta {Intensidade}.");
	}

	public void ExibirStatus()
	{
		Console.WriteLine($"Status da chuva: Intensidade - {Intensidade}, Duracao - {Duracao}, Localizacao - {Localizacao}, Probabilidade - {Probabilidade}, Volume - {Volume}");
	}

}
