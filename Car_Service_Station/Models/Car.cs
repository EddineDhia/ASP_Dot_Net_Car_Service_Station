using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Car_Service_Station.Models
{
    public class Car
    {
        

        [Key]
        [Column(TypeName ="int")]
        public int CarId { get; set; }  // Primary key

        [Required]
        [Column(TypeName ="varchar(50)")]
        [DisplayName("Make")]
        public string Make { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        [DisplayName("Model")]
        public string Model { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        [DisplayName("Body Type")]
        public string BodyType { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        [DisplayName("Engine Spec")]
        public string EngineSpec { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        [DisplayName("Energie")]
        public string Energie { get; set; }

        [Required]
        [Column(TypeName = "int")]
        [DisplayName("Power")]
        public int Power { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        [DisplayName("Plate Licence")]
        public string PlateLicence { get; set; }

        [Required]
        [Column(TypeName = "int")]
        [DisplayName("Model Year")]
        public int Model_Year { get; set; }


        [Required]
        [Column(TypeName = "Date")]
        [DisplayName("Next Date Service")]
        public DateTime NextDateService { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        [DisplayName("Owner Name")]
        public string OwnerName { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        [DisplayName("Owner Email")]
        public string OwnerEmail { get; set; }

        [NotMapped]
        [DisplayName("Upload File")]
        public IFormFile ImageFile { get; set; }

        [Required]
        [Column(TypeName = "float")]
        [DisplayName("Price Invoke")]
        public float PriceInvoke { get; set; }

        public virtual ICollection<ServiceCar> ServiceCars { get; set; }
        public virtual Appointment Appointment { get; set; }


    }
}
