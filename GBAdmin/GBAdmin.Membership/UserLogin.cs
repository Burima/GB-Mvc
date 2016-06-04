using Microsoft.AspNet.Identity.EntityFramework;
namespace GBAdmin.Membership
{
    public class UserLogin : IdentityUserLogin<long>
    {
        public virtual User User { get; set; }
    }
}
