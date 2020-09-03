using System.Collections.Generic;

namespace Domain.Entities
{
    public class Title
    {
        //[Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public List<AspNetUser> AspNetUsers { get; set; }
    }
}
