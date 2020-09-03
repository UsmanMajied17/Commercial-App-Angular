using System.Collections.Generic;


namespace Domain.Entities
{
    public class PartCategory
    {
       
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<PartType> PartsTypes { get; set; }
    }
}
