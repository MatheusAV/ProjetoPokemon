using projetoPokemon.Domain.Entities;

namespace projetoPokemon.Aplication.Interfaces
{
    public interface IPokemonService
    {
        Task<Pokemon> GetPokemonAsync(string name);
        Task<PokemonSpecies> GetPokemonSpeciesAsync(string name);
        Task<Domain.Entities.Type> GetTypeAsync(int id);
        Task<Ability> GetAbilityAsync(string name);
        Task<PokemonListResponse> GetPokemonListAsync();
    }
}
