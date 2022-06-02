using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ots.Data;
using ots.Models;

namespace ots.Pages.Staffing
{
    public class StaffProfileModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public Staff Staff { get; set; }

        [BindProperty(SupportsGet = true)]
        public int Id { get; set; }
        //public IEnumerable<Ticket> Tickets { get; set; }
        //public IEnumerable<CallLogEntry> CallLogEntries { get; set; }

        public StaffProfileModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
            Staff = _db.Staff.Find(Convert.ToUInt32(Id));
            //Tickets = _db.Tickets.Where(ticket => ticket.StaffId.Equals(Staff.StaffId)).AsEnumerable();
            //CallLogEntries = _db.CallLogEntries.Where(entry => entry.ClientId.Equals(Staff.StaffId)).AsEnumerable();
        }
    }
}
