using System.Collections.Generic;
namespace Domain.Entities
{
    public class PartLocation
    {
       
        public int Id { get; set; }
        public string LocationName { get; set; }
        public List<Part> Parts { get; set; }
    }
}
