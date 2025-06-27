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
    public class FacultadService : IFacultadService
    {
        private readonly IFacultadRepository _facultadRepository;

        public FacultadService(IFacultadRepository facultadRepository)
        {
            _facultadRepository = facultadRepository;
        }

        public IEnumerable<Facultad> ListarTodos()
        { 
            return _facultadRepository.GetAll();
        }

        public Facultad ObtenerPorId(int id)
        { 
            return _facultadRepository.GetById(id);
        }

        public void Crear(Facultad facultad)
        {
            _facultadRepository.Add(facultad);
            _facultadRepository.Save();
        }

        public void Actualizar(Facultad facultad)
        {
            _facultadRepository.Update(facultad);
            _facultadRepository.Save();
        }

        public void Eliminar(int id)
        {
            var facultad = _facultadRepository.GetById(id);
            _facultadRepository.Delete(facultad);
            _facultadRepository.Save();
        }
    }
}
