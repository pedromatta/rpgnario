using RpgNario.Web.Requests;
using RpgNario.Web.Response;
using System.Net.Http.Json;

namespace RpgNario.Web.Services;

public class EditoraAPI
{
    private readonly HttpClient _httpClient;
    public EditoraAPI(IHttpClientFactory factory)
    {
        _httpClient = factory.CreateClient("API");
    }
    public async Task<ICollection<EditoraResponse>?> GetEditorasAsync()
    {
        return await _httpClient.GetFromJsonAsync<ICollection<EditoraResponse>>("editoras");
    }

    public async Task<EditoraResponse?> GetEditoraPeloNomeAsync(string nome)
    {
        return await _httpClient.GetFromJsonAsync<EditoraResponse>($"editoras/{nome}");
    }

    public async Task PostEditoraAsync(EditoraRequest request)
    {
        await _httpClient.PostAsJsonAsync("editoras", request);
    }

    public async Task PutEditoraAsync(EditoraRequestEdit requestEdit)
    {
        await _httpClient.PutAsJsonAsync("editoras", requestEdit);
    }

    public async Task DeleteEditoraAsync(int id)
    {
        await _httpClient.DeleteAsync($"editoras/{id}");
    }
}
