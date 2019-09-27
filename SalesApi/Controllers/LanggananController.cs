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
    [Route("salesweb/Langganan")]

    public class LanggananController : Controller
    {


        private IConfiguration _config;

        public LanggananController(IConfiguration config)
        {
            _config = config;
        }


        //getDataTransaksiSOByNoEntryOrder
        [HttpPost]
        [Authorize]
        [Route("getComboDataLanggananByUserLogin")]
        public IActionResult getComboDataLanggananByUserLogin([FromBody] object model)
        {

            //fdUserName;
            //fdApplicationCode;
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(model);
            var dictionary = Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<string, string>>(json);

            string fdUserLogin = dictionary["fdUserLogin"];
            string fdSearchTerm = dictionary["fdSearchTerm"];
            int fdPage = int.Parse(dictionary["fdPage"]);


            var data = DbClientFactory<LanggananDBRepository>.Instance.getComboDataLanggananByUserLogin(fdUserLogin, fdSearchTerm, fdPage, _config["sqlDb:DbSalesWeb"]);
            return Ok(data);
        }


    }
}
