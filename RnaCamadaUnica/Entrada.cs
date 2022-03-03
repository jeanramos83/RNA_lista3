using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RnaCamadaUnica
{
	public class Entrada
	{
		public Entrada(double x, double y, int classe)
		{
			X = x;
			Y = y;
			Classe = classe;
		}

		public double X { get; private set; }
		public double Y { get; private set; }
		public int Classe { get; private set; }


	}
}
