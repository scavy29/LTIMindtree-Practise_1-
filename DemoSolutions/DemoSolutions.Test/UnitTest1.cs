using Microsoft.AspNetCore.Mvc;
using DemoSolution;
using Microsoft.Extensions.Logging;
using DemoSolution.WebApi.Controllers;


namespace DemoSolution.WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }
    [HttpPost]
    public int PostData()
    {
        return 0;
    }
    
    [HttpPut]
    public string DemoTest(IDisposable dispose)
    {
        return "disposed";
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateTime.Now.AddDays(index),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }


  class Dispossible : IDisposable
    {
        public void Dispose()
        {
            //throw new NotImplementedException();
        }
    }
    public class MockObject : ILogger<WeatherForecastController>
    {
        public IDisposable BeginScope<TState>(TState state)
        {
            return new Dispossible();
            //throw new NotImplementedException();
        }

        public bool IsEnabled(LogLevel logLevel)
        {
            return false;
            //throw new NotImplementedException();
        }

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception, Func<TState, Exception?, string> formatter)
        {
           // throw new NotImplementedException();
        }
    }
    
    // dotnet add package Microsoft.Extensions.Logging
}


/*
 class Dispossible : IDisposable
    {
        public void Dispose()
        {
            //throw new NotImplementedException();
        }
    }
    public class MockObject : ILogger<WeatherForecastController>
    {
        public IDisposable BeginScope<TState>(TState state)
        {
            return new Dispossible();
            //throw new NotImplementedException();
        }

        public bool IsEnabled(LogLevel logLevel)
        {
            return false;
            //throw new NotImplementedException();
        }

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception, Func<TState, Exception?, string> formatter)
        {
           // throw new NotImplementedException();
        }
    }
*/ 
