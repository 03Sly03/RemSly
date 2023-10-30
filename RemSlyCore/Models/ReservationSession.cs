namespace RemSlyCore.Models
{
    public class ReservationSession
    {
        public int SessionId { get; set; }
        public Session? Session { get; set; }

        public int ReservationId { get; set; }
        public Reservation? Reservation { get; set; }
    }
}