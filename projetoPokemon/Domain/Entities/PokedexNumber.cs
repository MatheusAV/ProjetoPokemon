using Newtonsoft.Json;

namespace projetoPokemon.Domain.Entities
{
    public class PokedexNumber
    {
        [JsonProperty("entry_number")]
        public int EntryNumber { get; set; }

        [JsonProperty("pokedex")]
        public NamedAPIResource Pokedex { get; set; }
    }
}
