using AssociadosAsserti.Compartilhado.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociadosAsserti.Dominio.Entidades
{
    public class Profissional : Entidade
    {
        protected Profissional()
        {

        }

        //Construtor de Profissional, toda vez que usar new Profissional(); passar todos os paramentros
        public Profissional(string nome, string cpf, Empresa empresa, string cargo, string empregador)
        {
            Nome = nome;
            Cpf = cpf;
            Empresa = empresa;
            Cargo = cargo;
            Empregador = empregador;

            if (String.IsNullOrEmpty(nome) || String.IsNullOrEmpty(cpf)|| String.IsNullOrEmpty(cargo)|| String.IsNullOrEmpty(empregador))
            {
                throw new Exception("Nome, CPF, empresa, Cargo e Empregador nao pode ser Nulo ou Vazio");
            }

        }

        public string Nome { get; set; }
        public string Cpf { get; set; }
        public Empresa Empresa { get; set; }
        public string Cargo { get; set; }
        public string Empregador { get; set; }
    }
}
