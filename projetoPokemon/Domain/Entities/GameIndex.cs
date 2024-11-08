using Newtonsoft.Json;

namespace projetoPokemon.Domain.Entities
{
    public class GameIndex
    {
        [JsonProperty("game_index")]
        public int GameIndexValue { get; set; }

        [JsonProperty("version")]
        public NamedAPIResource Version { get; set; }
    }
}
