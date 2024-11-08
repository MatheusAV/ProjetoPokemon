using projetoPokemon.Domain.Entities;
using projetoPokemon.Tests.Mocks;
using Xunit;

namespace projetoPokemon.Tests.Entities
{
    public class AbilityTests
    {
        [Fact]
        public void Ability_ShouldDeserializeCorrectly()
        {
            // Arrange
            var ability = MockData.GetMockAbility();

            // Act & Assert
            Assert.NotNull(ability);
            Assert.Equal(4, ability.Id);
            Assert.Equal("battle-armor", ability.Name);
            Assert.True(ability.IsMainSeries);
        }

        [Fact]
        public void Ability_ShouldContainEffectEntries()
        {
            // Arrange
            var ability = MockData.GetMockAbility();

            // Act & Assert
            Assert.NotNull(ability.EffectEntries);
            Assert.Single(ability.EffectEntries);

            var effectEntry = ability.EffectEntries[0];
            Assert.Equal("Moves cannot score critical hits against this Pokémon.", effectEntry.Effect);
            Assert.Equal("Protects against critical hits.", effectEntry.ShortEffect);
            Assert.Equal("en", effectEntry.Language.Name);
        }

        [Fact]
        public void Ability_ShouldContainFlavorTextEntries()
        {
            // Arrange
            var ability = MockData.GetMockAbility();

            // Act & Assert
            Assert.NotNull(ability.FlavorTextEntries);
            Assert.Single(ability.FlavorTextEntries);

            var flavorTextEntry = ability.FlavorTextEntries[0];
            Assert.Equal("Protects the Pokémon from critical hits.", flavorTextEntry.FlavorText);
            Assert.Equal("en", flavorTextEntry.Language.Name);
            Assert.Equal("ruby-sapphire", flavorTextEntry.VersionGroup.Name);
        }
    }
}
