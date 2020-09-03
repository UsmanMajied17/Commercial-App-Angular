using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
   public class SchedulerAction
    {
        //[Key]
        
        public int Id { get; set; }
        public int Name { get; set; }
        public List<PhysicialFileSchedulerAction> PhysicialFileSchedulerActions { get; set; }
        
    }
}
