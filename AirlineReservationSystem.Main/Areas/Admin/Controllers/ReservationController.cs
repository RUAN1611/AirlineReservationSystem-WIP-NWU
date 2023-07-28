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
    public class ReservationController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public ReservationController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            IEnumerable<Reservation> reservations = _unitOfWork.ReservationRepository.GetAll(includeProperties: "Flight,Customer");
            return View(reservations);
        }

        public IActionResult Create()
        {
            IEnumerable<SelectListItem> flightList = _unitOfWork.FlightRepository.GetAll().Select(x => new SelectListItem
            {
                Text = x.Id.ToString() + " " + x.DepartureTime.ToString(),
                Value = x.Id.ToString()
            });
            IEnumerable<SelectListItem> customerList = _unitOfWork.CustomerRepository.GetAll().Select(x => new SelectListItem
            {
                Text = x.FirstName.ToString() + " " + x.LastName.ToString() + " - " + x.IDNumber.ToString(),
                Value = x.Id.ToString()
            });
            ReservationVM reservationVM = new ReservationVM()
            {
                Reservation = new Reservation(),
                FlightList = flightList,
                CustomerList = customerList
            };
            return View(reservationVM);
        }

        [HttpPost]
        public IActionResult Create(ReservationVM reservationVM)
        {
            if(ModelState.IsValid)
            {
                reservationVM.Reservation.DateCreated = DateTime.Now;
                _unitOfWork.ReservationRepository.Add(reservationVM.Reservation);
                _unitOfWork.Save();
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Edit(int? id)
        {
            IEnumerable<SelectListItem> flightList = _unitOfWork.FlightRepository.GetAll().Select(x => new SelectListItem
            {
                Text = x.Id.ToString() + " " + x.DepartureTime.ToString(),
                Value = x.Id.ToString()
            });
            IEnumerable<SelectListItem> customerList = _unitOfWork.CustomerRepository.GetAll().Select(x => new SelectListItem
            {
                Text = x.FirstName.ToString() + " " + x.LastName.ToString() + " - " + x.IDNumber.ToString(),
                Value = x.Id.ToString()
            });
            ReservationVM reservationVM = new ReservationVM()
            {
                Reservation = new Reservation(),
                FlightList = flightList,
                CustomerList = customerList
            };

            reservationVM.Reservation = _unitOfWork.ReservationRepository.Get(u => u.Id == id);
            return View(reservationVM);
        }

        [HttpPost]
        public IActionResult Edit(ReservationVM reservationVM)
        {
            if(ModelState.IsValid)
            {
                _unitOfWork.ReservationRepository.Update(reservationVM.Reservation);
                _unitOfWork.Save();
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Delete(int id)
        {
            Reservation? reservation = _unitOfWork.ReservationRepository.Get(u => u.Id == id);
            if (ModelState.IsValid)
            {
                _unitOfWork.ReservationRepository.Remove(reservation);
                _unitOfWork.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(reservation);
        }
    }
}
