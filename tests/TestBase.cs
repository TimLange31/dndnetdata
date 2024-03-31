using DungeonsData;
using Microsoft.Extensions.Logging.Abstractions;

namespace DungeonData.Tests;

public abstract class TestBase
{
    protected const string Fireball = nameof(Fireball);

    internal virtual DungeonDataResources SetupDataService()
    {
        var logger = new NullLogger<DungeonDataResources>();
        return new DungeonDataResources(logger);
    }
}
