using AssociadosAsserti.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociadosAsserti.Dominio.Repositorios
{
    public interface ISocioRepository
    {
        Socio GetById(Guid id);

        void Save(Socio socio);

        Task<List<Socio>> GetSocios();
    }
}
