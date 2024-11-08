using Newtonsoft.Json;

namespace projetoPokemon.Domain.Entities
{
    public class Genus
    {
        [JsonProperty("genus")]
        public string GenusValue { get; set; }

        [JsonProperty("language")]
        public NamedAPIResource Language { get; set; }
    }
}
