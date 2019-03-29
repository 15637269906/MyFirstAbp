using Abp.Application.Services;
using System;

using Abp.Domain.Repositories;
using System.Linq;
using System.Linq.Dynamic.Core;
using Microsoft.EntityFrameworkCore.Internal;
using MyFirstAbp.Pmgt.SysRoles;
using MyFirstAbp.Pmgt.RoleAuths;
using MyFirstAbp.Pmgt.UserRoles;
using MyFirstAbp.Pmgt.Auths;
using MyFirstAbp.CRM.Login.Dto;



namespace MyFirstAbp.CRM.Login
{
    public class LoginService : ApplicationService, ILoginService
    {
        private readonly IRepository<SysRole> _sysRoleRepository;
        private readonly IRepository<Auth> _authRepository;
        private readonly IRepository<UserInfo> _userRepository;
        private readonly IRepository<RoleAuth> _roleAuthRepository;
        private readonly IRepository<UserRole> _userRoleRepository;
        public LoginService(IRepository<SysRole> sysRoleRepository, IRepository<Auth> authRepository, IRepository<RoleAuth> roleAuthRepository, IRepository<UserInfo> userRepository, IRepository<UserRole> userRoleRepository)
        {
            _sysRoleRepository = sysRoleRepository;
            _authRepository = authRepository;
            _roleAuthRepository = roleAuthRepository;
            _userRepository = userRepository;
            _userRoleRepository = userRoleRepository;
        }
        public LoginOutput Login(LoginInput input)
        {
          UserInfo user= _userRepository.FirstOrDefault(o => o.LoginAccount.Equals(input.loginAccount));
            if (user.Status == 1) {
                if (user.LoginPwd.Equals(input.loginPwd))
                {
                  //  user.PassModifyTime = DateTime.Now;//更改上次登录时间
                    LoginOutput output = new LoginOutput();
                    output.id = user.Id;
                    output.name = user.Name;
                    //var role_list = (from r in _sysRoleRepository.GetAll()
                    //                 where (from ur in _userRoleRepository.GetAll() where ur.UserId==user.Id select ur.RoleId).Contains(r.Id)
                    //                 select r.Id
                    //               ).ToList();
                    var role_list = (from ur in _userRoleRepository.GetAll()
                                     where ur.UserId == user.Id
                                     select ur.RoleId
                                   ).ToList();
                    output.roles = role_list.Distinct().ToArray();
                    var auth_list = (from ra in _roleAuthRepository.GetAll()
                                     where output.roles.Contains(ra.RoleId)
                                     select ra.AuthId
                                    ).ToList();
                    output.auths = auth_list.Distinct().ToArray();
                   
                    return output;
                    //var LoginOutput = (from r in _sysRoleRepository.GetAll()
                    //                 join ur in _userRoleRepository.GetAll()
                    //                 on r.Id equals ur.RoleId
                    //                 where ur.UserId==user.Id
                    //                 select new LoginOutput
                    //                 {
                    //                 }).ToList()
                }
            }
            return null;
        }
    }
}
