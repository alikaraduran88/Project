using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TicketProgramming.Manager
{
    public interface TicketService
    {
        List<Models.Ticket> GetAllTickets();
    }
}