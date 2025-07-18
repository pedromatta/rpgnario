using RpgNario.Web.Response;
using RpgNario.Web.Requests;
using System.Net.Http.Json;

namespace RpgNario.Web.Services;
public class SistemaAPI
{
    private readonly HttpClient _httpClient;
    public SistemaAPI(IHttpClientFactory factory)
    {
        _httpClient = factory.CreateClient("API");
    }
    public async Task<ICollection<SistemaResponse>?> GetSistemasAsync()
    {
        return await _httpClient.GetFromJsonAsync<ICollection<SistemaResponse>>("sistemas");
    }

    public async Task<ICollection<SistemaResponse>?> GetSistemaPorEditoraAsync(string nomeEditora)
    {
        return await _httpClient.GetFromJsonAsync<ICollection<SistemaResponse>>($"sistemas/editora/{nomeEditora}");
    }

    public async Task<ICollection<SistemaResponse>?> GetSistemaPorGeneroAsync(string nomeGenero)
    {
        return await _httpClient.GetFromJsonAsync<ICollection<SistemaResponse>>($"sistemas/genero/{nomeGenero}");
    }

    public async Task<SistemaResponse?> GetSistemaPorNomeAsync(string nome)
    {
        return await _httpClient.GetFromJsonAsync<SistemaResponse>($"sistemas/{nome}");
    }

    public async Task PostSistemaAsync(SistemaRequest request)
    {
        await _httpClient.PostAsJsonAsync("sistemas", request);
    }

    public async Task PutSistemaAsync(SistemaRequestEdit requestEdit)
    {
        await _httpClient.PutAsJsonAsync("sistemas", requestEdit);
    }

    public async Task DeleteSistemaAsync(int id)
    {
        await _httpClient.DeleteAsync($"sistemas/{id}");
    }
}