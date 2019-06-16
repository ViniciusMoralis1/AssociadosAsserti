
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
    public class SocioRepository : ISocioRepository
    {
        private readonly AssociadosAsserti_AssociadosDataContext _context;

        public SocioRepository(AssociadosAsserti_AssociadosDataContext context)
        {
            _context = context;
        }

        public Socio GetById(Guid id)
        {
            return _context.Socios.AsNoTracking().FirstOrDefault(x => x.Id == id);
            //AsNoTracking não faz Cache dos dados da entidade no EF, não fica fazendo histórico 
            //das mudanças da entidade, somente faz a leitura e pronto, performance.
        }

        public Socio Get(Guid id)
        {
            return _context.Socios.AsNoTracking().FirstOrDefault(x => x.Id == id);
        }

        public void Save(Socio usuario)
        {
            if (!usuario.Valid) return;
            _context.Socios.Add(usuario);
            _context.SaveChanges();
        }

        public Task<List<Socio>> GetSocios()
        {

            return _context.Socios.ToListAsync();
        }
    }
}
