using System;
using AcccountManager.Core;

namespace AcccountManager.Models
{
    public class Account:ModelBase<int>
    {

        public string Code { get; set; }
        public string Name { get; set; }

        public AccountType AccountType { get; set; }
        public int AccountTypeId { get; set; }


    }
}
