using Abp.Application.Services;
using MyFirstAbp.Auths.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstAbp.Auths
{
    public interface IAuthService:IApplicationService
    {
        GetAllAuthsOutput GetAllAuths();

    }
}
