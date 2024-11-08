using Microsoft.Extensions.Options;
using projetoPokemon.Helper.Interfaces;

namespace projetoPokemon.Aplication.Configuration
{
    public class PokemonApiRoutes : IPokemonApiRoutes    {
        
        public string BaseUrl { get; set; }

        public string GetPokemonEndpoint(string name) => $"{BaseUrl}/pokemon/{name}";
        public string GetPokemonSpeciesEndpoint(string name) => $"{BaseUrl}/pokemon-species/{name}";
        public string GetTypeEndpoint(int id) => $"{BaseUrl}/type/{id}";
        public string GetAbilityEndpoint(string name) => $"{BaseUrl}/ability/{name}";
        public string GetPokemonListEndpoint() => $"{BaseUrl}/pokemon?limit=100000&offset=0";
    }
}
