﻿using Microsoft.AspNetCore.Mvc;
using DotNetAPIControllers.Models;

namespace DotNetAPIControllers.Controllers
{
    [Route("api/[controller")]
    public class ContentController : Controller
    {
        [HttpGet("string")]
        public string GetString() => "This is a string response";

        [HttpGet("object")]
        public Reservation GetObject() => new Reservation {
            ReservationID = 100,
            ClientName = "Joe",
            Location = "Board Room"
        }
    }
}