using DungeonsData.Models;

namespace DungeonsData.Abstractions;

public interface IDungeonDataService
{
    public ICollection<Spell> Spells { get; }
}
