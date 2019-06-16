
using AssociadosAsserti.Dominio.Entidades;
using AssociadosAsserti.Dominio.Repositorios;
using AssociadosAsserti.Infra.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace DDDCommerce.Infra.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly AssociadosAsserti_AssociadosDataContext _context;

        public UsuarioRepository(AssociadosAsserti_AssociadosDataContext context)
        {
            _context = context;
        }

        public Usuario GetById(Guid id)
        {
            return _context.Usuarios.AsNoTracking().FirstOrDefault(x => x.Id == id);
            //AsNoTracking não faz Cache dos dados da entidade no EF, não fica fazendo histórico 
            //das mudanças da entidade, somente faz a leitura e pronto, performance.
        }

        public Usuario Get(Guid id)
        {
            return _context.Usuarios.AsNoTracking().FirstOrDefault(x => x.Id == id);
        }

        public void Save(Usuario usuario)
        {
            if (!usuario.Valid) return;
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
        }

        public Task<List<Usuario>> GetUsuarios()
        {

            return _context.Usuarios.ToListAsync();
        }
    }
}
