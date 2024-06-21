using Car_Service_Station.Models;
using Microsoft.AspNetCore.Mvc;

namespace Car_Service_Station.Controllers
{
    public class AppointmentController : Controller   
    {

        private  CarServiceDbContext _dbContext;

        private  IWebHostEnvironment webHostEnvironment;

        public AppointmentController(CarServiceDbContext dbContext, IWebHostEnvironment webHostEnvironment) { 
            this._dbContext = dbContext;
            this.webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Create_Appointment()
        {

            return View();
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
