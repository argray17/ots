using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ots.Data;
using ots.Models;

namespace ots.Pages.Staffing
{
    public class AddNewStaffModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        [BindProperty]
        public Staff Staff { get; set; }

        public AddNewStaffModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPost()
        {
            await _db.Staff.AddAsync(Staff);
            await _db.SaveChangesAsync();
            return RedirectToPage("StaffDirectory");
        }
    }
}
