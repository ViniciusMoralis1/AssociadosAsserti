using AssociadosAsserti.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociadosAsserti.Infra.Mapeamento
{
    public class SocioMap: EntityTypeConfiguration<Socio>
    {
        public SocioMap()
        {
            ToTable("Socio");
            HasKey(x => x.Id);
   
            Property(x => x.Cpf).IsRequired().HasMaxLength(14);
            Property(x => x.Empresa.Id);
            Property(x => x.Nome);
            Property(x => x.DataCriacao);

            Property(x => x.Endereco.Bairro).HasMaxLength(100);
            Property(x => x.Endereco.Cep).HasMaxLength(20);
            Property(x => x.Endereco.Cidade).HasMaxLength(100);
            Property(x => x.Endereco.Estado).HasMaxLength(2);
            Property(x => x.Endereco.Logradouro).HasMaxLength(150);
            Property(x => x.Endereco.Numero).HasMaxLength(20);

        }
    }
}
