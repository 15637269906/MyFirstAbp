using Abp.Application.Services;
using Abp.Domain.Repositories;
using MyFirstAbp.Roles;
using MyFirstAbp.UserRoles.Dto;
using MyFirstAbp.Users;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace MyFirstAbp.UserRoles
{



    public class UserRoleService : ApplicationService, IUserRoleService
    {

        private readonly IRepository<User> _userRepository;
        private readonly IRepository<Role> _roleRepository;
        public UserRoleService(IRepository<User> userRepository, IRepository<Role> roleRepository) {
            _userRepository = userRepository;
            _roleRepository = roleRepository;
        }
        public SearchAllUserRoleOutput SearchAllUserRole(SearchAllUserRoleInput input)
        {


            //var all = from u in _userRepository.GetAll()
            //          join r in _roleRepository.GetAll() on u.id equals r.userId;
         //    NorthwindDataContext db = new NorthwindDataContext();
            var list = new List<UserRoleDto>();
               list = (from u in _userRepository.GetAll()
                      join r in _roleRepository.GetAll() on u.Id equals r.userId
                     //  where u.username.Contains(input.UserName) || r.rolename.Contains(input.RoleName)
                       select new UserRoleDto
                   {
                       UserName = u.username,
                       RoleName = r.rolename
                   }).ToList();

            if (!string.IsNullOrEmpty(input.UserName) && input.UserName != null)
            {
                list = (list.Where(q => q.UserName.Contains(input.UserName) )).ToList();
            }
            if (!string.IsNullOrEmpty(input.RoleName) && input.RoleName != null)
            {
                list = (list.Where(q => q.RoleName.Contains(input.RoleName))).ToList();
            }

            return new SearchAllUserRoleOutput { UserRole = list };
        }
    }
}
