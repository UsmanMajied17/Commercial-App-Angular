using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class Patient
    {
       
        public int PatientId { get; set; }
        public string PatientNo { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string SSN { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public bool HasPatientConsentForm { get; set; }
        public List<PhysicianPatient> PhysicianPatients { get; set; }
        public List<PatientsFaceRecognition> PatientsFaceRecognitions { get; set; }

        //public List<PatientSharedContent> PatientSharedContents { get; set; }

    }
}
