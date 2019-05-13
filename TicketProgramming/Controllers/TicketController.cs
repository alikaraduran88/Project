using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TicketProgramming.Manager;
using TicketProgramming.Models.VM;

namespace TicketProgramming.Controllers
{
    public class TicketController : Controller
    {
       
        List<Models.Ticket> _Ticket = new List<Models.Ticket>();
        
         TicketService _TicketService = new TicketManager();

         [HttpGet]
        public ActionResult CreateTicket()
        {
            
            return View();
        }
        [HttpPost]
        public ActionResult CreateTicket(int KullaniciID,string Mail,string Ticket1,string Aciklama,string IsAktif, string Nott)
        {
            

            return View();
        }

        [HttpGet]
        public ActionResult AllTickets()
        {   
            _Ticket = _TicketService.GetAllTickets();
            return View(_Ticket);
        }
    }
}