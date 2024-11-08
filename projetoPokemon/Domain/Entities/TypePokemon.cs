using Newtonsoft.Json;

namespace projetoPokemon.Domain.Entities
{
    public class TypePokemon
    {
        [JsonProperty("pokemon")]
        public NamedAPIResource Pokemon { get; set; }

        [JsonProperty("slot")]
        public int Slot { get; set; }
    }
}
