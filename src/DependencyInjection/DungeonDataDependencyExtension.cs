using DungeonsData.Abstractions;
using Microsoft.Extensions.DependencyInjection;

namespace DungeonsData.DependencyInjection;

public static class DungeonDataDependencyExtension
{
    /// <summary>
    /// Adds a singleton service of type: <typeparamref name="IDungeonDataResources"/> with as
    /// implementation: <see cref="DungeonDataResources"/>. to the
    /// specified <see cref="IServiceCollection"/>.
    /// </summary>
    public static void AddStaticDndData(this IServiceCollection services)
        => services.AddSingleton<IDungeonDataResources, DungeonDataResources>();
}
