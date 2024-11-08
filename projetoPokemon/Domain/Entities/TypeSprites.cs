using Newtonsoft.Json;

namespace projetoPokemon.Domain.Entities
{
    public class TypeSprites
    {
        [JsonProperty("generation-iii")]
        public GenerationSprites GenerationIII { get; set; }

        [JsonProperty("generation-iv")]
        public GenerationSprites GenerationIV { get; set; }

        [JsonProperty("generation-ix")]
        public GenerationSprites GenerationIX { get; set; }

        [JsonProperty("generation-v")]
        public GenerationSprites GenerationV { get; set; }

        [JsonProperty("generation-vi")]
        public GenerationSprites GenerationVI { get; set; }

        [JsonProperty("generation-vii")]
        public GenerationSprites GenerationVII { get; set; }

        [JsonProperty("generation-viii")]
        public GenerationSprites GenerationVIII { get; set; }
    }
}
