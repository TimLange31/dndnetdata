namespace DungeonData.Tests;

public class MonsterTests : TestBase
{
    [Fact]
    public void DeserializeJsonNotNullOrEmpty()
    {
        // Arrange
        var service = base.SetupDataService();

        // Act
        var monsters = service.Monsters;

        // Assert
        Assert.NotNull(monsters);
        Assert.NotEmpty(monsters);
    }

    [Fact]
    public void Find_Spell_Linq_Aboleth()
    {
        // Arrange
        var service = base.SetupDataService();

        // Act
        var monsters = service.Monsters;
        var aboleth = monsters.Where(spell => spell.Name.Equals(Aboleth)).FirstOrDefault();

        // Assert
        Assert.NotNull(aboleth);
    }
}
