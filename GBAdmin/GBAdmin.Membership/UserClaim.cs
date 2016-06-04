using Microsoft.AspNet.Identity.EntityFramework;

namespace GBAdmin.Membership
{
    public class UserClaim : IdentityUserClaim<long>
    {

        public virtual User User { get; set; }
    }
}
