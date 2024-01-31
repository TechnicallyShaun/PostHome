using Microsoft.AspNetCore.Mvc;

namespace PostHome.Controllers;

public class GitHubWebhookController : ApiControllerBase
{
    private readonly ILogger logger;

    public GitHubWebhookController(ILoggerFactory loggerFactory)
    {
        logger = loggerFactory.CreateLogger<GitHubWebhookController>();
    }

    [HttpGet(Name = "GitHubWebhook")]
    public string Get()
    {
        return "Send GitHub Webhooks here.";
    }

    [HttpPost]
    public void Post(object stuff)
    {
        logger.LogInformation(stuff?.ToString());   
    }

    [HttpPut]
    public void Put(object stuff)
    {
        logger.LogInformation(stuff?.ToString());  
        throw new Exception("Blergh!"); 
    }
}