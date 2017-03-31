using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HolidayAPI.Models;
using Microsoft.AspNetCore.Authorization;

namespace HolidayAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/Flight")]
    [Authorize]
    public class FlightController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            var flights = new List<Flight>
            {
                new Flight
                {
                    UID = Guid.NewGuid(),
                    FlightNr = "7DSF1231",
                    Departure = "Basel",
                    Destination ="Barcelona",
                    DepartureDate = new DateTime(2017, 4, 13),
                    ArrivalDate = new DateTime(2017, 4, 13)
                },
                new Flight
                {
                    UID = Guid.NewGuid(),
                    FlightNr = "5POR235",
                    Departure = "Zürich",
                    Destination ="Porto",
                    DepartureDate = new DateTime(2017, 5, 1),
                    ArrivalDate = new DateTime(2017, 5, 1)
                },
                new Flight
                {
                    UID = Guid.NewGuid(),
                    FlightNr = "7DSF1231",
                    Departure = "Zürich",
                    Destination ="Stockholm",
                    DepartureDate = new DateTime(2017, 12, 11),
                    ArrivalDate = new DateTime(2017, 12, 11)
                }
            };

            return new ObjectResult(flights);
        }
    }
}