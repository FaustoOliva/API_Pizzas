using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Pizzas.API.Models;

namespace Pizzas.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuariosController : ControllerBase
    {
        
        [HttpPost]
        [Route("login")]
        public IActionResult Login(Usuario Usuario) {
            if (true)
            {
                return Ok();
            }else {
                return NotFound();
            }
            

        }
    }
}