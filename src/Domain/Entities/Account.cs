using Domain.Common;
using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class Account: AuditableEntity
    {
        public int Id { get; set; }
        public string BusinessName { get; set; }
        public string Phone { get; set; }
        public string Street { get; set; }
        public string Suit { get; set; }
        public string City { get; set; }
        public int StateId { get; set; }
        public State State { get; set; }
        public int CountryId { get; set; }
        public string ZipCode { get; set; }
        public int AccountTypeId { get; set; }
        public AccountType AccountType { get; set; }
        public int IsPreimum { get; set; }
        //public string name_secondary { get; set; }
        //public string phone_secondary { get; set; }
        //public string email_secondary { get; set; }
        public int? StatusTypeId { get; set; }
        public StatusType StatusType { get; set; }
        public int? TitleId { get; set; }
        //[ForeignKey("TitleId")]
        public Title Title { get; set; }
        public string EmployeeNumber { get; set; }
        public string NamePrimary { get; set; }
        public string EmailPrimary { get; set; }
        public string PhonePrimary { get; set; }
        public int? TitleIdSecondaryId { get; set; }
        public Title TitleIdSecondary { get; set; }
        public ICollection<AspNetUser> AspNetUsers { get; set; }

    }
    
}
