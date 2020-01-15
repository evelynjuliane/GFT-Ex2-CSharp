using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca
{
    class Aviao : Veiculo
    {
        private string tipo { get; set; }
        private string uso { get; set; }
		public Aviao(string marca, string placa, string cor, float km, bool isLigado,
				int litrosCombustivel, int velocidade, double preco, string tipo, string uso){
			this.marca = marca;
			this.placa = placa;
			this.cor = cor;
			this.km = km;
			this.isLigado = isLigado;
			this.litrosCombustivel = litrosCombustivel;
			this.velocidade = velocidade;
			this.preco = preco;
			this.tipo = tipo;
			this.uso = uso;
		}

		public void imprime()
		  {
			  base.Imprime();
			  Console.WriteLine("Tipo: " + tipo + "\nUso:" + uso);
		  }
		  
	}
}
