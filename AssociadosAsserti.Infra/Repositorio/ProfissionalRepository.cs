
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
    public class ProfissionalRepository : IProfissionalRepository
    {
        private readonly AssociadosAsserti_AssociadosDataContext _context;

        public ProfissionalRepository(AssociadosAsserti_AssociadosDataContext context)
        {
            _context = context;
        }

        public Profissional GetById(Guid id)
        {
            return _context.Profissionais.AsNoTracking().FirstOrDefault(x => x.Id == id);
            //AsNoTracking não faz Cache dos dados da entidade no EF, não fica fazendo histórico 
            //das mudanças da entidade, somente faz a leitura e pronto, performance.
        }

        public Profissional Get(Guid id)
        {
            return _context.Profissionais.AsNoTracking().FirstOrDefault(x => x.Id == id);
        }

        public void Save(Profissional empresa)
        {
            if (!empresa.Valid) return;
            _context.Profissionais.Add(empresa);
            _context.SaveChanges();
        }

        public Task<List<Profissional>> GetProfissionais()
        {

            return _context.Profissionais.ToListAsync();
        }
    }
}
