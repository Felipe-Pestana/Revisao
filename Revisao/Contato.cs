using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao
{
    internal class Contato
    {
        string nome;
        string telefone;
        Endereco endereco;

        public Contato()
        {
            this.endereco = new Endereco();
        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public string getNome()
        {
            return this.nome;
        }

        public void setTelefone(string telefone)
        {
            this.telefone = telefone;
        }

        public void setEndereco(string logradouro, int numero)
        {
            endereco.setLogradouro(logradouro);
            endereco.setNumero(numero);
        }

        public override string ToString()
        {
            return $"Nome: {this.nome} \nTelefone: {this.telefone} \n{this.endereco.ToString()}";
        }
    }
}
