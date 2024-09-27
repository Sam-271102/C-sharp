using Microsoft.AspNetCore.Mvc;

namespace Back_End_Assignment1.Controllers
{
    [Route("api/q7")]
    [ApiController]
    public class Q7Controller : ControllerBase
    {
        /// <summary>
        /// Returns the current date adjusted by the specified number of days.
        /// </summary>
        /// <param name="days">The number of days to adjust (positive or negative).</param>
        /// <returns>A string representation of the adjusted date in yyyy-MM-dd format.</returns>
        /// <example>
        /// GET http://localhost:xx/api/q7/timemachine?days=1
        /// Response: 2024-09-28
        /// </example>
        [HttpGet("timemachine")]
        public ActionResult<string> GetAdjustedDate([FromQuery] int days)
        {
            DateTime adjustedDate = DateTime.Today.AddDays(days);
            return adjustedDate.ToString("yyyy-MM-dd");
        }
    }
}
