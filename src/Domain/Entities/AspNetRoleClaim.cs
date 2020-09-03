

namespace Domain.Entities
{
    public partial class AspNetRoleClaim
    {
        public long Id { get; set; }
        public long RoleId { get; set; }
        public string ClaimType { get; set; }
        public string ClaimValue { get; set; }

        public AspNetRole Role { get; set; }
    }
}
