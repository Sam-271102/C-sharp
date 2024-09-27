using Microsoft.AspNetCore.Mvc;

namespace Back_End_Assignment1.Controllers
{
    [Route("api/q3")]
    [ApiController]
    public class Q3Controller : ControllerBase
    {
        /// <summary>
        /// Returns the cube of the integer base.
        /// </summary>
        /// <param name="base">The integer base to cube.</param>
        /// <returns>The cube of the input integer.</returns>
        /// <example>GET http://localhost:xx/api/q3/cube/4</example>
        [HttpGet("cube/{baseValue}")]
        public IActionResult GetCube(int baseValue)
        {
            // Calculate the cube
            int cube = baseValue * baseValue * baseValue;

            // Return the result
            return Ok(cube);
        }
    }
}

