using System;
using System.Collections.Generic;
namespace Domain.Entities
{
    public class PhysiciansPatientsContent
    {
       // [Key]
        
        public int Id { get; set; }
        public int PhysicianPatientId { get; set; }
        public PhysicianPatient PhysicianPatient { get; set; }
        public bool SharedGlobally { get; set; }
        public string BodyParts { get; set; }
        //[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        //public DateTime created_at { get; set; }
        //[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        //public DateTime updated_at { get; set; }
        public string Description { get; set; }
        public int PatientContentTypeId { get; set; }
        public PatientContentType PatientContentType { get; set; }
        public int PhysicialFileId { get; set; }
        public PhysicialFile PhysicialFile { get; set; }
        public List<PhysiciansPatientsContentsVersion> PatientsContentsVersions { get; set; }
    }
}
