using Microsoft.AspNetCore.Mvc;

namespace Back_End_Assignment1.Controllers
{
    [Route("api/q1")]
    [ApiController]
    public class Q1Controller : ControllerBase
    {
        /// <summary>
        /// Returns a welcome message.
        /// </summary>
        /// <returns>A string containing a welcome message.</returns>
        /// <example>
        /// GET http://localhost:xx/api/q1/welcome
        /// Response: Welcome to 5125!
        /// </example>
        [HttpGet("welcome")]
        public ActionResult<string> GetWelcomeMessage()
        {
            return "Welcome to 5125!";
        }
    }
}

