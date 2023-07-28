using AirlineReservationSystem.DataAccess.Repository.IRepository;
using AirlineReservationSystem.Main.Utility;
using AirlineReservationSystem.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AirlineReservationSystem.Main.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = SD.Role_Admin)]
    public class AircraftController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public AircraftController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            IEnumerable<Aircraft> aircraft = _unitOfWork.AircraftRepository.GetAll();
            return View(aircraft);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Aircraft aircraft)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.AircraftRepository.Add(aircraft);
                _unitOfWork.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(aircraft);
        }

        public IActionResult Edit(int? id)
        {
            if (id == 0 || id == 0)
            {
                return NotFound();
            }
            Aircraft? aircraft = _unitOfWork.AircraftRepository.Get(u => u.Id == id);
            if (aircraft == null)
            {
                return NotFound();
            }
            return View(aircraft);
        }

        [HttpPost]
        public IActionResult Edit(Aircraft aircraft)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.AircraftRepository.Update(aircraft);
                _unitOfWork.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(aircraft);
        }

        public IActionResult Details(int? id)
        {
            if(id == 0 || id == null)
            {
                return NotFound();
            }
            Aircraft? aircraft = _unitOfWork.AircraftRepository.Get(u => u.Id == id);
            if (aircraft == null)
            {
                return NotFound();
            }
            return View(aircraft);
        }

        public IActionResult Delete(int? id)
        {
            if (id == 0 || id == 0)
            {
                return NotFound();
            }
            Aircraft? aircraft = _unitOfWork.AircraftRepository.Get(u => u.Id == id);
            if (aircraft == null)
            {
                return NotFound();
            }
            return View(aircraft);
        }

        [HttpPost]
        [ActionName("Delete")]
        public IActionResult DeletePOST(int? id)
        {
            Aircraft? aircraft = _unitOfWork.AircraftRepository.Get(u => u.Id == id);
            if (ModelState.IsValid)
            {
                _unitOfWork.AircraftRepository.Remove(aircraft);
                _unitOfWork.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(aircraft);
        }
    }
}
