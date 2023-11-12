/*
 **********************************
 * Author: Ivan Stojković
 * Project Task: Hotel
 **********************************
 * Description:
 *  A program for managing hotel rooms and greeting guest
 *  The program has endpoints to:
 *      1. Get Hotel Name and Person Name from Route
 *      2. Get Hotel Name and Person Name from Query
 *      3. Get Hotel Name only
 **********************************
 */


using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ivan_Stojković_Controller.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelController : ControllerBase
    {
        [HttpGet]
        [Route("/bookStayRoute/{personName}/{hotelName}")]
        public IActionResult StayBookFromRoute([FromRoute] string personName, [FromRoute] string hotelName)
        {
            string response = $"Person {personName} booked stay at {hotelName} Hotel :: from route";
            return Ok(response);
        }
        [HttpGet]
        [Route("/bookStayQuerry")]
        public IActionResult StayBookFromQuery([FromQuery] string personName, [FromQuery]string hotelName)
        {
            string response = $"Person {personName} booked stay at {hotelName} Hotel :: from query";
            return Ok(response);

        }
        [HttpPost]
        [Route("/helloFromHotel")]
        public IActionResult HelloFromHotel([FromBody] string hotelName)
        {
            string response = $"Hello from {hotelName} Hotel!";
            return Ok(response);
        }

    }
}
