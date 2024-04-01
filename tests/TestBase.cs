using DungeonsData;
using Microsoft.Extensions.Logging.Abstractions;

namespace DungeonData.Tests;

public abstract class TestBase
{
    protected const string Fireball = nameof(Fireball);
    protected const string Aboleth = nameof(Aboleth);

    internal virtual DungeonDataResources SetupDataService()
    {
        var logger = new NullLogger<DungeonDataResources>();
        return new DungeonDataResources(logger);
    }
}
