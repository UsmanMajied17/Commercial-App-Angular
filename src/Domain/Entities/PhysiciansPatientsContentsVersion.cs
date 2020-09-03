using Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
  public  class PhysiciansPatientsContentsVersion:AuditableEntity
    {
        //[Key]
        public int Id { get; set; }
        public int PhysicianPatientContentId { get; set; }
        public PhysiciansPatientsContent PhysicianPatientContent { get; set; }
        public string TextInImage { get; set; }
        public int PhysicialFileId { get; set; }
        public PhysicialFile PhysicialFile { get; set; }
        public string Notes { get; set; }
        //[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        //public DateTime created_at { get; set; }
        //[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        //public DateTime updated_at { get; set; }
       
    }
}
