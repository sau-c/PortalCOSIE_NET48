using PortalCOSIE.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalCOSIE.Application.Interfaces
{
    public interface IPermisoService
    {
        IEnumerable<Permiso> ListarTodos();
        Permiso ObtenerPorId(int id);
        void Crear(Permiso facultad);
        void Actualizar(Permiso facultad);
        void Eliminar(int id);
    }
}
