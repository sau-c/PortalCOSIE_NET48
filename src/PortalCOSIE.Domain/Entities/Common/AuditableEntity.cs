using System;

namespace PortalCOSIE.Domain.Entities
{
    public class AuditableEntity
    {
        //public int Id { get; set; }
        public DateTime Creado { get; set; }
        public string CreadoPor { get; set; }
        public DateTime Actualizado { get; set; }
        public string ActualizadoPor { get; set; }
    }
}
