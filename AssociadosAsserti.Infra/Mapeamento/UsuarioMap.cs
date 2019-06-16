using AssociadosAsserti.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociadosAsserti.Infra.Mapeamento
{
    public class UsuarioMap: EntityTypeConfiguration<Usuario>
    {
        public UsuarioMap()
        {
            ToTable("Usuario");
            HasKey(x => x.Id);
            Property(x => x.Nome).IsRequired().HasMaxLength(100);
            Property(x => x.Login).IsRequired().HasMaxLength(50);
            Property(x => x.Senha).IsRequired().HasMaxLength(50);
            Property(x => x.DataAtivacao);
            Property(x => x.DataDesativacao);

        }
    }
}
