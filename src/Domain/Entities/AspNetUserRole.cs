

namespace Domain.Entities
{
 
    public partial class AspNetUserRole
    {
        public long UserId { get; set; }
        public long RoleId { get; set; }
        public AspNetRole Role { get; set; }
        public AspNetUser User { get; set; }
    }
}
