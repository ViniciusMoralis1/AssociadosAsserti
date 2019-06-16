using AssociadosAsserti.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociadosAsserti.Dominio.Repositorios
{
    public interface IProfissionalRepository
    {
        Profissional GetById(Guid id);

        void Save(Profissional profissional);

        Task<List<Profissional>> GetProfissionais();
    }
}
