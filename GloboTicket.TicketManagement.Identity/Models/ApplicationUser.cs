using Microsoft.AspNetCore.Identity;

namespace GloboTicket.TicketManagement.Identity.Models
{
    public class ApplicationUser : IdentityUser
    {
        public int MyProperty { get; set; }

        public int MyProperty1 { get; set; }
        public int MyProperty2 { get; set;}
    }
}
