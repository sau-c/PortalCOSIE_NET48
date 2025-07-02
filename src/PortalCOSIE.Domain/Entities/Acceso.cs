using System.Collections.Generic;

namespace PortalCOSIE.Domain.Entities
{
    public class Acceso
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public string UserName { get; set; }
        public string Contrasena { get; set; }

        public virtual Usuario Usuario { get; set; }
    }
}
