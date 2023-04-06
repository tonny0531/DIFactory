using DelegateFactory.Factory;
using DelegateFactory.Model;
using Microsoft.AspNetCore.Mvc;

namespace DelegateFactory.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private readonly ILogger<WeatherForecastController> _logger;
    private readonly IFactory _factory;

    public WeatherForecastController(ILogger<WeatherForecastController> logger, IFactory factory)
    {
        _logger = logger;
        _factory = factory;
    }

    [HttpGet("name/{role}")]
    public ActionResult<string> GetName(string role)
    {
        bool isEnumRole =Enum.TryParse(role,out PersonType personType);
        if(isEnumRole){
            string name = this._factory.GetPerson(personType).GetName();
            return Ok(name);
        }else{
            return BadRequest("Unknow Role");
        }
    }
}
