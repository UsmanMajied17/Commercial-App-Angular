using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
   public class ProcessingStatus
    {
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
       // [StringLength(45)]
        public string Name { get; set; }
    }
}
