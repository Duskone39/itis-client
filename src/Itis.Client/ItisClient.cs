using System.Runtime.Serialization;
using System.Text.Json;
using Itis.Client.Dtos;
using Itis.Client.Entities;

namespace Itis.Client
{
  public class ItisClient
  {
    private readonly HttpClient _httpClient;
    private readonly JsonSerializerOptions _serializerOptions;

    public ItisClient()
    {
      _httpClient = new HttpClient
      {
        BaseAddress = new Uri("https://www.itis.gov/"),
      };

      _serializerOptions = new JsonSerializerOptions()
      {
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase
      };
    }

    public async Task<SvcFullRecordDto?> GetTaxonomyAsync(int id, CancellationToken cancellationToken = default)
    {
      var request = new HttpRequestMessage(HttpMethod.Get, $"ITISWebService/jsonservice/getFullRecordFromTSN?tsn={id}");
      var response = await _httpClient.SendAsync(request, cancellationToken);

      response.EnsureSuccessStatusCode();
      var json = await response.Content.ReadAsStringAsync(cancellationToken);
      try
      {
        if (json == string.Empty)
          return null;

        var result = JsonSerializer.Deserialize<SvcFullRecordDto>(json, _serializerOptions);

        if (result == null)
          throw new SerializationException($"Can`t deserialize - [{json}]");

        result.JsonResponse = json;
        return result;
      }
      catch (Exception e)
      {
        throw new SerializationException($"Can`t deserialize - [{json}], exception - {e}");
      }
    }

    public async Task<Taxonomy?> GetOptimizedTaxonomyAsync(int id, CancellationToken cancellationToken = default)
    {
      return await GetTaxonomyAsync(id, cancellationToken);
    }
  }
}
