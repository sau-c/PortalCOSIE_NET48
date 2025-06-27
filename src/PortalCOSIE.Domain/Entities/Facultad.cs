namespace PortalCOSIE.Domain.Entities
{
    public class Facultad : AuditableEntity
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        //public ICollection<Usuario> Usuarios { get; set; }
        //public ICollection<FacultadRol> Facultades { get; set; }
    }
}
