using Newtonsoft.Json;

namespace projetoPokemon.Domain.Entities
{
    public class Pokemon : Base
    {
        [JsonProperty("base_experience")]
        public int BaseExperience { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("weight")]
        public int Weight { get; set; }

        [JsonProperty("abilities")]
        public List<PokemonAbility> Abilities { get; set; }

        [JsonProperty("types")]
        public List<PokemonTypeInfo> Types { get; set; }

        [JsonProperty("game_indices")]
        public List<GameIndex> GameIndices { get; set; }

        [JsonProperty("moves")]
        public List<Move> Moves { get; set; }

        [JsonProperty("species")]
        public NamedAPIResource Species { get; set; }

        [JsonProperty("sprites")]
        public Sprites Sprites { get; set; }

        [JsonProperty("stats")]
        public List<Stat> Stats { get; set; }
    }
}
