using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RnaCamadaUnica
{
	public class Perceptron
	{
		public List<Entrada> Entradas { get; private set; }
		public Double Bias { get; private set; }
		public double Peso1 { get; private set; }
		public double Peso2 { get; private set; }
		public double TaxaErro { get; private set; }
		public double TaxaAprendizado { get; private set; }


		public Perceptron(double taxaAprendizado)
		{
			Entradas = new List<Entrada>();
			//definir os pesos aleatorios
			Peso1 = 0.89;//aleatorio
			Peso2 = -0.1; //aleatorio
			TaxaAprendizado = taxaAprendizado;

		}

		public double AtualizaPeso(double pesoAntigo,
			double erro,
			double entrada
		)
		{
			return pesoAntigo + TaxaAprendizado * erro * entrada;
		}
		public void Treinamento(List<Entrada> listaEntradas)
		{
			double somatorio = 0;
			int resultado;
			foreach (var item in listaEntradas)
			{
				somatorio = item.X * Peso1 + item.Y * Peso2;
				resultado = FuncaoDegrau(somatorio);
				if (resultado != item.Classe)
				{
					//calcular erro e atualizar os pesos
					int erro = CalcularErro(item.Classe, resultado);
					Peso1 = AtualizaPeso(Peso1, erro, item.X);
					Peso2 = AtualizaPeso(Peso2, erro, item.Y);


				}
				Console.WriteLine(resultado);
			}
			//Console.WriteLine(somatorio);
		}

		public int FuncaoDegrau(double valor)
		{
			return valor >= 0 ? 1 : 0;
		}

		public int CalcularErro(int valorEnsinado, int valorCalculado)
		{
			return valorEnsinado - valorCalculado;
		}

		public int Teste(double x, double y)
		{
			return FuncaoDegrau(x * Peso1 + y * Peso2);
		}


	}
}