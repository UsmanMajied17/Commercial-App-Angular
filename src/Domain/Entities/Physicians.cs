using System.Collections.Generic;

namespace Domain.Entities
{
    public class Physicians
    {

        //[Key]
        public long UserId { get; set; }

        public int RoleId { get; set; }
        //[ForeignKey("user_id")]
        public AspNetUser AspNetUser { get; set; }

        public ICollection<Content> Contents { get; set; }
        public List<PhysicianPatient> PhysicianPatients { get; set; }
    }
}
