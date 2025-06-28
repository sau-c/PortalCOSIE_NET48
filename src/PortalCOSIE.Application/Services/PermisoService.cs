using PortalCOSIE.Application.Interfaces;
using PortalCOSIE.Domain.Entities;
using PortalCOSIE.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalCOSIE.Application
{
    public class PermisoService : IPermisoService
    {
        private readonly IPermisoRepository _permisoRepository;

        public PermisoService(IPermisoRepository permisoRepository)
        {
            _permisoRepository = permisoRepository;
        }

        public IEnumerable<Permiso> ListarTodos()
        { 
            return _permisoRepository.GetAll();
        }

        public Permiso ObtenerPorId(int id)
        { 
            return _permisoRepository.GetById(id);
        }

        public void Crear(Permiso permiso)
        {
            _permisoRepository.Add(permiso);
            _permisoRepository.Save();
        }

        public void Actualizar(Permiso permiso)
        {
            _permisoRepository.Update(permiso);
            _permisoRepository.Save();
        }

        public void Eliminar(int id)
        {
            var permiso = _permisoRepository.GetById(id);
            _permisoRepository.Delete(permiso);
            _permisoRepository.Save();
        }
    }
}
