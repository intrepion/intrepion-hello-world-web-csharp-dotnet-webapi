using Microsoft.AspNetCore.Mvc;

namespace HelloWorldWebApi.Controllers;

[ApiController]
[Route("/")]
public class HelloWorldController : ControllerBase
{
    private readonly ILogger<HelloWorldController> _logger;

    public HelloWorldController(ILogger<HelloWorldController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetHelloWorld")]
    public string Get()
    {
        return "Hello, world!";
    }
}
