using DungeonsData.Abstractions;
using Microsoft.Extensions.DependencyInjection;

namespace DungeonsData.DependencyInjection;

public static class DungeonDataDependencyExtension
{
    public static void AddStaticDndData(this IServiceCollection services)
        => services.AddInternalStaticDndData();

    internal static void AddInternalStaticDndData(this IServiceCollection services) 
        => services.AddSingleton<IDungeonDataService, DungeonDataService>();
}
