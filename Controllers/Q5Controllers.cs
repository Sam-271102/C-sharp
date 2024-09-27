using Microsoft.AspNetCore.Mvc;

namespace Back_End_Assignment1.Controllers
{
    [Route("api/q5")]
    [ApiController]
    public class Q5Controller : ControllerBase
    {
        /// <summary>
        /// Acknowledges the provided secret integer.
        /// </summary>
        /// <param name="secret">The integer to acknowledge.</param>
        /// <returns>A string acknowledging the secret.</returns>
        /// <example>
        /// POST http://localhost:xx/api/q5/secret
        /// Request Body: 5
        /// Response: Shh.. the secret is 5
        /// </example>
        [HttpPost("secret")]
        public ActionResult<string> PostSecret([FromBody] int secret)
        {
            return $"Shh.. the secret is {secret}";
        }
    }
}
