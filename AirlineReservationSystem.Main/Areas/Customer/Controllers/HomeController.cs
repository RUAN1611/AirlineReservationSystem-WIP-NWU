using AirlineReservationSystem.DataAccess.Repository.IRepository;
using AirlineReservationSystem.Main.Models;
using AirlineReservationSystem.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AirlineReservationSystem.Main.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUnitOfWork _unitOfWork;

        public HomeController(ILogger<HomeController> logger, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            IEnumerable<Flight> flights = _unitOfWork.FlightRepository.GetAll(includeProperties: "Aircraft,OriginAirport,DestinationAirport");
            return View(flights);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}