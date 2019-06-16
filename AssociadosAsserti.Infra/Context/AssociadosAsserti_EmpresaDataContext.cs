using AssociadosAsserti.Dominio.Entidades;
using AssociadosAsserti.Infra.Mapeamento;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociadosAsserti.Infra.Context
{
    public class AssociadosAsserti_AssociadosDataContext : DbContext
    {
        public AssociadosAsserti_AssociadosDataContext() : base(@"passar aqui sua conexao com o BD")
        {
            Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<Socio> Socios { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Profissional> Profissionais { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new EmpresaMap());
            modelBuilder.Configurations.Add(new SocioMap());
            modelBuilder.Configurations.Add(new UsuarioMap());
            modelBuilder.Configurations.Add(new ProfissionalMap());

        }
    }
}
