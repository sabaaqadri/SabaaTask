using SabaaTask.CORE.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace SabaaTask.CORE.Repository
{
    public interface IUserIoginRepository
    {
        List<Userlogin> GetAll_UserLogin();
        Userlogin GetUserLogin_ById(int id);
        void Create_UserLogin(Userlogin userlogin);
        void Update_UserLogin(Userlogin userlogin);
        void Delete_UserLogin(int id);
    }
}
