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
    [Route("salesweb/Order")]
    public class OrderController:Controller
    {

        private IConfiguration _config;

        public OrderController(IConfiguration config)
        {
            _config = config;
        }


        [HttpPost]
        [Authorize]
        [Route("GetAllDataOrder")]
        public IActionResult GetAllDataOrder()
        {
            var data = DbClientFactory<orderDBRepository>.Instance.getAllDataOrder(_config["sqlDb:DbSalesWeb"]);
            return Ok(data);
        }

        [HttpPost]
        [Authorize]
        [Route("getAllDataOrderWithPaging")]
        public IActionResult GetAllDataOrderWithPaging([FromBody] object model)
        {

            //fdUserName;
            //fdApplicationCode;
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(model);
            var dictionary = Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<string, string>>(json);

            string fdUserLogin = dictionary["fdUserLogin"];
            string pageIndex = dictionary["pageIndex"];
            string pagingSize = dictionary["pageSize"];
            string filtering = dictionary["filtering"];

            var data = DbClientFactory<orderDBRepository>.Instance.getAllDataOrderWithPaging(fdUserLogin, pageIndex,pagingSize, filtering, _config["sqlDb:DbSalesWeb"]);
            return Ok(data);
        }


        //getDataTransaksiSOByNoEntryOrder
        [HttpPost]
        [Authorize]
        [Route("getDataTransaksiSOByNoEntryOrder")]
        public IActionResult getDataTransaksiSOByNoEntryOrder([FromBody] object model)
        {

            //fdUserName;
            //fdApplicationCode;
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(model);
            var dictionary = Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<string, string>>(json);

            string fdNoEntryOrder = dictionary["fdNoEntryOrder"];
            string fdDepo = dictionary["fdDepo"];

            var data = DbClientFactory<orderDBRepository>.Instance.getDataTransaksiSOByNoEntryOrder(fdNoEntryOrder , fdDepo, _config["sqlDb:DbSalesWeb"]);
            return Ok(data);
        }

        

        [HttpPost]
        [Authorize]
        [Route("GetDataNotifYTDSO")]
        public IActionResult GetDataNotifYTDSO()
        {
            var data = DbClientFactory<orderDBRepository>.Instance.GetDataNotifYTDSO(_config["sqlDb:DbSalesWeb"]);           
            return Ok(data);
        }





    }
}
