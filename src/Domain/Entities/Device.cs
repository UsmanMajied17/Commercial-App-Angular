using Domain.Common;
using System;
using System.Collections.Generic;


namespace Domain.Entities
{
    public class Device:AuditableEntity
    {
       
        public int DeviceId { get; set; }
        public string Description { get; set; }
        public string Sku { get; set; }
        public string Name { get; set; }
        public long? AssignedUserId { get; set; }
        public AspNetUser AssignedUser { get; set; }
        public int StatusId { get; set; }
        public int DeviceTypeId { get; set; }
       // public DateTime created_at { get; set; }
        public DeviceType DeviceType { get; set; }
        public List<DeployedPlaylist> DeployedPlayLists { get; set; }
        public List<Part> Parts { get; set; }
        
        public List<int> PartId { get; set; }
    }
}
