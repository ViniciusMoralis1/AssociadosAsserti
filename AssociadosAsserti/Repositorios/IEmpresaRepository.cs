using AssociadosAsserti.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociadosAsserti.Dominio.Repositorios
{
    public interface IEmpresaRepository
    {
        Empresa GetById(Guid id);

        void Save(Empresa empresa);

        Task<List<Empresa>> GetEmpresas();
    }
}
