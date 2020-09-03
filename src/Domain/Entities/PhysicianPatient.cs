using Domain.Common;
using System;
using System.Collections.Generic;


namespace Domain.Entities
{
    public class PhysicianPatient:AuditableEntity
    {
        
        public int PhysicianPatientId { get; set; }

        public Physicians Physician { get; set; }
        public long PhysicianId { get; set; }

        
        public int PatientId { get; set; }
        public Patient Patient { get; set; }
        //[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        //public DateTime created_at { get; set; }
        //[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        //public DateTime updated_at { get; set; }
        public List<PhysiciansPatientsContent> PhysiciansPatientsContents { get; set; }
        public List<PatientConsent> PatientConsents { get; set; }
    }
}
