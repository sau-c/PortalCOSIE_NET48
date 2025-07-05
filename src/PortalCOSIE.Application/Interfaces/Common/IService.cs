using PortalCOSIE.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalCOSIE.Application.Interfaces.Common
{
    public interface IService<T> where T : class
    {
        IEnumerable<T> ListarTodos();
        T ObtenerPorId(int id);
        void Crear(T entidad);
        void Actualizar(T entidad);
        void Eliminar(int id);
    }
}
