using System.Collections.Generic;

namespace Domain.Entities
{
    public class PatientContentType
    {
       
        public int Id { get; set; }
        public string Name { get; set; }

        public List<PhysiciansPatientsContent> PhysiciansPatientContents { get; set; }
    }
}
