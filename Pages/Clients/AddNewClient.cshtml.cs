using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ots.Data;
using ots.Models;

namespace ots.Pages.Clients
{
    public class AddNewClientModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        [BindProperty]
        public Client Client { get; set; }

        public AddNewClientModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPost()
        {
            await _db.Clients.AddAsync(Client);
            await _db.SaveChangesAsync();
            return RedirectToPage("ClientDirectory");
        }
    }
}
