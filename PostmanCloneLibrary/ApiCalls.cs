using System.Text.Json;
using System.Text.Json.Nodes;

namespace PostmanCloneLibrary;

public class ApiCalls : IApiCalls
{
    private readonly HttpClient client = new();

    public async Task<string> CallApiAsync(string url,
        bool formatOutput = true,
        HttpAction httpAction = HttpAction.GET
        )
    {
        var response = await client.GetAsync(url);

        if (response.IsSuccessStatusCode)
        {

            string json = await response.Content.ReadAsStringAsync();

            if (formatOutput)
            {
            var jsonElement = JsonSerializer.Deserialize<JsonElement>(json);
            string prettyJson = JsonSerializer.Serialize(jsonElement,
                        new JsonSerializerOptions { WriteIndented = true });
                return prettyJson;
            }

            return json;
        }
        else
        {
            return "Bad request: " + response.StatusCode;
        }
    }
}
