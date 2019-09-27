using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesApi.Models;
using SalesApi.Utility;
using SalesApi.Repository;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.Extensions.Configuration;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Microsoft.IdentityModel.Protocols;
using Microsoft.AspNetCore.Authorization;
using System.Net.Http;
using Newtonsoft.Json.Linq;
namespace SalesApi.Controllers
{
    [Produces("application/json")]
    [Route("salesweb/UserAccessHistory")]
    public class userAccessHistoryController : Controller
    {

        private IConfiguration _config;

        public userAccessHistoryController(IConfiguration config)
        {
            _config = config;
        }



        [HttpPost]
        [Authorize]
        [Route("prosesAll")]
        public IActionResult prosesAll([FromBody] object jsonContent)
        {
            //string jsonDataModel = jsonData;

            string jsonDataModel = Newtonsoft.Json.JsonConvert.SerializeObject(jsonContent);
            var data = DbClientFactory<userAccessHistoryDbRepository>.Instance.prosesAll(jsonDataModel, _config["sqlDb:DbPortal"]);
            List<returnMessage> result = Newtonsoft.Json.JsonConvert.DeserializeObject<List<returnMessage>>(data);

            return Ok(result);

        }

    }
}
