using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
  public  class RelatedFile
    {
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
