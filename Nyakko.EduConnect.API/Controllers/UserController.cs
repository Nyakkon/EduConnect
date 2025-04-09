using Microsoft.AspNetCore.Mvc;

namespace Nyakko.EduConnect.API.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        private readonly IHelloService _helloService;

        public UserController(ILogger<UserController> logger, IHelloService helloService)
        {
            _logger = logger;
            _helloService = helloService;
        }

        [HttpGet("logs")]
        public IActionResult LogTest()
        {
            _logger.LogTrace("LogTrace");
            _logger.LogDebug("LogDebug");
            _logger.LogInformation("LogInformation");
            _logger.LogWarning("LogWarning");
            _logger.LogError("LogError");
            _logger.LogCritical("LogCritical");

            return Ok("Logs have been written");
        }

        [HttpGet("say-hello")]
        public IActionResult SayHello([FromQuery] string name)
        {
            var result = _helloService.SayHello(name);
            return Ok(result);
        }
    }
}
