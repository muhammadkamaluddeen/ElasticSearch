using Dapper;
using ElasticSearchModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using System.Text;

namespace ElasticSearchService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        //[HttpPost]
        //[Route("RegisterUser")]
        //public ActionResult<UserCred> RegisterUser(UserDto req)
        //{
        //    Response ress = new Response();
        //    GetCredentials(req.Password, out byte[] passwordHash, out byte[] passwordSalt);

        //    UserCred user = new UserCred();
        //    user.Username = req.Username;
        //    user.PasswordHash = Encoding.UTF8.GetString(passwordHash);
        //    user.PasswordSalt = Encoding.UTF8.GetString(passwordSalt);



        //    using var connection = new SqlConnection(_config.GetConnectionString("SQLDBConn"));

        //    DynamicParameters dynamicParameters = new DynamicParameters();
        //    dynamicParameters.Add("Username", req.Username);
        //    dynamicParameters.Add("PasswordHash", passwordHash);
        //    dynamicParameters.Add("PasswordSalt", passwordSalt);


        //    var res = connection.Query<string>("InsertUserAuth", dynamicParameters, commandType: CommandType.StoredProcedure);
        //    int rr = Convert.ToInt32(res);

        //    if (rr > 0)
        //    {
        //        ress.responseCode = "00";
        //        ress.responseDescription = "User is successfully registered";
        //    }
        //    else
        //    {
        //        ress.responseCode = "01";
        //        ress.responseDescription = "User registration failed";
        //    }
        //    return Ok(user);
        //}


        //}
    }
}

