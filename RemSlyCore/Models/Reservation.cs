using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemSlyCore.Models
{
    public class Reservation
    {
        public int Id { get; set; }

        public StatutReservation Statut { get; set; }
        public List<ReservationSession> ReservationSessions { get; set; } = new List<ReservationSession>();

        public int UserId { get; set; }
        public User? User { get; set; }
    }

    public enum StatutReservation
    {
        Prevu,
        EnCours,
        Fini,
        Annule
    }

}
