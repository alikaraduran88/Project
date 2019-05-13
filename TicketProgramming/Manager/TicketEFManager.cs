using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TicketProgramming.Models;

namespace TicketProgramming.Manager
{
    public class TicketEFManager : TicketService
    {
        public List<Models.Ticket> _Ticket;
    
        public List<Models.Ticket> GetAllTickets()
        {

            return _Ticket.ToList();
        }
    }
}