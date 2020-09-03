
using Domain.Common;
using System;
using System.Collections.Generic;

using System.Dynamic;

namespace Domain.Entities
{
    public class PhysicialFile:AuditableEntity
    {
       
        public int Id { get; set; }
        public string FileName { get; set; }
        public string Ext { get; set; }
        public TimeSpan Length { get; set; }

        public int? PreviousMergeLocation { get; set; }
        public string EncodedPath { get; set; }
       
        //[Column(TypeName = "json")]
        public string ExtraInfo { get; set; }
       
        public Content Content { get; set; }
        public List<PhysicialFileSchedulerAction> PhysicialFileSchedulerAction { get; set; }
        public List<PhysicialSubFile> PhysicialSubFiles { get; set; }
        public PhysiciansPatientsContent PhysiciansPatientsContent { get; set; }
        public PhysiciansPatientsContentsVersion PhysiciansPatientsContentsVersion { get; set; }

    }
}
