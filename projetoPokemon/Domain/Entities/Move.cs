using Newtonsoft.Json;

namespace projetoPokemon.Domain.Entities
{
    public class Move
    {
        [JsonProperty("move")]
        public NamedAPIResource MoveDetail { get; set; }

        [JsonProperty("version_group_details")]
        public List<VersionGroupDetail> VersionGroupDetails { get; set; }
    }   
}
