using Microsoft.AspNetCore.Mvc;

namespace Back_End_Assignment1.Controllers
{
    [Route("api/q2")]
    [ApiController]
    public class Q2Controller : ControllerBase
    {
        /// <summary>
        /// Returns a greeting to the specified name.
        /// </summary>
        /// <param name="name">The name of the person to greet.</param>
        /// <returns>A string containing a personalized greeting.</returns>
        /// <example>
        /// GET http://localhost:xx/api/q2/greeting?name=Gary
        /// Response: Hi Gary!
        /// </example>
        [HttpGet("greeting")]
        public ActionResult<string> GetGreeting([FromQuery] string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return BadRequest("Name cannot be empty.");
            }
            return $"Hi {name}!";
        }
    }
}
