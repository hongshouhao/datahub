using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Geone.AuthorisationFilter.ResourceAuth
{
    public class ApiAuthProlicyResourceAuthProvider : IApiProtectionProlicyProvider
    {
        public ApiAuthProlicyResourceAuthProvider(IConfiguration configuration)
        {
        }

        public ApiProtectionProlicy GetProlicy(ActionContext actionContext)
        {
            throw new NotImplementedException();
        }
    }
}
