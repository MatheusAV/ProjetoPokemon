using Newtonsoft.Json;

namespace projetoPokemon.Domain.Entities
{
    public class NamedAPIResource
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
