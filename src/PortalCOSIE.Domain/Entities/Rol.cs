using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalCOSIE.Domain.Entities
{
    [Table("Rol")]
    public class Rol
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string Nombre { get; set; }
        [MaxLength(200)]
        public string Descripcion { get; set; }

        //public ICollection<Usuario> Usuarios { get; set; }
        //public ICollection<FacultadRol> Facultades { get; set; }
    }
}
