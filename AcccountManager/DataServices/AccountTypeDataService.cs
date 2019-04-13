using System;
using AcccountManager.Core;
using AutoMapper;

namespace AcccountManager.DataServices
{
    public class AccountTypeDataService
        :DataServiceBase<AccountType, AcountManagerDBContext>
    {
        public AccountTypeDataService(IMapper mapper, AcountManagerDBContext context):base(mapper, context)
        {

        }
    }
}
