using AssociadosAsserti.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociadosAsserti.Infra.Mapeamento
{
    public class ProfissionalMap: EntityTypeConfiguration<Profissional>
    {
        public ProfissionalMap()
        {
            ToTable("Profissional");
            HasKey(x => x.Id);
            Property(x => x.Nome).IsRequired().HasMaxLength(100);
            Property(x => x.Cpf).IsRequired().HasMaxLength(14);
            Property(x => x.Cargo).IsRequired();
            Property(x => x.Empregador);
            Property(x => x.Empresa.Id);  //pega o Id da Empresa
            Property(x => x.DataCriacao);
        }
    }
}
