using System.Text.Json.Serialization;

namespace CicdBlazorDemo.Web.Info;

public sealed class BuildInfo
{
    [JsonPropertyName("version")]
    public string Version { get; set; } = "unknown";
    [JsonPropertyName("commit")]
    public string Commit { get; set; } = "unknown";
    [JsonPropertyName("buildTimeUtc")]
    public string BuildTimeUtc { get; set; } = "unknown";
}
