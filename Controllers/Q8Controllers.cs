using Microsoft.AspNetCore.Mvc;
using System;

namespace Back_End_Assignment1.Controllers
{
    [Route("api/q8")]
    [ApiController]
    public class Q8Controller : ControllerBase
    {
        private const double SmallPrice = 25.50;
        private const double LargePrice = 45.50;
        private const double TaxRate = 0.13;

        /// <summary>
        /// Returns a summary of the checkout for SquashFellows plushies.
        /// </summary>
        /// <param name="order">The order containing quantities of small and large plushies.</param>
        /// <returns>A string summarizing the checkout details.</returns>
        /// <example>
        /// POST http://localhost:xx/api/q8/squashfellows
        /// Request Body: Small=1&Large=1
        /// Response: 1 Small @ $25.50 = $25.50; 1 Large @ $45.50 = $45.50; Subtotal = $66.00; Tax = $8.58 HST; Total = $74.58
        /// </example>
        [HttpPost("squashfellows")]
        public ActionResult<string> PostOrder([FromForm] OrderRequest order)
        {
            double smallTotal = order.Small * SmallPrice;
            double largeTotal = order.Large * LargePrice;
            double subtotal = smallTotal + largeTotal;
            double tax = Math.Round(subtotal * TaxRate, 2);
            double total = Math.Round(subtotal + tax, 2);

            return $"{order.Small} Small @ ${SmallPrice} = ${smallTotal}; {order.Large} Large @ ${LargePrice} = ${largeTotal}; Subtotal = ${subtotal}; Tax = ${tax} HST; Total = ${total}";
        }
    }

    public class OrderRequest
    {
        public int Small { get; set; }
        public int Large { get; set; }
    }
}
