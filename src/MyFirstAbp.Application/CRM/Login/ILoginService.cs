using Abp.Application.Services;
using MyFirstAbp.CRM.Login.Dto;

using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstAbp.CRM.Login
{
    public interface ILoginService:IApplicationService
    {
        LoginOutput Login(LoginInput input);



    }
}
