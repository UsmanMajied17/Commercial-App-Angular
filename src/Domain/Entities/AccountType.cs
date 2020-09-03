﻿using System.Collections.Generic;

namespace Domain.Entities
{
    public class AccountType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Account> Accounts { get; set; }

    }
}
