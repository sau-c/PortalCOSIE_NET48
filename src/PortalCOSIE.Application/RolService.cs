using PortalCOSIE.Domain.Entities;
using PortalCOSIE.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalCOSIE.Application
{
    public class RolService
    {
        private readonly IRolRepository _rolRepository;

        public RolService(IRolRepository rolRepository)
        {
            _rolRepository = rolRepository;
        }

        public IEnumerable<Rol> GetAllRoles() => _rolRepository.GetAll();
        public Rol GetRol(int id) => _rolRepository.GetById(id);
        public void CreateRol(Rol rol)
        {
            _rolRepository.Insert(rol);
            _rolRepository.Save();
        }

        public void UpdateRol(Rol rol)
        {
            _rolRepository.Update(rol);
            _rolRepository.Save();
        }

        public void DeleteRol(int id)
        {
            var rol = _rolRepository.GetById(id);
            _rolRepository.Delete(rol);
            _rolRepository.Save();
        }
    }
}
