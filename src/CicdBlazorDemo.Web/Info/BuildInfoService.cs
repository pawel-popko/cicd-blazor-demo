using System.Net.Http.Json;

namespace CicdBlazorDemo.Web.Info;

public sealed class BuildInfoService
{
    private readonly HttpClient _http;

    public BuildInfoService(HttpClient http) => _http = http;

    public async Task<BuildInfo> GetAsync(CancellationToken ct = default)
    {
        var info = await _http.GetFromJsonAsync<BuildInfo>("build-info.json", ct);
        return info ?? new BuildInfo();
    }
}
