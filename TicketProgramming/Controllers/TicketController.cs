using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TicketProgramming.Data;
using TicketProgramming.Manager;
using TicketProgramming.Models.VM;

namespace TicketProgramming.Controllers
{
    public class TicketController : Controller
    {
       
        List<Ticket> _Ticket = new List<Ticket>();
        
         TicketService _TicketService = new TicketManager();

         [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Ticket ticket)
        {
            _TicketService.CreateTicket(ticket);
            return RedirectToAction("AllTickets");
        }

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
        // **********************************************

        [HttpGet]
        //Bilgi İslem Sef Tüm Ticketleri Görmektedir.
        public ActionResult AllTickets()
        {
            
            return View(_TicketService.GetAllTickets());
        }


        // **********************************************
        //Personeller Kendi Ticketlerini Görmektedir.
        [HttpGet]
        public ActionResult PersonelTickets()
        {
            return View();
        }

        [HttpPost]
        public ActionResult PersonelTickets(Ticket _Ticket)
        {
            return View();
        }

        // **********************************************

        //Bilgi işlem Ticketlerini Görmektedir.
        [HttpGet]
        public ActionResult ITTickets()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ITTickets(Ticket _Ticket)
        {
            return View();
        }

    }
}