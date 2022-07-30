using System.ComponentModel.DataAnnotations;

namespace Prueba_2.WebAPInuxiba.Models
{
    public class User
    {
        [Key]
        public int userid { get; set; }
        public string Login { get; set; }
        [Required(ErrorMessage ="El campo {0} es requerido!")]
        [StringLength(maximumLength:25, ErrorMessage = "El campo {0} no debe tener mas de {1} caracteres!")]
        public string Nombre { get; set; }
        public string Paterno { get; set; }
        public string Materno { get; set; }
    }
}