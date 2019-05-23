using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TicketProgramming.Controllers;
using TicketProgramming.Data;
using TicketProgramming.Models;
using TicketProgramming.Models.VM;

namespace TicketProgramming.Manager
{
    public class TicketEFManager : TicketService
    {
       // public bool LoginOperation = false;
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

        public List<Ticket> GetPersonelAllTickets(string _mail)
        {
            return db.Tickets.Where(q => q.Mail == _mail).ToList();
        }

       /* public bool CheckLogin(string UserName, string password)
        {
            var login = db.Users.Where(q => q.UserName == UserName && q.Password == password).ToList();

            if (login != null)
            {
                TicketController tc = new TicketController();
                tc.LoginOperation = true;
                return true;
            }
            else
            {
                return false;
            }
        }*/
    }
}