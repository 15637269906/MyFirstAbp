using Abp.Application.Services;
using Abp.Application.Services.Dto;

using MyFirstAbp.UserInfos.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstAbp.UserInfos
{
   public interface IUserInfoService:IApplicationService
    {
        PagedResultDto<GetUserInfoListDto> GetUserInfoLIst(GetUserInfoListInput input);

        AddUserInfoOutput AddUserInfo(AddUserInfoInput input);

        AddUserInfoOutput UpdateUserInfo(AddUserInfoOutput input);
        string ResetPwd(int id);

        void DeleteUserInfo(int id);

        string Frozen(int id,bool enable);
    }
}
