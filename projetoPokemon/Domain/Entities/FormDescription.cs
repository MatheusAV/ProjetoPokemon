using Newtonsoft.Json;

namespace projetoPokemon.Domain.Entities
{
    public class FormDescription
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("language")]
        public NamedAPIResource Language { get; set; }
    }
}
