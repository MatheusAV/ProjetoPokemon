using Newtonsoft.Json;

namespace projetoPokemon.Domain.Entities
{
    public class Stat
    {
        [JsonProperty("base_stat")]
        public int BaseStat { get; set; }

        [JsonProperty("effort")]
        public int Effort { get; set; }

        [JsonProperty("stat")]
        public NamedAPIResource StatDetail { get; set; }
    }
}
