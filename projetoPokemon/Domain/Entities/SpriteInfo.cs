using Newtonsoft.Json;

namespace projetoPokemon.Domain.Entities
{
    public class SpriteInfo
    {
        [JsonProperty("name_icon")]
        public string NameIcon { get; set; }
    }
}
