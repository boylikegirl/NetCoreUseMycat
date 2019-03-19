
using DataAccess;
using Model;
using System;

namespace IDAL
{
    public interface IUserManageDAL:IRepository<UserInfo>
    {
            /// <summary>
            /// 插入
            /// </summary>
            /// <param name="ui"></param>
            /// <returns></returns>
            new int  Insert(UserInfo ui);
           /// <summary>
          /// 测试接口
          /// </summary>
          /// <returns></returns>
          string Test();
    }
}
