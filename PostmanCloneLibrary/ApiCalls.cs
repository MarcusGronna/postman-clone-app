using System.Text.Json;
using System.Text.Json.Nodes;

namespace PostmanCloneLibrary;

public class ApiCalls
{
    private readonly HttpClient client = new();

    public async Task<string> CallApiAsync(string url)
    {
        var response = await client.GetAsync(url);

        if (response.IsSuccessStatusCode) {

            string json = await response.Content.ReadAsStringAsync();
            var jsonElement = JsonSerializer.Deserialize<JsonElement>(json);
            string prettyJson = JsonSerializer.Serialize(jsonElement,
                    new JsonSerializerOptions { WriteIndented = true});

            return prettyJson;
        }
        else
        {
            return "Bad request: " + response.StatusCode;
        }
    }
}
