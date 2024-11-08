using Microsoft.AspNetCore.Mvc;
using projetoPokemon.Aplication.Interfaces;

namespace projetoPokemon.Controllers
{
    /// <summary>
    /// Controlador para obter informa��es sobre Pok�mon, esp�cies, tipos e habilidades.
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PokemonController : ControllerBase
    {
        private readonly IPokemonService _pokemonService;

        public PokemonController(IPokemonService pokemonService)
        {
            _pokemonService = pokemonService;
        }

        /// <summary>
        /// Obt�m informa��es de um Pok�mon espec�fico pelo nome.
        /// </summary>
        /// <param name="name">Nome do Pok�mon.</param>
        /// <returns>Dados do Pok�mon.</returns>
        /// <response code="200">Retorna os dados do Pok�mon.</response>
        /// <response code="404">Se o Pok�mon n�o for encontrado.</response>
        [HttpGet("pokemon/{name}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetPokemon(string name)
        {
            try
            {
                var pokemon = await _pokemonService.GetPokemonAsync(name);
                return Ok(pokemon);
            }
            catch (Exception ex)
            {
                return NotFound(new { Error = ex.Message });
            }
        }

        /// <summary>
        /// Obt�m informa��es sobre a esp�cie de um Pok�mon pelo nome.
        /// </summary>
        /// <param name="name">Nome do Pok�mon.</param>
        /// <returns>Dados da esp�cie do Pok�mon.</returns>
        [HttpGet("pokemon-species/{name}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetPokemonSpecies(string name)
        {
            try
            {
                var species = await _pokemonService.GetPokemonSpeciesAsync(name);
                return Ok(species);
            }
            catch (Exception ex)
            {
                return NotFound(new { Error = ex.Message });
            }
        }

        /// <summary>
        /// Obt�m informa��es de um tipo de Pok�mon pelo ID.
        /// </summary>
        /// <param name="id">ID do tipo de Pok�mon.</param>
        /// <returns>Dados do tipo de Pok�mon.</returns>
        [HttpGet("type/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetType(int id)
        {
            try
            {
                var type = await _pokemonService.GetTypeAsync(id);
                return Ok(type);
            }
            catch (Exception ex)
            {
                return NotFound(new { Error = ex.Message });
            }
        }

        /// <summary>
        /// Obt�m informa��es sobre uma habilidade de Pok�mon pelo nome.
        /// </summary>
        /// <param name="name">Nome da habilidade.</param>
        /// <returns>Dados da habilidade.</returns>
        [HttpGet("ability/{name}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetAbility(string name)
        {
            try
            {
                var ability = await _pokemonService.GetAbilityAsync(name);
                return Ok(ability);
            }
            catch (Exception ex)
            {
                return NotFound(new { Error = ex.Message });
            }
        }

        /// <summary>
        /// Obt�m uma lista de Pok�mon.
        /// </summary>
        /// <returns>Lista de Pok�mon.</returns>
        [HttpGet("pokemon-list")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetPokemonList()
        {
            try
            {
                var list = await _pokemonService.GetPokemonListAsync();
                return Ok(list);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Error = ex.Message });
            }
        }
    }
}
