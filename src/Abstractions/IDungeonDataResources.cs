using DungeonsData.Models;

namespace DungeonsData.Abstractions;

public interface IDungeonDataResources
{
    public ICollection<Spell> Spells { get; set;  }
}
