using Car_Service_Station.Models;
using Microsoft.AspNetCore.Mvc;

namespace Car_Service_Station.Controllers
{
    public class CarController : Controller

        
    {
        private readonly CarServiceDbContext _dbContext;

        private readonly IWebHostEnvironment webHostEnvironment;

        public CarController(CarServiceDbContext dbContext, IWebHostEnvironment webHostEnvironment)
        {
            this._dbContext = dbContext;
            this.webHostEnvironment = webHostEnvironment;
        }

        public IActionResult AddCar()
        {
            return View();
        }


 
         

        public IActionResult Index()
        {
            return View();
        }
    }
}
