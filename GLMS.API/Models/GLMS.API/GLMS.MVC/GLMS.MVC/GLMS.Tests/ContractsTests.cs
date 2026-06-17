using System.Net;
using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;

public class ContractsTests
    : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly HttpClient _client;

    public ContractsTests(WebApplicationFactory<Program> factory)
    {
        _client = factory.CreateClient();
    }

    [Fact]
    public async Task GetContracts_ReturnsOK()
    {
        var response = await _client.GetAsync("/api/contracts");

        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
    }
}
