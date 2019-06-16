using AssociadosAsserti.Infra.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociadosAsserti.Infra.Trasacoes
{
    public class Uow : IUow
    {
        private readonly AssociadosAsserti_AssociadosDataContext _context;

        public Uow (AssociadosAsserti_AssociadosDataContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Rollback()
        {
            throw new NotImplementedException("IRMAO NAO PRECISA IMPLEMENTAR");
        }
    }
}
