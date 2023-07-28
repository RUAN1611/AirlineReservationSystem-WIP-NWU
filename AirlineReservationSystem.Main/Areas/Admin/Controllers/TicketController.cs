using AirlineReservationSystem.DataAccess.Repository.IRepository;
using AirlineReservationSystem.Models;
using AirlineReservationSystem.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AirlineReservationSystem.Main.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TicketController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public TicketController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            IEnumerable<Ticket> ticketList = _unitOfWork.TicketRepository.GetAll(includeProperties:"Reservation");
            return View(ticketList);
        }

        public IActionResult Create()
        {
            IEnumerable<SelectListItem> reservationList = _unitOfWork.ReservationRepository.GetAll().Select(x => new SelectListItem
            {
                Text = x.Id.ToString(),
                Value = x.Id.ToString()
            });

            TicketVM ticketVM = new TicketVM()
            {
                Ticket = new Ticket(),
                ReservationList = reservationList
            };
            return View(ticketVM);
        }

        [HttpPost]
        public IActionResult Create(TicketVM ticketVM)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.TicketRepository.Add(ticketVM.Ticket);
                _unitOfWork.Save();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        public IActionResult Edit(int? id)
        {
            IEnumerable<SelectListItem> reservationList = _unitOfWork.ReservationRepository.GetAll().Select(x => new SelectListItem
            {
                Text = x.Id.ToString(),
                Value = x.Id.ToString()
            });

            TicketVM ticketVM = new TicketVM()
            {
                Ticket = new Ticket(),
                ReservationList = reservationList
            };

            ticketVM.Ticket = _unitOfWork.TicketRepository.Get(u => u.Id == id);
            return View(ticketVM);
        }

        [HttpPost]
        public IActionResult Edit(TicketVM ticketVM)
        {
            if(ModelState.IsValid)
            {
                _unitOfWork.TicketRepository.Update(ticketVM.Ticket);
                _unitOfWork.Save();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
    }
}
