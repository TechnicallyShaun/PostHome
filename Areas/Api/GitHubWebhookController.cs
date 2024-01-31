using Microsoft.AspNetCore.Mvc;

namespace PostHome.Controllers;

public class GitHubWebhookController : ApiControllerBase
{

    private readonly ILogger<WeatherForecastController> _logger;

    public GitHubWebhookController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GitHubWebhook")]
    public string Get()
    {
        return "Send GitHub Webhooks here.";
    }
}