using System.Net;
using Microsoft.AspNetCore.Mvc.Testing;

namespace HelloWorldTests.Controllers;

public class HelloWorldControllerTest : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly HttpClient _client;

    public HelloWorldControllerTest(WebApplicationFactory<Program> factory)
    {
        _client = factory.CreateClient();
    }

    [Fact]
    public async Task TestGetHelloWorld()
    {
        // Arrange
        var expected = "Hello, world!";

        // Act
        var response = await _client.GetAsync("/");
        var actual = await response.Content.ReadAsStringAsync();

        // Assert
        response.EnsureSuccessStatusCode();
        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        Assert.Equal(expected, actual);
    }
}
