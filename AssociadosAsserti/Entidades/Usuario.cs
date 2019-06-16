using AssociadosAsserti.Compartilhado.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociadosAsserti.Dominio.Entidades
{
    public class Usuario : Entidade 
    {

        protected Usuario()
        {

        }

        //Construtor de Usuario, toda vez que usar new Usuario(); passar todos os paramentros
        public Usuario(string nome, string login, string senha, Boolean ativo, DateTime dataAtivacao)
        {
            Nome = nome;
            Login = login;
            Senha = senha;
            Ativo = ativo;
            DataAtivacao = dataAtivacao;
            //DataDesativacao = dataDesativacao;

            if (String.IsNullOrEmpty(nome))
            {
                throw new Exception("Nome nao pode ser Nulo ou Vazio");
            }

            if (String.IsNullOrEmpty(login))
            {
                throw new Exception("Login nao pode ser Nulo ou Vazio");
            }

            if (String.IsNullOrEmpty(senha))
            {
                throw new Exception("Senha nao pode ser Nulo ou Vazio");
            }

          
        }

        public string Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public Boolean Ativo { get; set; }

        public DateTime DataAtivacao { get; set; }
        public DateTime DataDesativacao { get; set; }
    }
}
