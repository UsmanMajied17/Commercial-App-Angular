using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class PhysicialFileSchedulerAction
    {
       
        public int Id { get; set; }
        public int? PhysicialFileSchedulerId { get; set; }
        public PhysicialFileSchedulerAction PhysicialFileScheduler { get; set; }
        public int PhysicialFileId { get; set; }
        public int SchedulerActionId { get; set; }
        public SchedulerAction SchedulerAction { get; set; }
        public int ProcessingStatusId { get; set; } = 1;
        public ProcessingStatus ProcessingStatus { get; set; }
        public int MergeLocation { get; set; } = 0;
        public int? PreviousMergeLocation { get; set; }
        public string RelativeDestPath { get; set; }
        public string RelativeSrcPath { get; set; }
        public string SrcFileName { get; set; }
        public string DestFileName { get; set; }
        //[Column(TypeName = "json")]
        public string ExtraInfo { get; set; }
        public string Error { get; set; }
        //[ForeignKey("physicial_file_id")]
        public PhysicialFile PhysicialFiles { get; set; }
       
        public HashSet<PhysicialFileSchedulerAction> Children { get; set; }
    }
}
