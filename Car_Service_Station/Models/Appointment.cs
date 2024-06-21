using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Car_Service_Station.Models
{
    public class Appointment
    {
        [Key]
        public int AppointmentId { get; set; }

        public DateTime AppointmentDate { get; set; }

        [Required]
        [ForeignKey("CarId")]
        public int CarId { get; set; }

        public virtual Car Car { get; set; }
    }
}
