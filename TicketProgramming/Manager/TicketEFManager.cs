using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TicketProgramming.Data;
using TicketProgramming.Models;
using TicketProgramming.Models.VM;

namespace TicketProgramming.Manager
{
    public class TicketEFManager : TicketService
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

        public List<Ticket> Edit(int id)
        {
               var query = db.Tickets.Where(q => q.TicketID == id).ToList();
               return query;
        }
    }
}