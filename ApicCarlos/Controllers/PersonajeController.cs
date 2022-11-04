using ApicCarlos.Data;
using DomainId.Modelo;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ApicCarlos.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonajeController : ControllerBase
    {
        private readonly AplicationDbContext _context;
        public PersonajeController(AplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult<Personaje>> CrearPersonaje([FromBody] PersonajeResponse i)
        {
            Personaje personaje = new Personaje();

            personaje.Nombre = i.Nombre;
            personaje.Poder = i.Poder;
            personaje.Color = i.Color;
            personaje.Fkgenero = i.Fkgenero;

            personaje = _context.personajes

            return personaje;
        }

    }
}
