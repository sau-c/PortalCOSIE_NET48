using System.Collections.Generic;

namespace PortalCOSIE.Domain.Entities
{
    public class Rol : AuditableEntity
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public virtual ICollection<Permiso> Permisos { get; set; }
        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
