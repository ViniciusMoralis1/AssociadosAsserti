using Flunt.Notifications;
using System;
using System.Collections.Generic;
using System.Text;

namespace AssociadosAsserti.Compartilhado.Entidades
{
    //todas as entidades que herdarem Entidade, terão Id e DataCriacao
    public abstract class Entidade : Notifiable
    {
        protected Entidade()
        {
            Id = Guid.NewGuid();
            DataCriacao = DateTime.Now;
        }

        public Guid Id { get; private set; }
        public DateTime DataCriacao { get; set; }

    }
}
