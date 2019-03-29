using Abp.Application.Services.Dto;
using Microsoft.AspNetCore.Mvc;
using MyFirstAbp.UserInfos;
using MyFirstAbp.UserInfos.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstAbp.Web.Controllers
{

    [Route("api/users")]
    public class UserInfoController : MyFirstAbpControllerBase
    {
        private IUserInfoService _IUserInfoService;
        public UserInfoController(IUserInfoService IUserInfoService) {
            _IUserInfoService = IUserInfoService;

        }



        [HttpGet]
        [Route("GetAllUserInfo")]
        public PagedResultDto<GetUserInfoListDto> GetAllUserInfo(GetUserInfoListInput input) {
            var pageResult = _IUserInfoService.GetUserInfoLIst(input);
            return pageResult;
        }


        [HttpPost]
        [Route("AddUserInfo")]
        public AddUserInfoOutput AddUserInfo(AddUserInfoInput input)
        {
            var result = _IUserInfoService.AddUserInfo(input);
            return result;
        }
        [HttpPut]
        [Route("UpdateUserInfo")]
        public AddUserInfoOutput UpdateUserInfo(AddUserInfoOutput input)
        {
            var result = _IUserInfoService.UpdateUserInfo(input);
            return result;
        }


        [HttpPost]
        [Route("RestPwd")]
        public string RestPwd(int id)
        {
            string result = _IUserInfoService.ResetPwd(id);
            return result;
        }

        [HttpDelete]
        [Route("DeleteUserInfo")]
        public void DeleteUserInfo(int id)
        {
            _IUserInfoService.DeleteUserInfo(id);
        }

        [HttpPut]
        [Route("Frozen")]
        public string Frozen(int id, bool enable) {
            string result = _IUserInfoService.Frozen(id, enable);
            return result;
        }
     







    }
}
