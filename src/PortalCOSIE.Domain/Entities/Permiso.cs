using System.Collections.Generic;

namespace PortalCOSIE.Domain.Entities
{
    public class Permiso : AuditableEntity
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        //public ICollection<Usuario> Usuarios { get; set; }
        public ICollection<Rol> Roles { get; set; }
    }
}
