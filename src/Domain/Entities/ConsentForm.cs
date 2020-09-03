using System;
using System.Collections.Generic;

using System.Text;

namespace Domain.Entities
{
    public class ConsentForm
    {
       
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public string Url { get; set; }
        public List<PatientConsent> PatientConsents { get; set; }
    }
}
