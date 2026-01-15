using Microsoft.AspNetCore.Mvc;

namespace Time.Api.Controllers;

[ApiController]
[Route("current-time")]
public class WeatherForecastController : ControllerBase
{    
    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public string Get()
    {
        return DateTime.Now.ToString();
    }
}
