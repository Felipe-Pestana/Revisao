using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao
{
    internal class Endereco
    {
        string logradouro;
        int numero;

        public Endereco()
        {

        }

        public void setLogradouro(string logradouro)
        {
            this.logradouro = logradouro;
        }

        public void setNumero(int numero)
        {
            this.numero = numero;
        }

        public override string ToString()
        {
            return $"Logradouro: {this.logradouro}, {this.numero}";
        }
    }
}
