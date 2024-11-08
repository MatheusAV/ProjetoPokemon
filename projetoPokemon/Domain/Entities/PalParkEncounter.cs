using Newtonsoft.Json;

namespace projetoPokemon.Domain.Entities
{
    public class PalParkEncounter
    {
        [JsonProperty("area")]
        public NamedAPIResource Area { get; set; }

        [JsonProperty("base_score")]
        public int BaseScore { get; set; }

        [JsonProperty("rate")]
        public int Rate { get; set; }
    }
}
