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
    public class UserDbRepository
    {


        public List<userModel> GetAllUsers(string connString)
        {
            return SqlHelper.ExtecuteProcedureReturnData<List<userModel>>(connString,
                "spGetFmsSaUsers", r => r.userMappingList());
        }

        public List<userModel> getDatabyUserName(string JSONObject,  string connString)
        {
            SqlParameter[] param = { new SqlParameter("@jsonParamIn",JSONObject) };

            return SqlHelper.ExtecuteProcedureReturnData<List<userModel>>(connString, "sp_GetDatabyUserName", r => r.userMappingList() ,param );
        }


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

            SqlHelper.ExecuteProcedureReturnString(connString, "sp_FmsSaUsers", param);
            return (string)outParamReturnCode.Value;


        }

        public string checkLogin(string JSONObject, string connString )
        {
       
            var outParamReturnCode = new SqlParameter("@jsonParamOut", SqlDbType.NVarChar,-1)
            {
                Direction = ParameterDirection.Output
            };

            int fdActionValue = 1;

            SqlParameter[] param = {
                new SqlParameter("@jsonParamIn",JSONObject),
                new SqlParameter("@fdAction",fdActionValue),
                outParamReturnCode
            };

            SqlHelper.ExecuteProcedureReturnString(connString, "sp_CheckLogin", param);
            return (string)outParamReturnCode.Value;
     

        }



    }
}
