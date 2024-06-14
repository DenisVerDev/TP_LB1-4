using System.Net.Http;
using System.Threading.Tasks;

public class CombinationService
{
    private readonly HttpClient _httpClient;

    public CombinationService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<string> GetAlternative(int id)
    {
        var response = await _httpClient.GetAsync($"http://alternative-service/Alternative/{id}");
        return await response.Content.ReadAsStringAsync();
    }
}
