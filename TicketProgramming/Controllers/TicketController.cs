using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using TicketProgramming.Data;
using TicketProgramming.Manager;
using TicketProgramming.Models.VM;

namespace TicketProgramming.Controllers
{
    public class TicketController : Controller
    {
        List<Ticket> _Ticket = new List<Ticket>();
        TicketService _TicketService = new TicketManager();
        
        /* Personel Tarafi*/
        [HttpGet]
        public ActionResult CreateTicket()
        {            
                return View();            
        }

        [HttpPost]
        public ActionResult CreateTicket(Ticket ticket)
        {
            _TicketService.CreateTicket(ticket);
            return RedirectToAction("AllTickets");
        }

        [HttpGet]
        //Personel Ticketleri görmektedir.
        public ActionResult Tickets()
        {
            return View(_TicketService.GetPersonelAllTickets("alikaraduran@gmail.com"));
        }
        
        // ********************************************************
      
        [HttpGet]
        //Bilgi İslem Sef Tüm Ticketleri Görmektedir.
        public ActionResult AllTickets()
        {
            return View(_TicketService.GetAllTickets());
        }
       
        [HttpGet]
        public ActionResult Edit(int TicketID)
        {
            var query = _TicketService.Edit(TicketID);
            return View(query);
        }

    }
}