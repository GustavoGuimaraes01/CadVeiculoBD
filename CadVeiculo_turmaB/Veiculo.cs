using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadVeiculo_turmaB
{
    internal class Veiculo
    {
        private string placa, modelo;

        public string Placa { get => placa; set => placa = value; }
        public string Modelo { get => modelo; set => modelo = value; }

        public Veiculo(string placa, string modelo)
        {
            this.placa = placa;
            this.modelo = modelo;
        }
    }
}
