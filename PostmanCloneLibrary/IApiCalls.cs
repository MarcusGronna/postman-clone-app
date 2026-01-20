
namespace PostmanCloneLibrary
{
    public interface IApiCalls
    {
        Task<string> CallApiAsync(
            string url, 
            bool formatOutput = true, 
            HttpAction httpAction = HttpAction.GET, 
            string? body = null
            );
        bool IsValidUrl(string url);
    }
}