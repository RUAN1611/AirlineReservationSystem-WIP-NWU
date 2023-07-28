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
    public class FlightEmployeeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public FlightEmployeeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            IEnumerable<FlightEmployee> employees = _unitOfWork.FlightEmployeeRepository.GetAll(includeProperties:"Employee,Flight");
            return View(employees);
        }

        public IActionResult Create()
        {
            IEnumerable<SelectListItem> FlightList = _unitOfWork.FlightRepository.GetAll().Select(z => new SelectListItem
            {
                Text = z.Id.ToString() + " - " + z.ArrivalTime.ToString(),
                Value = z.Id.ToString()
            });

            IEnumerable<SelectListItem> EmployeeList = _unitOfWork.EmployeeRepository.GetAll().Select(z => new SelectListItem
            {
                Text = z.Id.ToString() + " - " + z.FirstName + " " + z.LastName,
                Value = z.Id.ToString()
            });

            FlightEmployeeVM flightEmployeeVM = new FlightEmployeeVM()
            {
                FlightList = FlightList,
                EmployeeList = EmployeeList,
                FlightEmployee = new FlightEmployee()
            };

            return View(flightEmployeeVM);
        }

        [HttpPost]
        public IActionResult Create(FlightEmployeeVM flightEmployeeVM)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.FlightEmployeeRepository.Add(flightEmployeeVM.FlightEmployee);
                _unitOfWork.Save();
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Edit(int? FlightId, int? EmployeeId)
        {
            IEnumerable<SelectListItem> FlightList = _unitOfWork.FlightRepository.GetAll().Select(z => new SelectListItem
            {
                Text = z.Id.ToString() + " - " + z.ArrivalTime.ToString(),
                Value = z.Id.ToString()
            });

            IEnumerable<SelectListItem> EmployeeList = _unitOfWork.EmployeeRepository.GetAll().Select(z => new SelectListItem
            {
                Text = z.Id.ToString() + " - " + z.FirstName + " " + z.LastName,
                Value = z.Id.ToString()
            });

            FlightEmployeeVM flightEmployeeVM = new FlightEmployeeVM()
            {
                FlightList = FlightList,
                EmployeeList = EmployeeList,
                FlightEmployee = new FlightEmployee()
            };

            flightEmployeeVM.FlightEmployee = _unitOfWork.FlightEmployeeRepository.Get(u => u.FlightId == FlightId && u.EmployeeId == EmployeeId);
            return View(flightEmployeeVM);
        }

        [HttpPost]
        public IActionResult Edit(FlightEmployeeVM flightEmployeeVM, int FlightId, int EmployeeId)
        {
            if (ModelState.IsValid)
            {
                FlightEmployee? oldFlightEmployee = _unitOfWork.FlightEmployeeRepository.Get(u => u.FlightId == FlightId && u.EmployeeId == EmployeeId);
                if (oldFlightEmployee != null)
                {
                    _unitOfWork.FlightEmployeeRepository.Remove(oldFlightEmployee);
                    _unitOfWork.Save();
                }

                var newFlightEmployee = new FlightEmployee
                {
                    FlightId = flightEmployeeVM.FlightEmployee.FlightId,
                    EmployeeId = flightEmployeeVM.FlightEmployee.EmployeeId,
                    JobRole = flightEmployeeVM.FlightEmployee.JobRole,
                };

                _unitOfWork.FlightEmployeeRepository.Add(newFlightEmployee);
                _unitOfWork.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(flightEmployeeVM);
        }

        public IActionResult Delete(int FlightId, int EmployeeId)
        {
            FlightEmployee? flightEmployee = _unitOfWork.FlightEmployeeRepository.Get(u => u.FlightId == FlightId && u.EmployeeId == EmployeeId);
            if (ModelState.IsValid)
            {
                _unitOfWork.FlightEmployeeRepository.Remove(flightEmployee);
                _unitOfWork.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(flightEmployee);
        }
    }
}
