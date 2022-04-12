using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Pizzas.API.Models;
using Pizzas.API.Services;

namespace Pizzas.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PizzaController : ControllerBase
    {

        /*[HttpGet]
        public IActionResult GetAllEjemplo()
        {
            var rng = new Random();
            return Ok(Enumerable.Range(1, 5).Select(index => new Pizza
            {
                Descripcion = "Con salsa de tomate y queso",
                Id = 1,
                Importe = 300,
                LibreGluten = false,
                Nombre = "Muzza Individual"
            })
            .ToArray());
        }*/
        
        [HttpGet]
        public IActionResult GetAll(){
            List<Pizza> ListPizzas = PizzasServices.GetAll();
            return Ok(ListPizzas);
        }
        
        
        [HttpGet("{id}")]
        public Pizza GetById(int id){
            Pizza PBuscada = PizzasServices.GetById(id);
            return PBuscada;
        }

        [HttpPost]
        public IActionResult Create(Pizza pizza) {
            int devuelve = PizzasServices.Create(pizza);
            return Ok("Se agregó correctamente");
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Pizza pizza) {
            int devuelve = PizzasServices.Update(id, pizza);
            return Ok("Se modifico correctamente");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteById(int id) {
            int Registro = PizzasServices.DeleteById(id);
            return Ok("Se elimino correctamente");
        }
    }
}
