using PortalCOSIE.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalCOSIE.Application.Interfaces
{
    public interface IFacultadService
    {
        IEnumerable<Facultad> ListarTodos();
        Facultad ObtenerPorId(int id);
        void Crear(Facultad facultad);
        void Actualizar(Facultad facultad);
        void Eliminar(int id);
    }
}
