using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ots.Data;
using ots.Models;

namespace ots.Pages.Clients
{
    public class ClientDirectoryModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public IEnumerable<Client> Clients { get; set; }
        public IEnumerable<Business> Businesses { get; set; }
        public IEnumerable<Family> Families { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SearchCriteria { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SortOption { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SortDirection { get; set; }

        public ClientDirectoryModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public void OnGet()
        {
            Clients = _db.Clients;
            Businesses = _db.Businesses;
            Families = _db.Families;
        }

        public void OnGetSearchClients()
        {
            switch (SearchCriteria)
            {
                case "ClientId":
                    Clients = _db.Clients.Where(client => client.ClientId == Convert.ToUInt32(SearchString));
                    break;
                case "FirstName":
                    Clients = _db.Clients.Where(client => client.FirstName.Equals(SearchString));
                    break;
                case "LastName":
                    Clients = _db.Clients.Where(client => client.LastName.Equals(SearchString));
                    break;
                case "PrimaryPhoneNumber":
                    Clients = _db.Clients.Where(client => client.PrimaryPhoneNumber.Equals(SearchString));
                    break;
                case "SecondaryPhoneNumber":
                    Clients = _db.Clients.Where(client => client.SecondaryPhoneNumber.Equals(SearchString));
                    break;
                case "EmailAddress":
                    Clients = _db.Clients.Where(client => client.EmailAddress.Equals(SearchString));
                    break;
                default:
                    Clients = _db.Clients;
                    break;
            }
            Businesses = _db.Businesses;
            Families = _db.Families;
        }

        public void OnGetSortClients()
        {
            switch (SortOption)
            {
                case "StaffId":
                    if (SortDirection.Equals("Ascending")) { Clients = _db.Clients.OrderBy(client => client.ClientId); }
                    else { Clients = _db.Clients.OrderByDescending(client => client.ClientId); }
                    break;
                case "FirstName":
                    if (SortDirection.Equals("Ascending")) { Clients = _db.Clients.OrderBy(client => client.FirstName); }
                    else { Clients = _db.Clients.OrderByDescending(client => client.FirstName); }
                    break;
                case "LastName":
                    if (SortDirection.Equals("Ascending")) { Clients = _db.Clients.OrderBy(client => client.LastName); }
                    else { Clients = _db.Clients.OrderByDescending(client => client.LastName); }
                    break;
                case "EmailAddress":
                    if (SortDirection.Equals("Ascending")) { Clients = _db.Clients.OrderBy(client => client.EmailAddress); }
                    else { Clients = _db.Clients.OrderByDescending(client => client.EmailAddress); }
                    break;
                default:
                    Clients = _db.Clients;
                    break;
            }
            Businesses = _db.Businesses;
            Families = _db.Families;
        }

        public void OnGetSearchBusinesses()
        {
            switch (SearchCriteria)
            {
                case "ClientId":
                    Businesses = _db.Businesses.Where(business => business.BusinessId == Convert.ToUInt32(SearchString));
                    break;
                case "BusinessId":
                    Businesses = _db.Businesses.Where(business => business.BusinessName.Equals(SearchString));
                    break;
                case "PrimaryPhoneNumber":
                    Businesses = _db.Businesses.Where(business => business.PrimaryPhoneNumber.Equals(SearchString));
                    break;
                case "SecondaryPhoneNumber":
                    Businesses = _db.Businesses.Where(business => business.SecondaryPhoneNumber.Equals(SearchString));
                    break;
                case "EmailAddress":
                    Businesses = _db.Businesses.Where(business => business.EmailAddress.Equals(SearchString));
                    break;
                default:
                    Businesses = _db.Businesses;
                    break;
            }
            Clients = _db.Clients;
            Families = _db.Families;
        }

        public void OnGetSortBusinesses()
        {
            switch (SortOption)
            {
                case "StaffId":
                    if (SortDirection.Equals("Ascending")) { Businesses = _db.Businesses.OrderBy(business => business.BusinessId); }
                    else { Businesses = _db.Businesses.OrderByDescending(business => business.BusinessId); }
                    break;
                case "BusinessName":
                    if (SortDirection.Equals("Ascending")) { Businesses = _db.Businesses.OrderBy(business => business.BusinessName); }
                    else { Businesses = _db.Businesses.OrderByDescending(business => business.BusinessName); }
                    break;
                case "EmailAddress":
                    if (SortDirection.Equals("Ascending")) { Businesses = _db.Businesses.OrderBy(business => business.EmailAddress); }
                    else { Businesses = _db.Businesses.OrderByDescending(business => business.EmailAddress); }
                    break;
                default:
                    Businesses = _db.Businesses;
                    break;
            }
            Clients = _db.Clients;
            Families = _db.Families;
        }

        public void OnGetSearchFamilies()
        {
            switch (SearchCriteria)
            {
                case "FamilyId":
                    Families = _db.Families.Where(family => family.FamilyId == Convert.ToUInt32(SearchString));
                    break;
                case "FamilyName":
                    Families = _db.Families.Where(family => family.FamilyName.Equals(SearchString));
                    break;
                default:
                    Families = _db.Families;
                    break;
            }
            Clients = _db.Clients;
            Businesses = _db.Businesses;
        }

        public void OnGetSortFamilies()
        {
            switch (SortOption)
            {
                case "FamilyId":
                    if (SortDirection.Equals("Ascending")) { Families = _db.Families.OrderBy(family => family.FamilyId); }
                    else { Families = _db.Families.OrderByDescending(family => family.FamilyId); }
                    break;
                case "BusinessName":
                    if (SortDirection.Equals("Ascending")) { Families = _db.Families.OrderBy(family => family.FamilyName); }
                    else { Families = _db.Families.OrderByDescending(family => family.FamilyName); }
                    break;
                default:
                    Families = _db.Families;
                    break;
            }
            Clients = _db.Clients;
            Businesses = _db.Businesses;
        }

        public void OnGetReset()
        {
            Clients = _db.Clients;
            Businesses = _db.Businesses;
            Families = _db.Families;
        }
    }
}
