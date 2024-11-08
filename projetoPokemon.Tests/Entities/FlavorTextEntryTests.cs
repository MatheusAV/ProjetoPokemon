using projetoPokemon.Domain.Entities;
using projetoPokemon.Tests.Mocks;
using Xunit;

namespace projetoPokemon.Tests.Entities
{
    public class FlavorTextEntryTests
    {
        [Fact]
        public void FlavorTextEntry_ShouldDeserializeCorrectly()
        {
            // Arrange
            var ability = MockData.GetMockAbility();
            var flavorTextEntry = ability.FlavorTextEntries[0];

            // Act & Assert
            Assert.Equal("Protects the Pokémon from critical hits.", flavorTextEntry.FlavorText);
            Assert.Equal("en", flavorTextEntry.Language.Name);
            Assert.Equal("ruby-sapphire", flavorTextEntry.VersionGroup.Name);
        }
    }
}
