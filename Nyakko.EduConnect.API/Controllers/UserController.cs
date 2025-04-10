using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Nyakko.EduConnect.API.Controllers
{
    [Route("API/UserController")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger)
        {
            this._logger = logger;
        }
    }
}