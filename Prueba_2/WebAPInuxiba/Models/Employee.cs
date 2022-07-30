using System.ComponentModel.DataAnnotations;

namespace Prueba_2.WebAPInuxiba.Models
{
    public class Employee
    {
        [Key]
        public int EmpleadoId { get; set; }
        public string Sueldo { get; set; }
        public DateOnly FechaIngreso { get; set; }        
        public int userId { get; set; }
        public User User { get; set; }
    }
}