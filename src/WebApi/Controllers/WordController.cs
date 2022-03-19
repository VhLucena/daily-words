using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WordController : ControllerBase
    {
        private readonly ILogger<WordController> _logger;

        public WordController(ILogger<WordController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public Word Get()
        {
            return new Word { Message = "Test" };
        }
    }
}
