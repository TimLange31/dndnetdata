namespace DungeonData.Tests
{
    public class SpellsTests : TestBase
    {
        [Fact]
        public void DeserializeJsonNotNullOrEmpty()
        {
            // Arrange
            var service = base.SetupDataService();

            // Act
            var spells = service.Spells;

            // Assert
            Assert.NotNull(spells);
            Assert.NotEmpty(spells);
        }

        [Fact]
        public void Find_Spell_Linq_Fireball()
        {
            // Arrange
            var service = base.SetupDataService();

            // Act
            var spells = service.Spells;
            var fireball = spells.Where(spell => spell.Name.Equals(Fireball)).FirstOrDefault();

            // Assert
            Assert.NotNull(fireball);
        }
    }
}