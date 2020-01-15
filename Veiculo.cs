using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca
{
    public abstract class Veiculo
    {

		protected string marca { get; set; }
		protected string placa { get; set; }
		protected string cor { get; set; }
		protected float km { get; set; }
		protected bool isLigado { get; set; }
		protected int litrosCombustivel { get; set; }
		protected int velocidade { get; set; }
		protected double preco { get; set; }



		public void Imprime()
		{
			Console.WriteLine("Marca:" + this.marca + "Placa:" + this.placa + "Cor:" + this.cor + "Km:" + this.km + "Status:" + this.isLigado
				+ "Litros de Combutível:" + this.litrosCombustivel + "Velocidade:" + this.velocidade + "Preço:" + this.preco);


		}
	}
}
