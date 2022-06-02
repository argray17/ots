using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ots.Data;
using ots.Models;

namespace ots.Pages.Staffing
{
    public class EditStaffModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        [BindProperty]
        public Staff Staff { get; set; }

        [BindProperty(SupportsGet = true)]
        public int Id { get; set; }
        //public IEnumerable<Ticket> Tickets { get; set; }
        //public IEnumerable<CallLogEntry> CallLogEntries { get; set; }

        public EditStaffModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
            Staff = _db.Staff.Find(Convert.ToUInt32(Id));
            //Tickets = _db.Tickets.Where(ticket => ticket.StaffId.Equals(Staff.StaffId)).AsEnumerable();
            //CallLogEntries = _db.CallLogEntries.Where(entry => entry.ClientId.Equals(Staff.StaffId)).AsEnumerable();
        }
        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                _db.Staff.Update(Staff);
                await _db.SaveChangesAsync();
                return RedirectToPage("StaffDirectory", new { Id = Staff.StaffId });
            }
            return Page();
        }
    }
}
