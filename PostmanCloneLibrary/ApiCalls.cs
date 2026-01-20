using System.Text;
using System.Text.Json;

namespace PostmanCloneLibrary;

public class ApiCalls : IApiCalls
{
    private readonly HttpClient client = new();

    public async Task<string> CallApiAsync(
        string url,
        string body,
        HttpAction httpAction = HttpAction.GET,
        bool formatOutput = true
        )
    {
        StringContent content = new(body, Encoding.UTF8, "application/json");
        return await CallApiAsync(url, content, httpAction, true);
    }

    public async Task<string> CallApiAsync(
        string url,
        HttpContent? content = null,
        HttpAction httpAction = HttpAction.GET,
        bool formatOutput = true
        )
    {
        var response = httpAction switch
        {
            HttpAction.GET => await client.GetAsync(url),
            HttpAction.POST => await client.PostAsync(url, content),
            HttpAction.PUT => await client.PutAsync(url, content),
            HttpAction.PATCH => await client.PatchAsync(url, content),
            HttpAction.DELETE => await client.DeleteAsync(url),
            _ => throw new ArgumentOutOfRangeException(nameof(httpAction), httpAction, null)
        };

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
