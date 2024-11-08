using Newtonsoft.Json;

namespace projetoPokemon.Domain.Entities
{
    public class EffectEntry
    {
        [JsonProperty("effect")]
        public string Effect { get; set; }

        [JsonProperty("short_effect")]
        public string ShortEffect { get; set; }

        [JsonProperty("language")]
        public NamedAPIResource Language { get; set; }
    }
}
