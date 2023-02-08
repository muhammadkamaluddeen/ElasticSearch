using Dapper;
using ElasticSearchCore.Interfaces;
using ElasticSearchModel;
using ElasticSearchModel.AccountModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;

namespace ElasticSearchService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase

    {
        private static IAccount _account;

        public AccountController(IAccount account)
        {
            _account = account;
        }

        [HttpPost]
        [Route("CreateAccount")]
        public AccountResponse CreateAccount(AccountRequest req)

        {
            AccountResponse res = new AccountResponse();
            _account.CreateAccount(req);
            return res; 
        }
    }
    
    
}
