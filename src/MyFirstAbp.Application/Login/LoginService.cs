using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Text;
using MyFirstAbp.Login.Dto;
using Abp.Domain.Repositories;
using MyFirstAbp.SysRoles;
using MyFirstAbp.Auths;
using MyFirstAbp.RoleAuths;
using MyFirstAbp.UserInfos;
using MyFirstAbp.UserRoles;

namespace MyFirstAbp.Login
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


            return new LoginOutput();
        }
    }
}
