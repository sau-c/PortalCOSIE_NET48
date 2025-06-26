using PortalCOSIE.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalCOSIE.Application.Interfaces
{
    public interface IRolService
    {
        IEnumerable<Rol> GetAll();
        Rol GetById(int id);
        void Create(Rol rol);
        void Update(Rol rol);
        void Delete(int id);
    }
}
