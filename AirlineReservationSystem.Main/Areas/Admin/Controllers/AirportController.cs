using AirlineReservationSystem.DataAccess.Data;
using AirlineReservationSystem.DataAccess.Repository.IRepository;
using AirlineReservationSystem.Main.Utility;
using AirlineReservationSystem.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AirlineReservationSystem.Main.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = SD.Role_Admin)]
    public class AirportController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public AirportController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            IEnumerable<Airport> airports = _unitOfWork.AirportRepository.GetAll();
            return View(airports);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Airport airport)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.AirportRepository.Add(airport);
                _unitOfWork.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(airport);
        }

        public IActionResult Edit(int? id)
        {
            if (id == 0 || id == 0)
            {
                return NotFound();
            }
            Airport? airport = _unitOfWork.AirportRepository.Get(u => u.Id == id);
            if(airport == null)
            {
                return NotFound();
            }
            return View(airport);
        }

        [HttpPost]
        public IActionResult Edit(Airport airport)
        {
            if(ModelState.IsValid)
            {
                _unitOfWork.AirportRepository.Update(airport);
                _unitOfWork.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(airport);
        }

        public IActionResult Delete(int? id)
        {
            if (id == 0 || id == 0)
            {
                return NotFound();
            }
            Airport? airport = _unitOfWork.AirportRepository.Get(u => u.Id == id);
            if (airport == null)
            {
                return NotFound();
            }
            return View(airport);
        }

        [HttpPost]
        [ActionName("Delete")]
        public IActionResult DeletePOST(int? id)
        {
            Airport? airport = _unitOfWork.AirportRepository.Get(u => u.Id == id);
            if (ModelState.IsValid)
            {
                _unitOfWork.AirportRepository.Remove(airport);
                _unitOfWork.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(airport);
        }
    }
}
