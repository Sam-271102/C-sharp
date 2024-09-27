using Microsoft.AspNetCore.Mvc;

namespace Back_End_Assignment1.Controllers
{
    [Route("api/q4")]
    [ApiController]
    public class Q4Controller : ControllerBase
    {
        /// <summary>
        /// Returns the start of a knock knock joke.
        /// </summary>
        /// <returns>A string asking "Who's there?"</returns>
        /// <example>
        /// POST http://localhost:xx/api/q4/knockknock
        /// Response: Who’s there?
        /// </example>
        [HttpPost("knockknock")]
        public ActionResult<string> GetKnockKnockJoke()
        {
            return "Who's there?";
        }
    }
}
