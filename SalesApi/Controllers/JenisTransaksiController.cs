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
    [Route("salesweb/JenisTransaksi")]
    public class JenisTransaksiController : Controller
    {
        private IConfiguration _config;

        public JenisTransaksiController(IConfiguration config)
        {
            _config = config;
        }


        //getDataJenisTransaksi
        [HttpPost]
        [Authorize]
        [Route("getComboDataJenisTransaksiByUserLogin")]
        public IActionResult getComboDataJenisTransaksiByUserLogin([FromBody] object model)
        {

            //fdUserName;
            //fdApplicationCode;
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(model);
            var dictionary = Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<string, string>>(json);

            string fdUserLogin = dictionary["fdUserLogin"];
            string fdSearchTerm = dictionary["fdSearchTerm"];
            int fdPage = int.Parse(dictionary["fdPage"]);


            var data = DbClientFactory<jenisTransaksiDbRepository>.Instance.getComboDataJenisTransaksiByUserLogin(fdUserLogin, fdSearchTerm, fdPage, _config["sqlDb:DbSalesWeb"]);
            return Ok(data);
        }
    }
}
