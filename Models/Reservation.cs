using System.ComponentModel.DataAnnotations.Schema;

namespace Lab4.Models
{
    public class Reservation
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ReservationId { get; set; }
//        public Car Car { get; set; }
        public int CarId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public DateTime TakeDate { get; set; }
        public DateTime ReturnDate { get; set; }
        // public int Days { get; set; }
        public string ReservationStatus { get; set; }

        public override bool Equals(object obj)
        {
            Reservation reservation = obj as Reservation;
            return this.ReservationId == reservation.ReservationId;
        }

        public override string ToString()
        {
            return "" + ReservationId + " " + CarId + " " + CustomerName + " " + CustomerSurname + " " + TakeDate + " " + ReturnDate + " " + ReservationStatus;
        }
    }
}
