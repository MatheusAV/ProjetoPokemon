namespace projetoPokemon.Domain.Entities
{
    public class PokemonListResponse
    {
        public int Count { get; set; }
        public List<NamedAPIResource> Results { get; set; }
    }
}
