using System.Data;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using OSES_DesktopClientServer.Contracts;

namespace OSES_DesktopClientServer.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HelloController : ControllerBase
{
    private readonly ILoggerManager _logger;
    private readonly IConfiguration _configuration;

    public HelloController(ILoggerManager logger, IConfiguration configuration)
    {
        _logger = logger;
        _configuration = configuration;
    }
    
    [HttpGet(Name = "GetHello")]
    public string Get()
    {
        return "Hello World!";
    }
}