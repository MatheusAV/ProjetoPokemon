using Newtonsoft.Json;

namespace projetoPokemon.Domain.Entities
{
    public class Variety
    {
        [JsonProperty("is_default")]
        public bool IsDefault { get; set; }

        [JsonProperty("pokemon")]
        public NamedAPIResource Pokemon { get; set; }
    }
}
