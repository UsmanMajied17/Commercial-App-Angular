

namespace Domain.Entities
{
 
    public  class AspNetUserClaim
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public string ClaimType { get; set; }
        public string ClaimValue { get; set; }

        public AspNetUser User { get; set; }
    }
}
