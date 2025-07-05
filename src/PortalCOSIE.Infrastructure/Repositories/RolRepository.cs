using PortalCOSIE.Domain.Entities;
using PortalCOSIE.Domain.Interfaces;
using PortalCOSIE.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;

namespace PortalCOSIE.Infrastructure.Repositories
{
    public class RolRepository : IRepository<Rol>
    {
        private readonly PortalDbContext _context;

        public RolRepository(PortalDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Rol> GetAll() => _context.Roles.Include(r => r.Permisos).ToList();
        public Rol GetById(int id) => _context.Roles.Find(id);
        public void Add(Rol rol) => _context.Roles.Add(rol);
        public void Update(Rol rol) => _context.Entry(rol).State = EntityState.Modified;
        public void Delete(Rol rol) => _context.Roles.Remove(rol);
        public void Save() => _context.SaveChanges();
    }
}
