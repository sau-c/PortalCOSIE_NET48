using System.ComponentModel.DataAnnotations;

namespace PortalCOSIE.Web.Models
{
    public class IngresarViewModel
    {
        [Required]
        [Display(Name = "Usuario")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Contrase�a")]
        public string Contrasena { get; set; }

        public string MensajeError { get; set; } // opcional
    } 
}