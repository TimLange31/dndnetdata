using System.Reflection;
using System.Text.Json;

namespace DungeonsData;

internal abstract class EmbeddedDungeonResources
{
    private readonly JsonSerializerOptions _options = new()
    {
        PropertyNameCaseInsensitive = true
    };

    protected virtual TResource GetEmbeddedResources<TResource>(string resourceName)
    {
        var assembly = Assembly.GetExecutingAssembly();
        var path = $"DungeonsData.DataSources.{resourceName}.json";

        using Stream stream = assembly.GetManifestResourceStream(path)
            ?? throw new FileNotFoundException($"Resource '{path}' not found in assembly '{assembly.FullName}'.");

        using StreamReader reader = new(stream);
        string jsonString = reader.ReadToEnd();

        TResource resource = JsonSerializer.Deserialize<TResource>(jsonString, _options)
            ?? throw new InvalidOperationException($"Failed to deserialize the resource '{path}' to type '{typeof(TResource).FullName}'.");

        return resource;
    }
}
