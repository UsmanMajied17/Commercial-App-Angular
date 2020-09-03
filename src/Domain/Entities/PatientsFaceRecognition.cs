using Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class PatientsFaceRecognition:AuditableEntity
    {
       
        public int Id { get; set; }
        public string SourceFolder { get; set; }
        public string OrginalImage { get; set; }
        public string ImageBinding { get; set; }
        public string OrginalImagePath { get; set; }
        public int PatientId { get; set; }
        public Patient Patient { get; set; }
        //[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        //public DateTime created_at { get; set; }
        //[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        //public DateTime updated_at { get; set; } 


    }
}
