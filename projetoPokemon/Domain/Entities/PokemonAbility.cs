using Newtonsoft.Json;

namespace projetoPokemon.Domain.Entities
{
    public class PokemonAbility
    {
        [JsonProperty("ability")]
        public NamedAPIResource Ability { get; set; }

        [JsonProperty("is_hidden")]
        public bool IsHidden { get; set; }

        [JsonProperty("slot")]
        public int Slot { get; set; }
    }
}
