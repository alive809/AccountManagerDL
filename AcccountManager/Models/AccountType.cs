using System;
using System.Collections.Generic;
using AcccountManager.Core;
using AcccountManager.Models;

namespace AcccountManager
{
    public class AccountType:ModelBase<int>
    {

        public string code { get; set; }
        public string name { get; set; }

        public ICollection<Account> Accounts { get; set; }
    }
}
