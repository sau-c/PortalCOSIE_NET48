using System.Collections.Generic;

namespace PortalCOSIE.Domain.Entities
{
    public class Permiso : AuditableEntity
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public virtual ICollection<Rol> Roles { get; set; }
        //public virtual ICollection<Rol> Roles { get; set; }
    }
}
