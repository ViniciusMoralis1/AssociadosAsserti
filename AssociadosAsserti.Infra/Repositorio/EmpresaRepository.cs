
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
    public class EmpresaRepository : IEmpresaRepository
    {
        private readonly AssociadosAsserti_AssociadosDataContext _context;

        public EmpresaRepository(AssociadosAsserti_AssociadosDataContext context)
        {
            _context = context;
        }

        public Empresa GetById(Guid id)
        {
            return _context.Empresas.AsNoTracking().FirstOrDefault(x => x.Id == id);
            //AsNoTracking não faz Cache dos dados da entidade no EF, não fica fazendo histórico 
            //das mudanças da entidade, somente faz a leitura e pronto, performance.
        }

        public Empresa Get(Guid id)
        {
            return _context.Empresas.AsNoTracking().FirstOrDefault(x => x.Id == id);
        }

        public void Save(Empresa empresa)
        {
            if (!empresa.Valid) return;
            _context.Empresas.Add(empresa);
            _context.SaveChanges();
        }

        public Task<List<Empresa>> GetEmpresas()
        {

            return _context.Empresas.ToListAsync();
        }
    }
}
