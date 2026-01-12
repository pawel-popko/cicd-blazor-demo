namespace CicdBlazorDemo.Web.Info;

public sealed class BuildInfo
{
    public string Version { get; set; } = "unknown";
    public string Commit { get; set; } = "unknown";
    public string BuildTimeUtc { get; set; } = "unknown";
}
