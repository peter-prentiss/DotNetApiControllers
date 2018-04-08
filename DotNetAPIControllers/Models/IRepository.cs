using System.Collections.Generic;

namespace DotNetAPIControllers.Models
{
    public class IRepository
    {
        IEnumerable<Reservation> Reservations { get; }
        Reservation this[int id] { get; }

        Reservation AddReservation(Reservation reservation);
        Reservation UpdateReservation(Reservation reservation);
        void DeleteReservation(int id);
    }
}
