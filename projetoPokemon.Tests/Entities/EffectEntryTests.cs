using projetoPokemon.Domain.Entities;
using projetoPokemon.Tests.Mocks;
using Xunit;

namespace projetoPokemon.Tests.Entities
{
    public class EffectEntryTests
    {
        [Fact]
        public void EffectEntry_ShouldDeserializeCorrectly()
        {
            // Arrange
            var ability = MockData.GetMockAbility();
            var effectEntry = ability.EffectEntries[0];

            // Act & Assert
            Assert.Equal("Moves cannot score critical hits against this Pokémon.", effectEntry.Effect);
            Assert.Equal("Protects against critical hits.", effectEntry.ShortEffect);
            Assert.Equal("en", effectEntry.Language.Name);
        }
    }
}
