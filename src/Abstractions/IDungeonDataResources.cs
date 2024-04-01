using DungeonsData.Models;

namespace DungeonsData.Abstractions;

public interface IDungeonDataResources
{
    public ICollection<Spell> Spells { get; set;  }
    public ICollection<Monster> Monsters { get; set; }
}
