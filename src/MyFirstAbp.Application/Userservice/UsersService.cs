using System;
using System.Collections.Generic;
using System.Text;
using MyFirstAbp.Userservice.Dto;
using Abp.Domain.Repositories;
using MyFirstAbp.Users;
using AutoMapper;
using System.Linq;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Microsoft.EntityFrameworkCore;
using Abp.Linq.Extensions;
using System.Linq.Dynamic.Core;
using Abp.AutoMapper;
using Abp.Collections.Extensions;

namespace MyFirstAbp.Userservice
{
    public class UsersService : ApplicationService, IUsersService
    {
        private readonly IRepository<User> _taskRepository;


        public UsersService(IRepository<User> taskRepository)
        {
            _taskRepository = taskRepository;
        }
        
        /*----------------------------------------------------------------查询------------------------------------------------------------------------*/
        public SearchUserOutput SearchUser(SearchUserInput input)
        {

            //Mapper.Initialize(cfg =>
            //{
            //    cfg.CreateMap<User, UserDto>();
            //});
            var userEntityList = _taskRepository.GetAllList(user => user.username.Contains(input.SearchedName));
            //return new SearchUserOutput { User = Mapper.Map < List < UserDto >>{ userEntityList } };
            //var userDtoList = userEntityList.Select(user => new UserDto
            //{
            //    Id = user.Id,
            //    username = user.username,
            //    description = user.description

            //}).ToList();

            var b = Mapper.Map<List<User>, List<UserDto>>(userEntityList);

            return new SearchUserOutput { User = b };


        }

        /*----------------------------------------------------------查询-------------------------------------------------------*/












        /*----------------------------------------------------------------分页-----------------------------------------------------------------*/
        public PagedResultDto<UserDto> GetPagedUsers(GetUserInput input)
        {
            

            var query = _taskRepository.GetAll();
            query = !string.IsNullOrEmpty(input.Sorting) ? query.OrderBy(input.Sorting): query.OrderByDescending(t=>t.Id);
            var tasksCount = query.Count();
           var taskList = query.Skip(input.SkipCount).Take(input.MaxResultCount).ToList();
            //var taskList = query.PageBy(input).ToList();
            return new PagedResultDto<UserDto>(tasksCount, taskList.MapTo<List<UserDto>>());
        }
        /*---------------------------------------------------------------分页------------------------------------------------------------------------------*/


    }
}
