using Newtonsoft.Json;

namespace projetoPokemon.Domain.Entities
{
    public class EvolutionChain
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
