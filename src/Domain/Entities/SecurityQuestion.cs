using System.Collections.Generic;

namespace Domain.Entities
{
    public class SecurityQuestion
    {
        //[Key]
        public int Id { get; set; }
        public string Question { get; set; }
        public List<UsersSecurityQuestion> UsersSecurityQuestions { get; set; }
    }


}
