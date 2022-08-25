using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ots.Data;
using ots.Models;

namespace ots.Pages.Tickets
{
    public class CreateTicketModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        [BindProperty]
        public Ticket Ticket { get; set; }
        public IEnumerable<Business> Businesses { get; set; }
        public IEnumerable<Client> Clients { get; set; }
        public IEnumerable<Family> Families { get; set; }
        public IEnumerable<Staff> Staff { get; set; }

        public CreateTicketModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
            Businesses = _db.Businesses;
            Clients = _db.Clients;
            Families = _db.Families;
            Staff = _db.Staff;
        }
        public async Task<IActionResult> OnPost()
        {
            await _db.Tickets.AddAsync(Ticket);
            await _db.SaveChangesAsync();
            return RedirectToPage("TicketList");
        }
    }
}
