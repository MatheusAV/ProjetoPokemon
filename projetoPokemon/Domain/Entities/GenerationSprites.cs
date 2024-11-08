using Newtonsoft.Json;

namespace projetoPokemon.Domain.Entities
{
    public class GenerationSprites
    {
        [JsonProperty("colosseum")]
        public SpriteInfo Colosseum { get; set; }

        [JsonProperty("emerald")]
        public SpriteInfo Emerald { get; set; }

        [JsonProperty("firered-leafgreen")]
        public SpriteInfo FireRedLeafGreen { get; set; }

        [JsonProperty("ruby-saphire")]
        public SpriteInfo RubySaphire { get; set; }

        [JsonProperty("xd")]
        public SpriteInfo XD { get; set; }

        [JsonProperty("diamond-pearl")]
        public SpriteInfo DiamondPearl { get; set; }

        [JsonProperty("heartgold-soulsilver")]
        public SpriteInfo HeartGoldSoulSilver { get; set; }

        [JsonProperty("platinum")]
        public SpriteInfo Platinum { get; set; }

        [JsonProperty("scarlet-violet")]
        public SpriteInfo ScarletViolet { get; set; }

        [JsonProperty("black-2-white-2")]
        public SpriteInfo Black2White2 { get; set; }

        [JsonProperty("black-white")]
        public SpriteInfo BlackWhite { get; set; }

        [JsonProperty("omega-ruby-alpha-sapphire")]
        public SpriteInfo OmegaRubyAlphaSapphire { get; set; }

        [JsonProperty("x-y")]
        public SpriteInfo XY { get; set; }

        [JsonProperty("lets-go-pikachu-lets-go-eevee")]
        public SpriteInfo LetsGoPikachuLetsGoEevee { get; set; }

        [JsonProperty("sun-moon")]
        public SpriteInfo SunMoon { get; set; }

        [JsonProperty("ultra-sun-ultra-moon")]
        public SpriteInfo UltraSunUltraMoon { get; set; }

        [JsonProperty("brilliant-diamond-and-shining-pearl")]
        public SpriteInfo BrilliantDiamondShiningPearl { get; set; }

        [JsonProperty("legends-arceus")]
        public SpriteInfo LegendsArceus { get; set; }

        [JsonProperty("sword-shield")]
        public SpriteInfo SwordShield { get; set; }
    }
}
