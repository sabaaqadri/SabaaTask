using Dapper;
using SabaaTask.CORE.Common;
using SabaaTask.CORE.Data;
using SabaaTask.CORE.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace SabaaTask.INFRA.Repository
{
    public class UserIoginRepository : IUserIoginRepository
    {
        private readonly IDbContext _dbContext;

        public UserIoginRepository(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public void Create_UserLogin(Userlogin userlogin)
        {
            var p = new DynamicParameters();
            p.Add("FirstName", userlogin.Firstname, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("LastName", userlogin.Lastname, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Email", userlogin.Email, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Password", userlogin.Password, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("ConfirmPassword", userlogin.Confirmpassword, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Roleid", userlogin.Roleid, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = _dbContext.Connection.Execute("UserLogin_Package.Create_UserLogin", p, commandType: CommandType.StoredProcedure);


        }



        public void Delete_UserLogin(int id)
        {
            var p = new DynamicParameters();
            p.Add("id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            _dbContext.Connection.Execute("UserLogin_Package.Delete_UserLogin", p, commandType: CommandType.StoredProcedure);
        }




        public List<Userlogin> GetAll_UserLogin()
        {
            IEnumerable<Userlogin> result = _dbContext.Connection.Query<Userlogin>("UserLogin_Package.GetAll_UserLogin", commandType: System.Data.CommandType.StoredProcedure);
            return result.ToList();
        }

        public Userlogin GetUserLogin_ById(int id)
        {
            var p = new DynamicParameters();
            p.Add("id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<Userlogin> result = _dbContext.Connection.Query<Userlogin>("UserLogin_Package.GetUserLogin_ById", p, commandType: CommandType.StoredProcedure);

            return result.FirstOrDefault();
        }

        public void Update_UserLogin(Userlogin userlogin)
        {

            var p = new DynamicParameters();
            p.Add("ID", userlogin.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("FirstName", userlogin.Firstname, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("LastName", userlogin.Lastname, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Email", userlogin.Email, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Password", userlogin.Password, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("ConfirmPassword", userlogin.Confirmpassword, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Roleid", userlogin.Roleid, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = _dbContext.Connection.Execute("UserLogin_Package.Update_UserLogin", p, commandType: CommandType.StoredProcedure);

        }
    }
}
