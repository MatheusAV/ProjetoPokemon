using Newtonsoft.Json;
using projetoPokemon.Domain.Entities;

namespace projetoPokemon.Tests.Mocks
{
    public static class MockData
    {
        public static Ability GetMockAbility()
        {
            string json = @"
            {
                'id': 4,
                'name': 'battle-armor',
                'is_main_series': true,
                'generation': { 'name': 'generation-iii', 'url': 'https://pokeapi.co/api/v2/generation/3/' },
                'effect_entries': [
                    {
                        'effect': 'Moves cannot score critical hits against this Pokémon.',
                        'short_effect': 'Protects against critical hits.',
                        'language': { 'name': 'en', 'url': 'https://pokeapi.co/api/v2/language/9/' }
                    }
                ],
                'flavor_text_entries': [
                    {
                        'flavor_text': 'Protects the Pokémon from critical hits.',
                        'language': { 'name': 'en', 'url': 'https://pokeapi.co/api/v2/language/9/' },
                        'version_group': { 'name': 'ruby-sapphire', 'url': 'https://pokeapi.co/api/v2/version-group/5/' }
                    }
                ]
            }";

            return JsonConvert.DeserializeObject<Ability>(json)!;
        }
    }
}
