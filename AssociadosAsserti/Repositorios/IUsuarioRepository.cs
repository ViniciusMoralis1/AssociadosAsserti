using AssociadosAsserti.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociadosAsserti.Dominio.Repositorios
{
    public interface IUsuarioRepository
    {
        Usuario GetById(Guid id);

        void Save(Usuario usuario);

        Task<List<Usuario>> GetUsuarios();
    }
}
