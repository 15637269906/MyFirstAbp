using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Text;
using MyFirstAbp.UserInfos.Dto;
using Abp.Domain.Repositories;
using MyFirstAbp.Pmgt.Auths;
using MyFirstAbp.Pmgt.SysRoles;
using MyFirstAbp.Pmgt.UserInfos;
using MyFirstAbp.Pmgt.RoleAuths;
using MyFirstAbp.Pmgt.UserRoles;

using System.Linq;
using Abp.Application.Services.Dto;
using AutoMapper;

namespace MyFirstAbp.UserInfos
{
    public class UserInfoService : ApplicationService, IUserInfoService
    {
        private readonly IRepository<SysRole> _sysRoleRepository;
        private readonly IRepository<Auth> _authRepository;
        private readonly IRepository<UserInfo> _userRepository;
        private readonly IRepository<RoleAuth> _roleAuthRepository;
        private readonly IRepository<UserRole> _userRoleRepository;
        public UserInfoService(IRepository<SysRole> sysRoleRepository, IRepository<Auth> authRepository, IRepository<RoleAuth> roleAuthRepository, IRepository<UserInfo> userRepository, IRepository<UserRole> userRoleRepository)
        {
            _sysRoleRepository = sysRoleRepository;
            _authRepository = authRepository;
            _roleAuthRepository = roleAuthRepository;
            _userRepository = userRepository;
            _userRoleRepository = userRoleRepository;
        }



        public PagedResultDto<GetUserInfoListDto> GetUserInfoLIst(GetUserInfoListInput input)
        {
            var user_all_list = _userRepository.GetAllList();
            var auth_dto_list = Mapper.Map<List<UserInfo>, List<GetUserInfoListDto>>(user_all_list);
            foreach (var a in auth_dto_list) {
                var user_role_ids = (from ur in _userRoleRepository.GetAll()
                                     where ur.UserId == a.Id
                                     select ur.RoleId
                                   ).ToList();
                a.Roles = user_role_ids.Distinct().ToArray();
            }
            if (!string.IsNullOrEmpty(input.key) && input.key != null)
            {
                auth_dto_list = (auth_dto_list.Where(q => q.Name.Contains(input.key) || q.Email.Contains(input.key) )).ToList();
            }
            if (input.status!=0)
            {
                auth_dto_list = (auth_dto_list.Where(q => q.Status==input.status)).ToList();
            }
            if (input.roleid != 0)
            {
                auth_dto_list = (auth_dto_list.Where(q => q.Roles.Contains(input.roleid))).ToList();
            }
            var page = input.page;
            var pageCount = input.pageCount;
            if (page == 0)
            {
                page = 1;
            }
            if (pageCount == 0)
            {
                pageCount = 5;
            }
            var pageSkip = (page - 1) * pageCount;
            var list_Count = auth_dto_list.Count();
            var end_list = auth_dto_list.Skip(pageSkip).Take(pageCount).ToList();
            return new PagedResultDto<GetUserInfoListDto>(list_Count,end_list);
        }





        public AddUserInfoOutput AddUserInfo(AddUserInfoInput input)
        {
            var user_id = _userRepository.InsertAndGetId(new UserInfo
            {
                Name = input.name,
            Status = input.status,
            Email=input.email,
            LoginAccount=input.loginAccount,
            });
            var role_array = input.roles;
            if (role_array.Length > 0) {
                foreach (var a in role_array) {
                    _userRoleRepository.InsertAndGetId(new UserRole
                    {
                        UserId= user_id,
                        RoleId= a
                    });
                }
            }
            return new AddUserInfoOutput {id= user_id,name=input.name,email=input.email, loginAccount=input.loginAccount,roles=input.roles };






        }

        public AddUserInfoOutput UpdateUserInfo(AddUserInfoOutput input)
        {
            //_userRepository.Update(new UserInfo {
            //    Id = input.id,
            //    Status=input.status,
            //    Name=input.name,
            //    Email=input.email,
            //    LoginAccount=input.loginAccount,
            //});
           // _userRepository.Update(input.id, p => p.Status = input.status);
            var info = _userRepository.FirstOrDefault(o=>o.Id==input.id);
            info.Name = input.name;
            info.Status = input.status;
            info.Email = input.email;
            info.LoginAccount = input.loginAccount;
             _userRepository.Update(info);


            var user_role_ids = input.roles;
            _userRoleRepository.Delete(o => o.UserId == input.id);
            foreach (var a in user_role_ids)
            {
                _userRoleRepository.InsertAndGetId(new UserRole
                {
                    UserId = input.id,
                    RoleId = a
                });
            }
                return new AddUserInfoOutput
                {
                    id = input.id,
                    status = input.status,
                    name = input.name,
                    email = input.email,
                    loginAccount = input.loginAccount,
                    roles = input.roles
                };

         
        }

        public string ResetPwd(int id)
        {
            var userinfo = _userRepository.FirstOrDefault(o => o.Id == id);
            if (userinfo != null) {
                _userRepository.Update(id,o=>o.LoginPwd="123");
                return "重置成功";
            }
            return "重置失败";
        }






       public  void DeleteUserInfo(int id) {
            _userRepository.Delete(o => o.Id == id);
        }

        public string Frozen(int id,bool enable) {
            if (enable)
            {
                _userRepository.Update(id, o => o.Status = 10);
                return "冻结成功";
            }
            else {
                _userRepository.Update(id, o => o.Status = 1);
                return "解冻成功";
            }
            return "未知错误";

        }


    }
}
