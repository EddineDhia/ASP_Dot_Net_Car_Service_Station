using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Car_Service_Station.Models
{
    public class ServiceCar
    {
        [Key]
      public int ServiceId { get; set; }

       public string ServiceName { get; set; }

        public float Price { get; set; }

        [Required]
        [ForeignKey("CarId")]
        public int CarId { get; set; }

        public virtual Car Car { get; set; }
    }
}
