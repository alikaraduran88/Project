using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TicketProgramming.Models.VM
{
    public class TicketVM
    {
        
        public int KullaniciID{ get; set; }
        public string Mail { get; set; }
        public string Ticket1 { get; set; }
        public string Aciklama { get; set; }
        public string IsAktif { get; set; }
        public string Nott { get; set; }
    }
}