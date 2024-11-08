using Newtonsoft.Json;

namespace projetoPokemon.Domain.Entities
{
    public class DamageRelations
    {
        [JsonProperty("double_damage_from")]
        public List<NamedAPIResource> DoubleDamageFrom { get; set; }

        [JsonProperty("double_damage_to")]
        public List<NamedAPIResource> DoubleDamageTo { get; set; }

        [JsonProperty("half_damage_from")]
        public List<NamedAPIResource> HalfDamageFrom { get; set; }

        [JsonProperty("half_damage_to")]
        public List<NamedAPIResource> HalfDamageTo { get; set; }

        [JsonProperty("no_damage_from")]
        public List<NamedAPIResource> NoDamageFrom { get; set; }

        [JsonProperty("no_damage_to")]
        public List<NamedAPIResource> NoDamageTo { get; set; }
    }
}
