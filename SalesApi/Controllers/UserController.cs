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
    [Route("salesweb/User")]
    public class UserController:Controller
    {
        //private readonly IOptions<dbSettingsModel> appSettings;


        //public UserController(IOptions<dbSettingsModel> app)
        //{
        //    appSettings = app;
        //}

        private IConfiguration _config;

        public UserController(IConfiguration config)
        {
            _config = config;
        }


        [HttpGet]
        [Authorize]
        [Route("GetAllUsers")]
        public IActionResult GetAllUsers()
        {
            var data = DbClientFactory<UserDbRepository>.Instance.GetAllUsers(_config["sqlDb:DbConn"]);
            return Ok(data);
        }

        [HttpPost]
        [Authorize]
        [Route("getDatabyUserName")]
        public IActionResult getDatabyUserName([FromBody] userModel model)
        {
            string jsonUserModel = Newtonsoft.Json.JsonConvert.SerializeObject(model);
            //string jsonUserModel = "";

            var data = DbClientFactory<UserDbRepository>.Instance.getDatabyUserName(jsonUserModel, _config["sqlDb:DbConn"]);
            return Ok(data);
        }

 

        [HttpPost]
        [Authorize]
        [Route("prosesAll")]
        public IActionResult prosesAll ([FromBody] object jsonContent)
        {
            //string jsonDataModel = jsonData;

            string jsonDataModel = Newtonsoft.Json.JsonConvert.SerializeObject(jsonContent);
            var data = DbClientFactory<UserDbRepository>.Instance.prosesAll(jsonDataModel, _config["sqlDb:DbConn"]);
            List<returnMessage> result = Newtonsoft.Json.JsonConvert.DeserializeObject<List<returnMessage>>(data);

            return Ok(result);
            
        }


        [HttpPost]
        [Route("checkLogin")]
        public IActionResult checkLogin([FromBody]userModel model)
        {

            string jsonUserModel = Newtonsoft.Json.JsonConvert.SerializeObject(model);
            var fdResult = new returnMessage();           
            var data = DbClientFactory<UserDbRepository>.Instance.checkLogin(jsonUserModel, _config["sqlDb:DbConn"]);
            fdResult = Newtonsoft.Json.JsonConvert.DeserializeObject<returnMessage>(data.Substring(1, data.Length - 2));
            if (fdResult.message == "" && fdResult.data != "" ) 
            {
                fdResult.isSuccess = true;
                fdResult.data = GenerateJSONWebToken(model);
            }
            else
            {
                fdResult.isSuccess = false;
            }

            return Ok(fdResult);
        }

        [HttpGet]
        [Route("admin")]
        public IActionResult admin()
        {

            userModel adminModel = new userModel();
            adminModel.fdUserName = "Admin";
            adminModel.fdPassword = "Admin";

            var fdResult = new returnMessage();
            fdResult.isSuccess = true;
            fdResult.message = "";
            fdResult.data = GenerateJSONWebToken(adminModel);

            return Ok(fdResult);
        }

        //FUNCTION GENERATE TOKEN
        private string GenerateJSONWebToken(userModel userInfo)
        {

            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new[] {
                new Claim(JwtRegisteredClaimNames.NameId, userInfo.fdUserName),
                new Claim(JwtRegisteredClaimNames.Sid, userInfo.fdPassword),
                //new Claim("DateOfJoing", userInfo.DateOfJoing.ToString("yyyy-MM-dd")),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

            var token = new JwtSecurityToken(_config["Jwt:Issuer"],
                _config["Jwt:Issuer"],
                claims,
                expires: DateTime.Now.AddMinutes(180),
                signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }



    }

  
}
