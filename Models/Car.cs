using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Models
{
    public class Car
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CarId { get; set; }
        public string Model { get; set; }
        public string Number { get; set; }
        public double Price { get; set; }
        public bool IsAvaliable { get; set; }
        public string Fuel { get; set; }

        public override string ToString()
        {
            return "" + CarId + " " + Model + " " + Number + " " + Price + " " + IsAvaliable + " "  + Fuel;
        }
        public ICollection<Reservation> Reservations { get; set; }
    }
}
