using System.ComponentModel.DataAnnotations;

namespace Prueba_2.WebAPInuxiba.Models
{
    public class Employee
    {
        [Key]
        public int EmpleadoId { get; set; }
        public double Sueldo { get; set; }
        public DateTime FechaIngreso { get; set; }        
        public int userId { get; set; }
        public User User { get; set; }
    }
}