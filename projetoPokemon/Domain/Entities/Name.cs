using Newtonsoft.Json;

namespace projetoPokemon.Domain.Entities
{
    public class Name
    {
        [JsonProperty("language")]
        public NamedAPIResource Language { get; set; }

        [JsonProperty("name")]
        public string NameValue { get; set; }
    }
}
