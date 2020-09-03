using System;
using System.Collections.Generic;
using System.Text;
using xtheia.DataAccessLayer.Entities;

namespace Domain.Entities
{
    public class Country
    {
        public int Id { get; set; }
        public string CountryCode { get; set; }
        public string CountryName { get; set; }
        public List<State> States { get; set; }
    }
}
