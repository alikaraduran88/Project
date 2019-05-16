using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TicketProgramming.Data;
using TicketProgramming.Models.VM;

namespace TicketProgramming.Manager
{
    public interface TicketService
    {
        List<Ticket> GetAllTickets();
        bool CreateTicket(Ticket ticket);

    }
}