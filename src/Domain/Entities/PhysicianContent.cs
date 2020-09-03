

namespace Domain.Entities
{
    public class PhysicianContent
    {
       
        public int ContentId { get; set; }

        public long PhysicianId { get; set; }

        public Content Content { get; set; }
    }
}
