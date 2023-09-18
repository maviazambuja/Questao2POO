using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao2POO
{//classe filha
    class Onibus :   Veiculo
    {

        private int Assentos;

        public Onibus(string Placa, int Ano, int Assentos) : base(Placa, Ano)
        {
            this.Assentos = Assentos;

        }

        public int Assentos1 { get => Assentos; set => Assentos = value; }

        public override double CalculoAluguel()
        {
            double diaria;
            diaria = (30 * Assentos)-(2023 - Ano) * 70;
            return diaria;
        }

      
    }
}
