using PortalCOSIE.Application;
using PortalCOSIE.Application.Interfaces;
using PortalCOSIE.Application.Interfaces.Common;
using PortalCOSIE.Domain.Entities;
using PortalCOSIE.Domain.Interfaces;
using PortalCOSIE.Infrastructure.Repositories;
using Unity;

namespace PortalCOSIE.Infrastructure.IoC
{
    public static class DependencyContainer
    {
        public static void RegisterTypes(IUnityContainer container)
        {
            // Register services and repositories as needed
            container.RegisterType<IRepository<Rol>, RolRepository>();
            container.RegisterType<IService<Rol>, RolService>();
            
            container.RegisterType<IRepository<Permiso>, PermisoRepository>();
            container.RegisterType<IService<Permiso>, PermisoService>();

            container.RegisterType<IRepository<Usuario>, UsuarioRepository>();
            container.RegisterType<IService<Usuario>, UsuarioService>();
        }
    }
}
