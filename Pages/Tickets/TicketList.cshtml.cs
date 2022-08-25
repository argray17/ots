using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ots.Data;
using ots.Models;

namespace ots.Pages.Tickets
{
    public class TicketListModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public IEnumerable<Business> Businesses { get; set; }
        public IEnumerable<Client> Clients { get; set; }
        public IEnumerable<Family> Families { get; set; }
        public IEnumerable<Staff> Staff { get; set; }
        public IEnumerable<Ticket> Tickets { get; set; }

        public TicketListModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public void OnGet()
        {
            Businesses = _db.Businesses;
            Clients = _db.Clients;
            Families = _db.Families;
            Staff = _db.Staff;
            Tickets = _db.Tickets;
        }
    }
}
