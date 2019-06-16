using AssociadosAsserti.Compartilhado.Entidades;
using AssociadosAsserti.Dominio.ObjetoValor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociadosAsserti.Dominio.Entidades
{
    public class Socio : Entidade
    {

        protected Socio()
        {

        }

        //Construtor de Socio, toda vez que usar new Socio(); passar todos os paramentros
        public Socio(string nome, string cpf, Endereco endereco, Empresa empresa)
        {
            Nome = nome;
            Cpf = cpf;
            Endereco = endereco;
            Empresa = empresa;

            if (String.IsNullOrEmpty(nome))
            {
                throw new Exception("ERRO - Nome nulo ou vazio.");
            }

            if (String.IsNullOrEmpty(Cpf))
            {
                throw new Exception("ERRO - CPF nulo ou vazio.");
            }

            if (endereco.Equals(null))
            {
                throw new Exception("ERRO - Endereço precisa de um valor.");
            }

            if (empresa.Equals(null))
            {
                throw new Exception("ERRO - Empresa precisa de um valor.");
            }
        }

        public string Nome { get; set; }
        public string Cpf { get; set; }
        public Endereco Endereco { get; set; }
        public List<Contato> Contatos { get; set; }
        public Empresa Empresa { get; set; }


        //Método de adição na lista
        public void AddContato(Contato contato)
        {
            //Se a lista Contatos for nula, é criado uma nova Lista e logo após é chamdo o metodo de adicao
            //Incluindo um objeto Contato dentro da lista
            Contatos = Contatos ?? new List<Contato>();
            Contatos.Add(contato);
        }
    }
}