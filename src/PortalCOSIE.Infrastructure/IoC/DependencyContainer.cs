using PortalCOSIE.Application;
using PortalCOSIE.Application.Interfaces;
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
            container.RegisterType<IRolRepository, RolRepository>();
            container.RegisterType<IRolService, RolService>();
            
            container.RegisterType<IFacultadRepository, FacultadRepository>();
            container.RegisterType<IFacultadService, FacultadService>();
        }
    }
}
