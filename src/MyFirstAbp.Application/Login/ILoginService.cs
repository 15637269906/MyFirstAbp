using Abp.Application.Services;
using MyFirstAbp.Login.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstAbp.Login
{
    public interface ILoginService:IApplicationService
    {
        LoginOutput Login(LoginInput input);


    }
}
