using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Prueba_2.WebAPInuxiba.Models;

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

    }
}