using AirlineReservationSystem.DataAccess.Repository.IRepository;
using AirlineReservationSystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace AirlineReservationSystem.Main.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class CustomerController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public CustomerController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            IEnumerable<AirlineReservationSystem.Models.Customer> customer = _unitOfWork.CustomerRepository.GetAll();
            return View(customer);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(AirlineReservationSystem.Models.Customer customer)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.CustomerRepository.Add(customer);
                _unitOfWork.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(customer);
        }

        public IActionResult Edit(int? id)
        {
            if (id == 0 || id == 0)
            {
                return NotFound();
            }
            AirlineReservationSystem.Models.Customer? customer = _unitOfWork.CustomerRepository.Get(u => u.Id == id);
            if (customer == null)
            {
                return NotFound();
            }
            return View(customer);
        }

        [HttpPost]
        public IActionResult Edit(AirlineReservationSystem.Models.Customer customer)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.CustomerRepository.Update(customer);
                _unitOfWork.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(customer);
        }

        public IActionResult Details(int? id)
        {
            if (id == 0 || id == null)
            {
                return NotFound();
            }
            AirlineReservationSystem.Models.Customer? customer = _unitOfWork.CustomerRepository.Get(u => u.Id == id);
            if (customer == null)
            {
                return NotFound();
            }
            return View(customer);
        }

        public IActionResult Delete(int id)
        {
            AirlineReservationSystem.Models.Customer? customer = _unitOfWork.CustomerRepository.Get(u => u.Id == id);
            if (ModelState.IsValid)
            {
                _unitOfWork.CustomerRepository.Remove(customer);
                _unitOfWork.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(customer);
        }
    }
}
