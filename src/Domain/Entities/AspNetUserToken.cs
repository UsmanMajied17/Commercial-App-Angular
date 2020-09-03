


namespace Domain.Entities
{
    
    public partial class AspNetUserToken
    {
        public long UserId { get; set; }
        public string LoginProvider { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }

        public AspNetUser User { get; set; }
    }
}
