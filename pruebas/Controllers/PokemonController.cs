using LogicMantle;
using Microsoft.AspNetCore.Mvc;
using Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace pruebas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonController : BaseController
    {
        public PokemonController(IConfiguration configuration) : base(configuration) { }

        // GET: api/<Pokemon>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<Pokemon>/5
        [HttpGet("{pokemon}")]
        public async Task<ActionResult> Get(string pokemon)
        {

            if(pokemon == null)
            {
                return BadRequest("Valor nulo");
            }

            PokemonLogicMantle logic = new PokemonLogicMantle(Configuration);
            Pokemon poke = await logic.GetPokemon(pokemon);

            return Ok(poke);
        }
    }
}
