using System.Collections.Generic;


namespace Domain.Entities
{
    public class ContentCatagories
    {
      
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Content> Contents { get; set; }
    }
}
