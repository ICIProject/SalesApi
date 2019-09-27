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
    [Route("salesweb/framework")]
    public class FrameWorkController:Controller
    {
        private IConfiguration _config;

        public FrameWorkController(IConfiguration config)
        {
            _config = config;
        }


        [HttpPost]
        [Authorize]
        [Route("getApplicationName")]
        public IActionResult getApplicationName([FromBody] MainApplicationModel model)
        {
           var data = DbClientFactory<frameWorkDbRepository>.Instance.getApplicationName(model.fdApplicationCode, _config["sqlDb:DbPortal"]);

            var fdResult = new returnMessage();
            fdResult.isSuccess = true;
            fdResult.message = "";
            fdResult.data = data;


            return Ok(fdResult);
        }


        [HttpPost]
        [Authorize]
        [Route("getApplicationByUserName")]
        public IActionResult getApplicationByUserName([FromBody] userModel model )
        {

            var data = DbClientFactory<frameWorkDbRepository>.Instance.getApplicationByUserName(model.fdUserName, _config["sqlDb:DbPortal"]);
            //string jsonDataModel = Newtonsoft.Json.JsonConvert.SerializeObject(data);
            //var fdResult = new returnMessage();
            //fdResult.isSuccess = true;
            //fdResult.message = "";
            //fdResult.data = data;


            return Ok(data);
        }


        [HttpPost]
        [Authorize]
        [Route("getSettingByUserName")]
        public IActionResult getSettingByUserName([FromBody] object model)
        {

            //fdUserName;
            //fdApplicationCode;
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(model);
            var dictionary = Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
            
            string fdUserName = dictionary["fdUserName"];
            string fdApplicationCode = dictionary["fdApplicationCode"];
            
            var data = DbClientFactory<frameWorkDbRepository>.Instance.getSettingByUserName( fdUserName,fdApplicationCode , _config["sqlDb:DbPortal"]);
            
            return Ok(data);
        }

        [HttpPost]
        [Authorize]
        [Route("getModuleByUserName")]
        public IActionResult getModuleByUserName([FromBody] object model)
        {

            //fdUserName;
            //fdApplicationCode;
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(model);
            var dictionary = Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<string, string>>(json);

            string fdUserName = dictionary["fdUserName"];
            string fdApplicationCode = dictionary["fdApplicationCode"];

            var data = DbClientFactory<frameWorkDbRepository>.Instance.getModuleByUserName(fdUserName, fdApplicationCode, _config["sqlDb:DbPortal"]);

            return Ok(data);
        }
        

        [HttpPost]
        [Authorize]
        [Route("getModuleEventByUserAndModuleAndModuleEventCode")]
        public IActionResult getModuleEventByUserAndModuleAndModuleEventCode([FromBody] object model)
        {

            //fdUserName;
            //fdApplicationCode;
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(model);
            var dictionary = Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<string, string>>(json);

            string fdUserName = dictionary["fdUserName"];
            string fdApplicationCode = dictionary["fdApplicationCode"];
            string fdModuleEventCode = dictionary["fdModuleEventCode"];
            string fdModule = dictionary["fdModule"];


            var data = DbClientFactory<frameWorkDbRepository>.Instance.getModuleEventByUserAndModuleAndModuleEventCode( fdApplicationCode,fdModule, fdUserName, fdModuleEventCode , _config["sqlDb:DbPortal"]);

            return Ok(data);
        }

        [HttpPost]
        [Authorize]
        [Route("getModuleEventByUserAndModule")]
        public IActionResult getModuleEventByUserAndModule([FromBody] object model)
        {

            //fdUserName;
            //fdApplicationCode;
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(model);
            var dictionary = Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<string, string>>(json);

            string fdUserName = dictionary["fdUserName"];
            string fdApplicationCode = dictionary["fdApplicationCode"];
            string fdModule = dictionary["fdModule"];


            var data = DbClientFactory<frameWorkDbRepository>.Instance.getModuleEventByUserAndModule(fdApplicationCode, fdModule, fdUserName, _config["sqlDb:DbPortal"]);

            return Ok(data);
        }

        [HttpPost]
        [Authorize]
        [Route("getModuleEventByUserNameAndPage")]
        public IActionResult getModuleEventByUserNameAndPage([FromBody] object model)
        {

            //fdUserName;
            //fdApplicationCode;
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(model);
            var dictionary = Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<string, string>>(json);

            string fdUserName = dictionary["fdUserName"];
            string fdApplicationCode = dictionary["fdApplicationCode"];
            string fdModule = dictionary["fdModule"];


            var data = DbClientFactory<frameWorkDbRepository>.Instance.getModuleEventByUserNameAndPage(fdApplicationCode, fdModule, fdUserName, _config["sqlDb:DbPortal"]);

            return Ok(data);
        }



    }
}
