using Domain.Common;
using System;
using System.Collections.Generic;

using System.Text;

namespace Domain.Entities
{
  public  class PhysicialSubFile:AuditableEntity
    {
        public int PhysicialFileId { get; set; }
        public PhysicialFile PhysicialFile { get; set; }
      
        public int RelatedFileId { get; set; }
        public RelatedFile RelatedFile { get; set; }
        public string EncodedPath { get; set; }
     
    }
}
