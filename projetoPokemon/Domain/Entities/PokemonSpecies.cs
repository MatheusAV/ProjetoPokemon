using Newtonsoft.Json;

namespace projetoPokemon.Domain.Entities
{
    public class PokemonSpecies : Base
    {
        [JsonProperty("base_happiness")]
        public int BaseHappiness { get; set; }

        [JsonProperty("capture_rate")]
        public int CaptureRate { get; set; }

        [JsonProperty("color")]
        public NamedAPIResource Color { get; set; }

        [JsonProperty("egg_groups")]
        public List<NamedAPIResource> EggGroups { get; set; }

        [JsonProperty("evolution_chain")]
        public EvolutionChain EvolutionChain { get; set; }

        [JsonProperty("evolves_from_species")]
        public NamedAPIResource EvolvesFromSpecies { get; set; }

        [JsonProperty("flavor_text_entries")]
        public List<FlavorTextEntry> FlavorTextEntries { get; set; }

        [JsonProperty("form_descriptions")]
        public List<FormDescription> FormDescriptions { get; set; }

        [JsonProperty("forms_switchable")]
        public bool FormsSwitchable { get; set; }

        [JsonProperty("gender_rate")]
        public int GenderRate { get; set; }

        [JsonProperty("genera")]
        public List<Genus> Genera { get; set; }

        [JsonProperty("generation")]
        public NamedAPIResource Generation { get; set; }

        [JsonProperty("growth_rate")]
        public NamedAPIResource GrowthRate { get; set; }

        [JsonProperty("habitat")]
        public NamedAPIResource Habitat { get; set; }

        [JsonProperty("has_gender_differences")]
        public bool HasGenderDifferences { get; set; }

        [JsonProperty("hatch_counter")]
        public int HatchCounter { get; set; }

        [JsonProperty("is_baby")]
        public bool IsBaby { get; set; }

        [JsonProperty("is_legendary")]
        public bool IsLegendary { get; set; }

        [JsonProperty("is_mythical")]
        public bool IsMythical { get; set; }

        [JsonProperty("names")]
        public List<Name> Names { get; set; }

        [JsonProperty("order")]
        public int Order { get; set; }

        [JsonProperty("pal_park_encounters")]
        public List<PalParkEncounter> PalParkEncounters { get; set; }

        [JsonProperty("pokedex_numbers")]
        public List<PokedexNumber> PokedexNumbers { get; set; }

        [JsonProperty("shape")]
        public NamedAPIResource Shape { get; set; }

        [JsonProperty("varieties")]
        public List<Variety> Varieties { get; set; }
    }    
}
