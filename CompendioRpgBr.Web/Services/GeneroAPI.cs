using CompendioRpgBr.Web.Response;
using System.Net.Http.Json;

namespace CompendioRpgBr.Web.Services;
public class GeneroAPI
{
    private readonly HttpClient _httpClient;

    public GeneroAPI(IHttpClientFactory factory)
    {
        _httpClient = factory.CreateClient("API");
    }

    public async Task<List<GeneroResponse>?> GetGenerosAsync()
    {
        return await _httpClient.GetFromJsonAsync<List<GeneroResponse>>("generos");
    }
    public async Task<GeneroResponse?> GetGeneroPorNomeAsync(string nome)
    {
        return await _httpClient.GetFromJsonAsync<GeneroResponse>($"generos/{nome}");
    }
    public async Task<List<GeneroResponse>?> GetGeneroPorSistemaAsync(string nomeSistema)
    {
        return await _httpClient.GetFromJsonAsync<List<GeneroResponse>>($"generos/sistema/{nomeSistema}");
    }
}