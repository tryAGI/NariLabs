namespace NariLabs.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static NariLabsClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("NARI_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("NARI_API_KEY environment variable is not found.");

        var client = new NariLabsClient(apiKey);

        return client;
    }
}
