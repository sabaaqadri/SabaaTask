using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SabaaTask.CORE.Data;
using SabaaTask.CORE.Service;
using System.Collections.Generic;

namespace SabaaTask.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserloginController : ControllerBase
    {


        private readonly IUserloginService _userloginService;
        public UserloginController(IUserloginService userloginService)
        {
            _userloginService = userloginService;
        }




        [HttpPost]
        public void Create_UserLogin(Userlogin userlogin)
        {
            _userloginService.Create_UserLogin(userlogin);
        }



        [HttpDelete]
        [Route("Delete/{id}")]
        public void Delete_UserLogin(int id)
        {
            _userloginService.Delete_UserLogin(id);
        }



        [HttpGet]
        public List<Userlogin> GetAll_UserLogin()
        {
            return _userloginService.GetAll_UserLogin();
        }



        [HttpGet]
        [Route("GetUserLogin_ById/{id}")]
        public Userlogin GetUserLogin_ById(int id)
        {
            return _userloginService.GetUserLogin_ById(id);
        }



        [HttpPut]
        public void Update_UserLogin(Userlogin userlogin)
        {
            _userloginService.Update_UserLogin(userlogin);

        }
    }
}
