
using Microsoft.EntityFrameworkCore;

namespace Car_Service_Station.Models
{
    public class CarServiceDbContext : DbContext
    {
        public CarServiceDbContext(DbContextOptions<CarServiceDbContext> options) : base(options)
        {
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<ServiceCar> ServiceCars { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
    }
}




/*
using Car_Service_Station.Models;
using Microsoft.EntityFrameworkCore;

namespace WebApp_Tp.Models.Entities
{
    public class dataBaseContext : DbContext
    {
        public dataBaseContext(DbContextOptions<dataBaseContext> options) : base(options)
        {

        }
        public DbSet<Car> Cars { get; set; }
        public DbSet<ServiceCar> ServiceCars { get; set; }
        public DbSet<Appointment> Appointments { get; set; }

    }
}

*/