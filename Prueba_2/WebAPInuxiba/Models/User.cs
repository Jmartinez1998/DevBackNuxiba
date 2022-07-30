using System.ComponentModel.DataAnnotations;

namespace Prueba_2.WebAPInuxiba.Models
{
    public class User
    {
        [Key]
        public int userid { get; set; }
        public string Login { get; set; }
        public string Nombre { get; set; }
        public string Paterno { get; set; }
        public string Materno { get; set; }
    }
}