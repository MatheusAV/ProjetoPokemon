using Newtonsoft.Json;

namespace projetoPokemon.Domain.Entities
{
    public class AbilityName
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("language")]
        public NamedAPIResource Language { get; set; }
    }
}
