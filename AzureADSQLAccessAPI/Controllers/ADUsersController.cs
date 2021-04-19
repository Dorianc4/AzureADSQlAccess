using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

using Azure.Core;
using Azure.Identity;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Services.AppAuthentication;
using Microsoft.Extensions.Logging;

namespace AzureADSQLAccessAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ADUsersController : ControllerBase
    {       

        [HttpGet]
        public async Task<List<string>> Get()
        {          

            var connectionStringBuilder = new SqlConnectionStringBuilder
            {
                DataSource = "tcp:gwhhserver2.database.windows.net,1433",
                InitialCatalog = "gwhhdb",
                TrustServerCertificate = false,
                Encrypt = true
            };

            await using var sqlConnection = new SqlConnection(connectionStringBuilder.ConnectionString)
            {
                AccessToken = await GetAzureSqlAccessToken()
            };



            return new List<string>()
            {
                "Hello",
                "World"
            };
        }

        private static async Task<string> GetAzureSqlAccessToken()
        {
            
            var tokenRequestContext = new TokenRequestContext(new[] { "https://database.windows.net//.default" });
            var tokenRequestResult = await new DefaultAzureCredential().GetTokenAsync(tokenRequestContext);

            return tokenRequestResult.Token;
        }
    }
}
