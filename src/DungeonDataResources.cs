using System.Runtime.CompilerServices;
using DungeonsData.Abstractions;
using DungeonsData.Models;
using Microsoft.Extensions.Logging;
[assembly: InternalsVisibleTo("DungeonData.Tests")]


namespace DungeonsData;

internal class DungeonDataResources : EmbeddedDungeonResources, IDungeonDataResources
{
    private readonly ILogger<DungeonDataResources> _logger;

    public ICollection<Spell> Spells { get; set; }

    public DungeonDataResources(ILogger<DungeonDataResources> logger)
    {
        _logger = logger;
        try
        {
            Spells = base.GetEmbeddedResources<ICollection<Spell>>(Constants.Spells);
        }
        catch(Exception ex)
        {
            _logger.LogWarning($"Failed to get Embedded D&D Resources: '{ex.Message}'.");
        }
    }
}
