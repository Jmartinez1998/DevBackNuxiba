using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Prueba_2.WebAPInuxiba.Models;
using CsvHelper;
using System.IO;
using System;
using System.Globalization;

namespace Prueba_2.WebAPInuxiba.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        public UsersController(ApplicationDbContext context)
        {
            this.context = context;
        }
        /* Listar top 10 usuarios de la base antes creada */

        [HttpGet]
        public  List<Employee> GetFirst()
        {
            var MyUser = context.empleados
            .Include(x => x.User).Take(10).ToList();

            return MyUser.ToList();
        }

        // Generar un archivo csv con las siguienets campos con su información(Login, Nombre completo, sueldo, fecha Ingreso) (25 puntos)
        [HttpGet("load_csv")]
        public  IActionResult GenerateCSV(string fileName)
        {
            List<Employee> employees = new List<Employee>();

            var MyUser = context.empleados.Include(x => x.User).ToList();

            var path = $"{Directory.GetCurrentDirectory()}";
            //using (FileStream fileStream = System.IO.File.Create(fileName));
            using(var write = new StreamWriter(path+"\\NewFileNuxiba.csv"))
            using(var csv = new CsvWriter(write, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(MyUser);
            }
            return Ok();
        }
        // Poder actualizar el salario del algun usuario especifico
        [HttpPut("{id}")]
        public  async Task<ActionResult> SaveEmployee(Employee employee, int id)
        {
            if(employee.userId != id)
            {
                return BadRequest("El empleado no coincide con el id de la URL ! :(");
            }
            context.Update(employee);
            await context.SaveChangesAsync();
            return Ok();
        }

        //Poder Tener una opcion para agregar un nuevo usuario y se pueda asiganar el salario y la fecha de ingreso por default el dia de hoy (25 puntos)
        [HttpPost]
        public async Task<ActionResult> NewEmployee([FromBody] Employee employee)
        {
            employee.FechaIngreso = DateTime.Now;
            context.Add(employee);
            await context.SaveChangesAsync();
            return Ok();
        }
    }
}