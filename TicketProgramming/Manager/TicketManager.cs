using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TicketProgramming.Data;
using TicketProgramming.Models;
using TicketProgramming.Models.VM;

namespace TicketProgramming.Manager
{
    public class TicketManager : TicketService
    {
        
        TicketDatabaseEntities db = new TicketDatabaseEntities();

        public List<Ticket> GetAllTickets()
        { 
            return db.Tickets.ToList();
        }


        public bool CreateTicket(Ticket ticket)
        {
            try
            {
                db.Tickets.Add(ticket);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}