using Newtonsoft.Json;

namespace projetoPokemon.Domain.Entities
{
    public class Type
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("damage_relations")]
        public DamageRelations DamageRelations { get; set; }

        [JsonProperty("game_indices")]
        public List<GameIndex> GameIndices { get; set; }

        [JsonProperty("generation")]
        public NamedAPIResource Generation { get; set; }

        [JsonProperty("move_damage_class")]
        public NamedAPIResource MoveDamageClass { get; set; }

        [JsonProperty("moves")]
        public List<NamedAPIResource> Moves { get; set; }

        [JsonProperty("pokemon")]
        public List<TypePokemon> Pokemon { get; set; }
        [JsonProperty("sprites")]
        public TypeSprites Sprites { get; set; }
    }

}
