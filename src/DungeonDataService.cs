using System.Text.Json;
using DungeonsData.Abstractions;
using DungeonsData.Models;

namespace DungeonsData;

internal class DungeonDataService : IDungeonDataService
{
    public ICollection<Spell> Spells { get; private set; }

    public DungeonDataService()
    {
        var jsonFilePath = "C:\\projects\\dndnetdata\\src\\DataSources\\5e-SRD-Spells.json";
        var jsonString = File.ReadAllText(jsonFilePath);
        Spells = JsonSerializer.Deserialize<List<Spell>>(jsonString);
    }
}
