using System;
using AcccountManager.Core;
using AutoMapper;

namespace AcccountManager.DataServices
{
    public class AccountDataService:DataServiceBase<AccountDataService, AcountManagerDBContext>
    {
        public AccountDataService(IMapper mapper, AcountManagerDBContext context): base(mapper,context)
        {

        }
    }
}
