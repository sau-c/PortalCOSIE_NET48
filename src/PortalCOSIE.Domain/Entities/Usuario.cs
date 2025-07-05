namespace PortalCOSIE.Domain.Entities
{
    public class Usuario : AuditableEntity
    {
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string Correo { get; set; }
        public string Celular { get; set; }
        public int RolId { get; set; }

        public virtual Rol Rol { get; set; }
    }
}
