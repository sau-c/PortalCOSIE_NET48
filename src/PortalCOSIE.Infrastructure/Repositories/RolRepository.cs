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
    public class RolRepository : IRolRepository
    {
        private readonly PortalDbContext _context;

        public RolRepository(PortalDbContext context)
        {
            _context = context;
        }

        public void Delete(Rol entity) => _context.Rol.Remove(entity);
        public IEnumerable<Rol> GetAll() => _context.Rol.ToList();
        public Rol GetById(int id) => _context.Rol.Find(id);
        public void Insert(Rol entity) => _context.Rol.Add(entity);
        public void Update(Rol entity) => _context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
        public void Save() => _context.SaveChanges();
    }
}
