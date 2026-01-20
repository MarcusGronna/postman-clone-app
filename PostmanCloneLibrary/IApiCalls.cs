

namespace PostmanCloneLibrary
{
    public interface IApiCalls
    {
        Task<string> CallApiAsync(string url, HttpContent? content = null, HttpAction httpAction = HttpAction.GET, bool formatOutput = true);
        Task<string> CallApiAsync(string url, string body, HttpAction httpAction = HttpAction.GET, bool formatOutput = true);
        bool IsValidUrl(string url);
    }
}