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
            return json;
        }
        else
        {
            return "Bad request" + response.StatusCode;
        }
    }
}
