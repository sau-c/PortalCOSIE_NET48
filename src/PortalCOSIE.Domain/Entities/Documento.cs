﻿namespace PortalCOSIE.Domain.Entities
{
    public class Documento : AuditableEntity
    {
        public string Nombre { get; set; }
        public string Comentario { get; set; }
        public int TramiteId { get; set; }

        public virtual Tramite Tramite { get; set; }
    }
}
