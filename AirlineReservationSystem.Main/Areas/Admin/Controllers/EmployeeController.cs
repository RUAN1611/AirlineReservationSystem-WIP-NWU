using AirlineReservationSystem.DataAccess.Repository.IRepository;
using AirlineReservationSystem.Main.Utility;
using AirlineReservationSystem.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AirlineReservationSystem.Main.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = SD.Role_Admin)]
    public class EmployeeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public EmployeeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            IEnumerable<Employee> employee = _unitOfWork.EmployeeRepository.GetAll();
            return View(employee);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.EmployeeRepository.Add(employee);
                _unitOfWork.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(employee);
        }

        public IActionResult Edit(int? id)
        {
            if (id == 0 || id == 0)
            {
                return NotFound();
            }
            Employee? employee = _unitOfWork.EmployeeRepository.Get(u => u.Id == id);
            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }

        [HttpPost]
        public IActionResult Edit(Employee employee)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.EmployeeRepository.Update(employee);
                _unitOfWork.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(employee);
        }

        public IActionResult Details(int? id)
        {
            if (id == 0 || id == null)
            {
                return NotFound();
            }
            Employee? employee = _unitOfWork.EmployeeRepository.Get(u => u.Id == id);
            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }

        public IActionResult Delete(int id)
        {
            Employee? employee = _unitOfWork.EmployeeRepository.Get(u => u.Id == id);
            if (ModelState.IsValid)
            {
                _unitOfWork.EmployeeRepository.Remove(employee);
                _unitOfWork.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(employee);
        }
    }
}
