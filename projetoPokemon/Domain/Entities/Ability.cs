using Newtonsoft.Json;

namespace projetoPokemon.Domain.Entities
{
    public class Ability: Base
    {
      

        [JsonProperty("is_main_series")]
        public bool IsMainSeries { get; set; }

        [JsonProperty("generation")]
        public NamedAPIResource Generation { get; set; }
        
        [JsonProperty("effect_entries")]
        public List<EffectEntry> EffectEntries { get; set; }

        [JsonProperty("flavor_text_entries")]
        public List<FlavorTextEntry> FlavorTextEntries { get; set; }

        [JsonProperty("names")]
        public List<AbilityName> Names { get; set; }

        [JsonProperty("pokemon")]
        public List<AbilityPokemon> Pokemon { get; set; }
    }
}
