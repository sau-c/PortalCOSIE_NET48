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
    public class UsuarioService : IService<Usuario>
    {
        private readonly IRepository<Usuario> _usuarioRepository;

        public UsuarioService(IRepository<Usuario> rolRepository)
        {
            _usuarioRepository = rolRepository;
        }

        public IEnumerable<Usuario> ListarTodos()
        { 
            return _usuarioRepository.GetAll();
        }

        public Usuario ObtenerPorId(int id)
        { 
            return _usuarioRepository.GetById(id);
        }

        public void Crear(Usuario usuario)
        {
            _usuarioRepository.Add(usuario);
            _usuarioRepository.Save();
        }

        public void Actualizar(Usuario usuario)
        {
            _usuarioRepository.Update(usuario);
            _usuarioRepository.Save();
        }

        public void Eliminar(int id)
        {
            var usuario = _usuarioRepository.GetById(id);
            _usuarioRepository.Delete(usuario);
            _usuarioRepository.Save();
        }
    }
}
