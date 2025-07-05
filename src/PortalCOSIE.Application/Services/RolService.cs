using PortalCOSIE.Application.Interfaces.Common;
using PortalCOSIE.Domain.Entities;
using PortalCOSIE.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalCOSIE.Application
{
    public class RolService : IService<Rol>
    {
        private readonly IRepository<Rol> _rolRepository;

        public RolService(IRepository<Rol> rolRepository)
        {
            _rolRepository = rolRepository;
        }

        public IEnumerable<Rol> ListarTodos()
        { 
            return _rolRepository.GetAll();
        }

        public Rol ObtenerPorId(int id)
        { 
            return _rolRepository.GetById(id);
        }

        public void Crear(Rol rol)
        {
            _rolRepository.Add(rol);
            _rolRepository.Save();
        }

        public void Actualizar(Rol rol)
        {
            _rolRepository.Update(rol);
            _rolRepository.Save();
        }

        public void Eliminar(int id)
        {
            var rol = _rolRepository.GetById(id);
            _rolRepository.Delete(rol);
            _rolRepository.Save();
        }
    }
}
