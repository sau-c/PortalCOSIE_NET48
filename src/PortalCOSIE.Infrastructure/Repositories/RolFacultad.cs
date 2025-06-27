using PortalCOSIE.Domain.Entities;
using PortalCOSIE.Domain.Interfaces;
using PortalCOSIE.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalCOSIE.Infrastructure.Repositories
{
    public class FacultadRepository : IFacultadRepository
    {
        private readonly PortalDbContext _context;

        public FacultadRepository(PortalDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Facultad> GetAll() => _context.Facultades.ToList();
        public Facultad GetById(int id) => _context.Facultades.Find(id);
        public void Add(Facultad rol) => _context.Facultades.Add(rol);
        public void Update(Facultad rol) => _context.Entry(rol).State = System.Data.Entity.EntityState.Modified;
        public void Delete(Facultad rol) => _context.Facultades.Remove(rol);
        public void Save() => _context.SaveChanges();
    }
}
