using Domain.Common;
using System;


namespace Domain.Entities
{
    public class Part:AuditableEntity
    {
       
        public int PartId { get; set; }
        public int PartTypeId { get; set; }
        public PartType PartType { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
       
        //public DateTime created_at { get; set; }
        public string SerialNo { get; set; }


        public int? DeviceId { get; set; }
        //[ForeignKey("part_type_id")]
        public DateTime? FirmwareDate { get; set; }
        //[NotMapped]
        public string FirmwareDateStr { get; set; }
        //[NotMapped]
        //public string DeviceId { get; set; }

        public int PartLocationId { get; set; }
        public PartLocation PartLocation { get; set; }
        public Device Device { get; set; }
    }
}
