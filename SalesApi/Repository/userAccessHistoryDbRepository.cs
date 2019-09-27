using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using SalesApi.Utility;
using System.Data;
using SalesApi.Models;
using SalesApi.mapping;
using Newtonsoft.Json.Linq;

namespace SalesApi.Repository
{
    public class userAccessHistoryDbRepository
    {


        public string prosesAll(string JSONObject, string connString)
        {


            var outParamReturnCode = new SqlParameter("@jsonParamOut", SqlDbType.NVarChar, -1)
            {
                Direction = ParameterDirection.Output
            };

            string fdActionValue;
            JObject obj = JObject.Parse(JSONObject);

            fdActionValue = (string)obj["fdAction"];

            //fdActionValue = Newtonsoft.Json.

            SqlParameter[] param = {
                new SqlParameter("@jsonParamIn",JSONObject),
                new SqlParameter("@fdAction",fdActionValue),
                outParamReturnCode
            };

            SqlHelper.ExecuteProcedureReturnString(connString, "spFtrSaUserAccessHistory", param);
            return (string)outParamReturnCode.Value;


        }

    }
}
