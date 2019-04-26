using Microsoft.AspNet.Identity.EntityFramework;

namespace ShareWork.Web.Models
{
    public class ApplicationUser : IdentityUser
    {
        public int Year { get; set; }
        public ApplicationUser()
        {
        }
    }
}