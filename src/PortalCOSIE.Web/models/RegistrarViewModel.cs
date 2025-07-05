using System.ComponentModel.DataAnnotations;

namespace PortalCOSIE.Web.Models
{
    public class RegistrarViewModel
    {
        [Required]
        [Display(Name = "Usuario")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Contrase�a")]
        public string Contrasena { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "ConfirmarContrase�a")]
        public string ConfirmarContrasena { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string ApellidoPaterno { get; set; }

        [Required]
        public string ApellidoMaterno { get; set; }

        [Required]
        [EmailAddress]
        public string Correo { get; set; }

        [Required]
        [Phone]
        public string Celular { get; set; }

        public string MensajeError { get; set; } // opcional
    } 
}