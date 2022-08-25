using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ots.Data;
using ots.Models;

namespace ots.Pages.Clients
{
    public class AddNewBusinessModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        [BindProperty]
        public Business Business { get; set; }

        public AddNewBusinessModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPost()
        {
            await _db.Businesses.AddAsync(Business);
            await _db.SaveChangesAsync();
            return RedirectToPage("ClientDirectory");
        }
    }
}
