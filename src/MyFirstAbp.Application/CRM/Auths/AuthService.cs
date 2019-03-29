using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Text;
using MyFirstAbp.CRM.Auths.Dto;
using Abp.Domain.Repositories;
using AutoMapper;
using MyFirstAbp.Pmgt.Auths;
using MyFirstAbp.CRM.Auths;
using MyFirstAbp.Auths;

namespace MyFirstAbp.CRM.Auths
{
    public class AuthService : ApplicationService, IAuthService
    {

        private readonly IRepository<Auth> _authRepository;
        public AuthService(IRepository<Auth> authRepository) {
            _authRepository = authRepository;
        }


        public GetAllAuthsOutput GetAllAuths()
        {
            //var menu_list = new List<GetAllAuthsDto>();
            var all_list = _authRepository.GetAllList();
            var auth_list = _authRepository.GetAllList(o=>o.ParentId==0);
            var auth_dto_list = Mapper.Map<List<Auth>, List<GetAllAuthsDto>>(auth_list);
            foreach (var aDto in auth_dto_list) {
                //var children_list = _authRepository.GetAllList(o => o.ParentId == aDto.Id);
                //var children_dto_list = Mapper.Map<List<Auth>, List<GetAllAuthsDto>>(children_list);
                //aDto.children = children_dto_list.ToArray();
                aDto.children = (getChildren(aDto.Id, all_list)).ToArray();
            }
            return new GetAllAuthsOutput { getAllAuthsDto = auth_dto_list };
        }

        public List<GetAllAuthsDto> getChildren(int id, List<Auth> rootMenu) {
            var childList = new List<Auth>();
            foreach (var menu in rootMenu) {
                if (menu.ParentId == id) {
                    childList.Add(menu);
                }
            }
            var children_dto_list = Mapper.Map<List<Auth>, List<GetAllAuthsDto>>(childList);
            foreach (var childrenmenu in children_dto_list) {
                childrenmenu.children = (getChildren(childrenmenu.Id, rootMenu)).ToArray();
            }
            return children_dto_list;
        }
        //public void getEndList(List<GetAllAuthsDto> list) {
        //    //for (int i = 1; i <= list.Count; i++)             
        //    //{
        //    //}
        //    foreach (var aDto in list) {
        //        var children_list= _authRepository.GetAllList(o => o.ParentId == aDto.id);
        //        var children_dto_list = Mapper.Map<List<Auth>, List<GetAllAuthsDto>>(children_list);
        //        aDto.children = children_dto_list.ToArray();
        //        getEndList(children_dto_list);
        //    }

        //}


    }
}
