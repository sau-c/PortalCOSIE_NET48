using PortalCOSIE.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalCOSIE.Application.Interfaces
{
    public interface IUsuarioService
    {
        IEnumerable<Usuario> ListarTodos();
        Usuario ObtenerPorId(int id);
        void Crear(Usuario usuario);
        void Actualizar(Usuario usuario);
        void Eliminar(int id);
    }
}
