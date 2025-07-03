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
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly PortalDbContext _context;

        public UsuarioRepository(PortalDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Usuario> GetAll() => _context.Usuarios.ToList();
        public Usuario GetById(int id) => _context.Usuarios.Find(id);
        public void Add(Usuario rol) => _context.Usuarios.Add(rol);
        public void Update(Usuario rol) => _context.Entry(rol).State = EntityState.Modified;
        public void Delete(Usuario rol) => _context.Usuarios.Remove(rol);
        public void Save() => _context.SaveChanges();
    }
}
