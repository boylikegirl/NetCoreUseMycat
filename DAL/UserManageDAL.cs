using DataAccess;
using IDAL;
using Microsoft.EntityFrameworkCore;
using Model;
using System;

namespace DAL
{
    public class UserManageDAL : Repository<UserInfo>,IUserManageDAL
    {
       
        public UserManageDAL(ApplicationDbContext context) : base(context)
        {
        }

        public new int Insert(UserInfo ui)
        {
            return base.Insert(ui);
        }

        public string Test()
        {
           
            return "我实现了接口方法Test";
        }
    }
}
