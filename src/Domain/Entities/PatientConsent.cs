using Domain.Common;
using System;
using System.Collections.Generic;

using System.Text;

namespace Domain.Entities
{
   public class PatientConsent:AuditableEntity
    {
      
        public int Id { get; set; }
        public int PhysicianPatientId { get; set; }
        public PhysicianPatient PhysicianPatient { get; set; }
        public string FileName { get; set; }
        public string Ext { get; set; }
        public string EncodedPath { get; set; }
       
        //public DateTime created_at { get; set; }
       
       //public DateTime updated_at { get; set; }
        public string ThumbnailEncodedPath { get; set; }
        public int? ConsentFormsId { get; set; }
        public ConsentForm ConsentForms { get; set; }
       
    }
}
