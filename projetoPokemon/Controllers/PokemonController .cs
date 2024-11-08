using Microsoft.AspNetCore.Mvc;
using projetoPokemon.Aplication.Interfaces;

namespace projetoPokemon.Controllers
{
    /// <summary>
    /// Controlador para obter informações sobre Pokémon, espécies, tipos e habilidades.
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
        /// Obtém informações de um Pokémon específico pelo nome.
        /// </summary>
        /// <param name="name">Nome do Pokémon.</param>
        /// <returns>Dados do Pokémon.</returns>
        /// <response code="200">Retorna os dados do Pokémon.</response>
        /// <response code="404">Se o Pokémon não for encontrado.</response>
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
        /// Obtém informações sobre a espécie de um Pokémon pelo nome.
        /// </summary>
        /// <param name="name">Nome do Pokémon.</param>
        /// <returns>Dados da espécie do Pokémon.</returns>
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
        /// Obtém informações de um tipo de Pokémon pelo ID.
        /// </summary>
        /// <param name="id">ID do tipo de Pokémon.</param>
        /// <returns>Dados do tipo de Pokémon.</returns>
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
        /// Obtém informações sobre uma habilidade de Pokémon pelo nome.
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
        /// Obtém uma lista de Pokémon.
        /// </summary>
        /// <returns>Lista de Pokémon.</returns>
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
