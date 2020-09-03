using System.Collections.Generic;
namespace Domain.Entities
{
    public class PartType
    {
       
        public int Id { get; set; }
        public string Name { get; set; }
        public int PartCategoryId { get; set; }
        public PartCategory PartCategory { get; set; }
        public ICollection<Part> Parts { get; set; }
        
    }
}
