using System;
using System.Collections.Generic;
using System.Text;
using MyFirstAbp.Userservice.Dto;
using Abp.Domain.Repositories;
using MyFirstAbp.Users;
using AutoMapper;
using System.Linq;

namespace MyFirstAbp.Userservice
{
    class UsersService : IUsersService
    {
        private readonly IRepository<User> _taskRepository;


        public UsersService(IRepository<User> taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public SearchUserOutput SearchUser(SearchUserInput input)
        {
            var userEntityList = _taskRepository.GetAllList(user => user.username.Contains(input.SearchedName));
            //  return new SearchUserOutput { User = AutoMapper.Mapper < List < UserDto >>{ userEntityList } };
            var userDtoList = userEntityList.Select(user => new UserDto {
                Id=user.Id,
                username=user.username,
                description=user.description

            }).ToList();

            return new SearchUserOutput { User = userDtoList };


        }
    }
}
