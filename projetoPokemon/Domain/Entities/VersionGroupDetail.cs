using Newtonsoft.Json;

namespace projetoPokemon.Domain.Entities
{
    public class VersionGroupDetail
    {
        [JsonProperty("level_learned_at")]
        public int LevelLearnedAt { get; set; }

        [JsonProperty("move_learn_method")]
        public NamedAPIResource MoveLearnMethod { get; set; }

        [JsonProperty("version_group")]
        public NamedAPIResource VersionGroup { get; set; }
    }
}
