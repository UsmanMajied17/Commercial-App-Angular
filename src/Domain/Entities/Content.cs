using Domain.Common;
using System;
using System.Collections.Generic;


namespace Domain.Entities
{
    public class Content:AuditableEntity
    {
        
        public int Id { get; set; }
      
        //public DateTime created_at { get; set; }
        public bool SharedGlobally { get; set; }

        public int TypeId { get; set; }
        public int CatagoryId { get; set; }
        public long OwnerId { get; set; }
        public AspNetUser Owner { get; set; }
        public string ProductCatagory { get; set; }
        public string Description { get; set; }
        // public int catagory_id { get; set; }
        public bool PreimumStatus { get; set; }  
        public int StatusTypeId { get; set; }
        public StatusType StatusType { get; set; }
        public float RevisionNumber { get; set; }
        public bool BackgroundRemoval { get; set; }
        public int PhysicialFileId { get; set; }
        public PhysicialFile PhysicialFile { get; set; }
        public List<PlaylistContent> PlaylistContents { get; set; }
        public Physicians Physician { get; set; }
        public ContentTypes ContentType { get; set; }
        public ContentCatagories ContentCategory { get; set; }
       
    }
}
