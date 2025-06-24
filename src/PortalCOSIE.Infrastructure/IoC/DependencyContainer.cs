using PortalCOSIE.Application;
using PortalCOSIE.Domain.Interfaces;
using PortalCOSIE.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace PortalCOSIE.Infrastructure.IoC
{
    public static class DependencyContainer
    {
        public static void RegisterTypes(IUnityContainer container)
        {
            container.RegisterType<IRolRepository, RolRepository>();
            container.RegisterType<RolService>();
        }
    }
}
