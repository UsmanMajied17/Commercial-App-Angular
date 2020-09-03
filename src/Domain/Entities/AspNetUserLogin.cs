

namespace Domain.Entities
{
   
    public partial class AspNetUserLogin
    {
        
        public string LoginProvider { get; set; }
       
        public string ProviderKey { get; set; }
        public string ProviderDisplayName { get; set; }
        public long UserId { get; set; }
        public AspNetUser User { get; set; }
    }
}
