
namespace Domain.Entities
{
    public class UsersSecurityQuestion
    {
        //[Key]
        public int SecurityQuestionId { get; set; }
        public int UserId { get; set; }
        public string Answer { get; set; }
        public SecurityQuestion Question { get; set; }
    }


}
