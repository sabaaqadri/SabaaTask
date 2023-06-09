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


    public class JWTRepository : IJWTRepository
    {
        private readonly IDbContext _dbContext;

        public JWTRepository(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Userlogin Auth(Userlogin userlogin)
        {
            var p = new DynamicParameters();
            p.Add("Email", userlogin.Email, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Password", userlogin.Password, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = _dbContext.Connection.Query<Userlogin>("Login_Package.User_Login", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();


        }
    }
}
