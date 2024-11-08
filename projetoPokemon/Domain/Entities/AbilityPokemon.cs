using Newtonsoft.Json;

namespace projetoPokemon.Domain.Entities
{
    public class AbilityPokemon
    {
        [JsonProperty("is_hidden")]
        public bool IsHidden { get; set; }

        [JsonProperty("slot")]
        public int Slot { get; set; }

        [JsonProperty("pokemon")]
        public NamedAPIResource Pokemon { get; set; }
    }
}
