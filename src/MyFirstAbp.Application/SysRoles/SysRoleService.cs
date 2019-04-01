using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Text;
using MyFirstAbp.SysRoles.Dto;
using Abp.Domain.Repositories;

using System.Linq;
using AutoMapper;
using Abp.Application.Services.Dto;
using MyFirstAbp.Pmgt.SysRoles;
using MyFirstAbp.Pmgt.Auths;
using MyFirstAbp.Pmgt.RoleAuths;


namespace MyFirstAbp.SysRoles
{

    public class SysRoleService : ApplicationService, ISysRoleService
    {
        private readonly IRepository<SysRole> _sysRoleRepository;
        private readonly IRepository<Auth> _authRepository;
        private readonly IRepository<RoleAuth> _roleAuthRepository;
        public SysRoleService(IRepository<SysRole> sysRoleRepository, IRepository<Auth> authRepository, IRepository<RoleAuth> roleAuthRepository)
        {
            _sysRoleRepository = sysRoleRepository;
            _authRepository = authRepository;
            _roleAuthRepository = roleAuthRepository;

            }

        public AddRolesOutput AddRoles(AddRolesIntput input)
        {
            var sysRole_entity = _sysRoleRepository.FirstOrDefault(o => o.Name.Equals(input.Name));
                if (sysRole_entity != null) {
            }
         
           // var auth_dto_list = new List<AuthDto>();
           // var auth_list = new List<Auth>();
            var role_id = _sysRoleRepository.InsertAndGetId(new SysRole { Name=input.Name});
            var array = input.Auth;
            foreach (var a in array) {
                _roleAuthRepository.InsertAndGetId(new RoleAuth { AuthId =a, RoleId = role_id }); 
            }
          //var   auth_list = _authRepository.GetAllList(p => p.Id  in  array);
            var auth_list = (from p in _authRepository.GetAllList()
                            where array.Contains(p.Id)
                            select p).ToList();
            var auth_dto_list = Mapper.Map<List<Auth>, List<AuthDto>>(auth_list);
            AddRolesOutput addRolesOutput = new AddRolesOutput();
            addRolesOutput.Id = role_id;
            addRolesOutput.Name = input.Name;
            addRolesOutput.Auths = auth_dto_list.ToArray();
            return addRolesOutput;
        }



        public void DeleteRoles(int id)
        {

            _sysRoleRepository.Delete(id);

        }






        public PagedResultDto<RolePageListDto> GetRolePageList(GetRolePageListInput input)
        {
            var role_list = (from r in _sysRoleRepository.GetAll()
                             select r
                           ).ToList();

            var role_dto_list = Mapper.Map<List<SysRole>, List<RolePageListDto>>(role_list);
          
            foreach (var role in role_dto_list) {
                var auth_list = (from s in _authRepository.GetAll()
                                 where (from r in _roleAuthRepository.GetAll() where r.RoleId == role.Id select r.AuthId).Contains(s.Id)
                                 select s
                               ).ToList();
                var auth_dto_list = Mapper.Map<List<Auth>, List<AuthDto>>(auth_list);
                role.Auths = auth_dto_list.ToArray();
            }
            if (!string.IsNullOrEmpty(input.key) && input.key != null)
            {
                role_dto_list = (role_dto_list.Where(q => q.Name.Contains(input.key))).ToList();
            }
            var page = input.page;
            var pageCount = input.pageCount;
            if (page == 0) {
                page = 1;
            }
            if ( pageCount == 0)
            {
                pageCount = 5;
            }
            var list_count = role_dto_list.Count();
            var SkipCount = (page - 1) * pageCount;
            var end_list = role_dto_list.Skip(SkipCount).Take(pageCount).ToList();
            return new PagedResultDto<RolePageListDto>(list_count, end_list);
        }

        public AddRolesOutput UpdateSysRole(UpdateSysRoleInput input)
        {
            var SysRole = _sysRoleRepository.FirstOrDefault(p => p.Id == input.id);
            SysRole.Name = input.name;
            var auths_array = input.auths;
            _roleAuthRepository.Delete(o => o.RoleId == input.id);
            foreach (var auth in auths_array)
            {
                _roleAuthRepository.Insert(new RoleAuth
                {
                    RoleId = input.id,
                    AuthId = auth
                });
            }

            var auth_list = (from a in _authRepository.GetAll()
                             where auths_array.Contains(a.Id)
                             select a
                           ).ToList();
            var auth_dto_list = Mapper.Map<List<Auth>,List<AuthDto>>(auth_list);

           
            return new AddRolesOutput { Id = input.id, Name = SysRole.Name, Auths = auth_dto_list.ToArray() };
        }
    }
}
