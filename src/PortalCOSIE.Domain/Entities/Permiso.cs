using System.Collections.Generic;

namespace PortalCOSIE.Domain.Entities
{
    public class Permiso : AuditableEntity
    {
        public string Controlador { get; set; }
        public string Accion { get; set; }
        public virtual ICollection<Rol> Roles { get; set; }
        //public virtual ICollection<Rol> Roles { get; set; }
    }
}
