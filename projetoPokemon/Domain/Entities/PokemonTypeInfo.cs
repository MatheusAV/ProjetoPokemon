using Newtonsoft.Json;

namespace projetoPokemon.Domain.Entities
{
    public class PokemonTypeInfo
    {
        [JsonProperty("slot")]
        public int Slot { get; set; }

        [JsonProperty("type")]
        public NamedAPIResource Type { get; set; }
    }
}
