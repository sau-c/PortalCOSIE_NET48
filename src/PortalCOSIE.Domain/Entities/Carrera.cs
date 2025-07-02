namespace PortalCOSIE.Domain.Entities
{
    public class Carrera : AuditableEntity
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
    }
}
