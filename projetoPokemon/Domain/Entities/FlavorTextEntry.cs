using Newtonsoft.Json;

namespace projetoPokemon.Domain.Entities
{
    public class FlavorTextEntry
    {
        [JsonProperty("flavor_text")]
        public string FlavorText { get; set; }

        [JsonProperty("language")]
        public NamedAPIResource Language { get; set; }

        [JsonProperty("version_group")]
        public NamedAPIResource VersionGroup { get; set; }
    }
}
