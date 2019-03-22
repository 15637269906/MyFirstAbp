using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstAbp.Persons
{
    public interface ILoginService : IApplicationService
    {

        string Login(string name, string pwd);//查询

        bool delete_user(int id);//删除

        bool add_user(string usernmae, string password);//新增

        string update_user(int id,string username);//修改

    }
}
