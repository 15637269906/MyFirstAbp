using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstAbp.Persons
{
    public interface ILoginService : IApplicationService
    {

        bool Login(string name, string pwd);
    }
}
