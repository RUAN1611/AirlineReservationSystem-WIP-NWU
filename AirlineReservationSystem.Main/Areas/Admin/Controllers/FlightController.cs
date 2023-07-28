using AirlineReservationSystem.DataAccess.Repository.IRepository;
using AirlineReservationSystem.Main.Utility;
using AirlineReservationSystem.Models;
using AirlineReservationSystem.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AirlineReservationSystem.Main.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = SD.Role_Admin)]
    public class FlightController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public FlightController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            IEnumerable<Flight> flights = _unitOfWork.FlightRepository.GetAll(includeProperties:"Aircraft,OriginAirport,DestinationAirport");
            return View(flights);
        }

        public IActionResult Create()
        {
            IEnumerable<SelectListItem> AircraftList = _unitOfWork.AircraftRepository.GetAll().Select(z => new SelectListItem
            {
                Text = z.Name,
                Value = z.Id.ToString()
            });

            IEnumerable<SelectListItem> OriginAirportList = _unitOfWork.AirportRepository.GetAll().Select(z => new SelectListItem
            {
                Text = z.Name,
                Value = z.Id.ToString()
            });

            IEnumerable<SelectListItem> DestinationAirportList = _unitOfWork.AirportRepository.GetAll().Select(z => new SelectListItem
            {
                Text = z.Name,
                Value = z.Id.ToString()
            });

            FlightVM flightVM = new FlightVM()
            {
                AircraftList = AircraftList,
                OriginAirportList = OriginAirportList,
                DestinationAirportList = DestinationAirportList,
                Flight = new Flight()
            };

            return View(flightVM);
        }

        [HttpPost]
        public IActionResult Create(FlightVM flightVM)
        {
            if(ModelState.IsValid)
            {
                _unitOfWork.FlightRepository.Add(flightVM.Flight);
                _unitOfWork.Save();
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Edit(int? id)
        {
            IEnumerable<SelectListItem> AircraftList = _unitOfWork.AircraftRepository.GetAll().Select(z => new SelectListItem
            {
                Text = z.Name,
                Value = z.Id.ToString()
            });

            IEnumerable<SelectListItem> OriginAirportList = _unitOfWork.AirportRepository.GetAll().Select(z => new SelectListItem
            {
                Text = z.Name,
                Value = z.Id.ToString()
            });

            IEnumerable<SelectListItem> DestinationAirportList = _unitOfWork.AirportRepository.GetAll().Select(z => new SelectListItem
            {
                Text = z.Name,
                Value = z.Id.ToString()
            });

            FlightVM flightVM = new FlightVM()
            {
                AircraftList = AircraftList,
                OriginAirportList = OriginAirportList,
                DestinationAirportList = DestinationAirportList,
                Flight = new Flight()
            };

            flightVM.Flight = _unitOfWork.FlightRepository.Get(u => u.Id == id);
            return View(flightVM);
        }

        [HttpPost]
        public IActionResult Edit(FlightVM flightVM)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.FlightRepository.Update(flightVM.Flight);
                _unitOfWork.Save();
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Flight flight = _unitOfWork.FlightRepository.Get(u => u.Id == id);
            if (flight == null)
            {
                return NotFound();
            }

            Aircraft aircraft = _unitOfWork.AircraftRepository.Get(u => u.Id == flight.AircraftId);
            Airport originAirport = _unitOfWork.AirportRepository.Get(u => u.Id == flight.OriginAirportId);
            Airport destinationAirport = _unitOfWork.AirportRepository.Get(u => u.Id == flight.DestinationAirportId);

            List<FlightEmployee> employees = _unitOfWork.FlightEmployeeRepository.GetSome(u => u.FlightId == flight.Id);

            FlightVM flightVM = new FlightVM()
            {
                AircraftView = aircraft,
                OriginAirportView = originAirport,
                DestinationAirportView = destinationAirport,
                CountEmployees = employees.Count(),
                Flight = flight
            };

            return View(flightVM);
        }


        public IActionResult Delete(int id)
        {
            Flight? flight = _unitOfWork.FlightRepository.Get(u => u.Id == id);
            if (ModelState.IsValid)
            {
                _unitOfWork.FlightRepository.Remove(flight);
                _unitOfWork.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(flight);
        }
    }
}
