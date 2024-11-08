namespace projetoPokemon.Helper.Interfaces
{
    public interface IPokemonApiRoutes
    {
        string BaseUrl { get; }
        string GetPokemonEndpoint(string name);
        string GetPokemonSpeciesEndpoint(string name);
        string GetTypeEndpoint(int id);
        string GetAbilityEndpoint(string name);
        string GetPokemonListEndpoint();
    }
}
