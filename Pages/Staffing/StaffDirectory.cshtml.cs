using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ots.Data;
using ots.Models;

namespace ots.Pages.Staffing
{
    public class StaffDirectoryModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public IEnumerable<Staff> Staff { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SearchCriteria { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SortOption { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SortDirection { get; set; }

        public StaffDirectoryModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public void OnGet()
        {
            Staff = _db.Staff;
        }

        public void OnGetSearch()
        {
            switch (SearchCriteria)
            {
                case "StaffId":
                    Staff = _db.Staff.Where(staff => staff.StaffId == Convert.ToUInt32(SearchString));
                    break;
                case "FirstName":
                    Staff = _db.Staff.Where(staff => staff.FirstName.Equals(SearchString));
                    break;
                case "LastName":
                    Staff = _db.Staff.Where(staff => staff.LastName.Equals(SearchString));
                    break;
                case "PrimaryPhoneNumber":
                    Staff = _db.Staff.Where(staff => staff.PrimaryPhoneNumber.Equals(SearchString));
                    break;
                case "SecondaryPhoneNumber":
                    Staff = _db.Staff.Where(staff => staff.SecondaryPhoneNumber.Equals(SearchString));
                    break;
                case "EmailAddress":
                    Staff = _db.Staff.Where(staff => staff.EmailAddress.Equals(SearchString));
                    break;
                default:
                    Staff = _db.Staff;
                    break;
            }
        }

        public void OnGetSort()
        {
            switch (SortOption)
            {
                case "StaffId":
                    if (SortDirection.Equals("Ascending")) { Staff = _db.Staff.OrderBy(staff => staff.StaffId); }
                    else { Staff = _db.Staff.OrderByDescending(staff => staff.StaffId); }
                    break;
                case "FirstName":
                    if (SortDirection.Equals("Ascending")) { Staff = _db.Staff.OrderBy(staff => staff.FirstName); }
                    else { Staff = _db.Staff.OrderByDescending(staff => staff.FirstName); }
                    break;
                case "LastName":
                    if (SortDirection.Equals("Ascending")) { Staff = _db.Staff.OrderBy(staff => staff.LastName); }
                    else { Staff = _db.Staff.OrderByDescending(staff => staff.LastName); }
                    break;
                case "EmailAddress":
                    if (SortDirection.Equals("Ascending")) { Staff = _db.Staff.OrderBy(staff => staff.EmailAddress); }
                    else { Staff = _db.Staff.OrderByDescending(staff => staff.EmailAddress); }
                    break;
                default:
                    Staff = _db.Staff;
                    break;
            }
        }

        public void OnGetReset()
        {
            Staff = _db.Staff;
        }
    }
}
