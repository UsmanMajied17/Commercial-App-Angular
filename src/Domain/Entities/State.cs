using System.Collections.Generic;

namespace Domain.Entities
{
    public class State
    {
        //[Key]
        public int Id { get; set; }
        public string Abbr { get; set; }
        public string Name { get; set; }
        public int CountryId { get; set; }

        public Country Country { get; set; }

        public List<Account> Accounts { get; set; }


    }
}
