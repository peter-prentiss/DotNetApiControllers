using System;
namespace DotNetAPIControllers.Models
{
    public class Reservation
    {
        public int ReservationID { get; set; }
        public string ClientName { get; set; }
        public string Location { get; set; }
    }
}
