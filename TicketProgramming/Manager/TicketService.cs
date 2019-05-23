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
        List<Ticket> GetAllTickets(); // Tüm Ticketler
        bool CreateTicket(Ticket ticket);
        List<Ticket> Edit(int id);
        List<Ticket> GetPersonelAllTickets(string mail);
       // bool CheckLogin(string Username, string password);
    }
}