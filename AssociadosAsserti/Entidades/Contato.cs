using AssociadosAsserti.Compartilhado.Entidades;
using AssociadosAsserti.Dominio.ObjetoValor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociadosAsserti.Dominio.Entidades
{
    public class Contato : Entidade
    {
        //ENTITYFRAMEWORK USA 
        protected Contato() {
        }

        //Construtor de Contato, toda vez que usar new Contato(); passar todos os paramentros - Passe um inteiro para o TipoConrato
        public Contato(string descricao, TipoContato tipoContato)
        {
            Descricao = descricao;
            TipoContato = tipoContato; //Email = 0, TelefoneFixo = 1, Celular = 2, Site = 3

            if (String.IsNullOrEmpty(descricao))
            {
                throw new Exception("Descricao nao pode ser Nulo ou Vazio");
            }

        }

        public string Descricao { get; set; }
        public TipoContato TipoContato { get; set; }
    }
}
