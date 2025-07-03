using PortalCOSIE.Domain.Entities;
using PortalCOSIE.Domain.Interfaces;
using PortalCOSIE.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace PortalCOSIE.Infrastructure.Repositories
{
    public class PermisoRepository : IPermisoRepository
    {
        private readonly PortalDbContext _context;

        public PermisoRepository(PortalDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Permiso> GetAll() => _context.Permisos.ToList();
        public Permiso GetById(int id) => _context.Permisos.Find(id);
        public void Add(Permiso rol) => _context.Permisos.Add(rol);
        public void Update(Permiso rol) => _context.Entry(rol).State = EntityState.Modified;
        public void Delete(Permiso rol) => _context.Permisos.Remove(rol);
        public void Save() => _context.SaveChanges();
    }
}
