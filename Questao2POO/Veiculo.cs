using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao2POO
{
    public abstract class Veiculo
    {//classe mãe

        private string placa;
        private int ano;


        protected Veiculo(string placa , int ano) 
        {
            this.placa = placa;
            this.ano = ano;
        
        }
        protected string Placa { get => placa; set => placa = value; }
        protected int Ano { get => ano; set => ano = value; }
    }
}
