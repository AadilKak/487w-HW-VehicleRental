using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VehicleRentalApp.Models
{
    [Table("reservations", Schema = "public")]
    public partial class Reservation
    {
        [Key]
        public int reservationid { get; set; }

        public string drivername { get; set; }

        public string vehiclemodel { get; set; }   // Model of the vehicle

        public string vehicletype { get; set; }    // Type of vehicle (e.g., sedan, SUV)

        public DateTime reservationdate { get; set; }

        public DateTime checkoutdate { get; set; }

        public DateTime returndate { get; set; }  // Nullable for possible extensions

        public decimal totalcost { get; set; }    // Total rental cost

        public string status { get; set; } = "Active";  // Reservation status (Active, Completed, etc.)
    }
}
