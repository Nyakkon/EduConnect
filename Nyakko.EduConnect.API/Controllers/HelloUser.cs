using Microsoft.AspNetCore.Mvc;

namespace Nyakko.EduConnect.API.Controllers
{
    [ApiController]
    [Route("api/HelloUser")]
    public class HelloUser : ControllerBase
    {
        private readonly ILogger<HelloUser> _logger;
        private readonly IHelloService _helloService;

        public HelloUser(ILogger<HelloUser> logger, IHelloService helloService)
        {
            _logger = logger;
            _helloService = helloService;
        }

        private void LogTest()
        {
            _logger.LogTrace("LogTrace");
            _logger.LogDebug("LogDebug");
            _logger.LogInformation("LogInformation");
            _logger.LogWarning("LogWarning");
            _logger.LogError("LogError");
            _logger.LogCritical("LogCritical");
        }

        [HttpGet("say-hello")]
        public IActionResult GetNameFromQuery([FromQuery] string name)
        {
            var result = _helloService.SayHello(name);
            LogTest();
            return Ok(result);
        }
    }
}