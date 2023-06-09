using Microsoft.Extensions.Configuration;
using SabaaTask.CORE.Data;
using SabaaTask.CORE.Repository;
using SabaaTask.CORE.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace SabaaTask.INFRA.Service
{
    public class UserloginService : IUserloginService
    {
        private readonly IUserIoginRepository _userIoginRepository;
        private readonly IConfiguration _config;
        public UserloginService(IUserIoginRepository userIoginRepository, IConfiguration config)
        {
            _userIoginRepository = userIoginRepository;
            _config = config;
        }



        public void Create_UserLogin(Userlogin userlogin)
        {
            _userIoginRepository.Create_UserLogin(userlogin);
        }

        public void Delete_UserLogin(int id)
        {
            _userIoginRepository.Delete_UserLogin(id);
        }

        public List<Userlogin> GetAll_UserLogin()
        {
            return _userIoginRepository.GetAll_UserLogin();
        }

        public Userlogin GetUserLogin_ById(int id)
        {
            return _userIoginRepository.GetUserLogin_ById(id);
        }

        public void Update_UserLogin(Userlogin userlogin)
        {
            _userIoginRepository.Update_UserLogin(userlogin);
              
        }
    }
}
