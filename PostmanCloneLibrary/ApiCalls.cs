using System.Text.Json;

namespace PostmanCloneLibrary;

public class ApiCalls : IApiCalls
{
    private readonly HttpClient client = new();

    public async Task<string> CallApiAsync(string url,
        bool formatOutput = true,
        HttpAction httpAction = HttpAction.GET,
        string? body = null
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

    public bool IsValidUrl(string url)
    {
        if (string.IsNullOrWhiteSpace(url))
        {
            return false;
        }

        bool output = Uri.TryCreate(url, UriKind.Absolute, out Uri uriOutput) &&
            (uriOutput.Scheme == Uri.UriSchemeHttps);

        return output;
    }
}
