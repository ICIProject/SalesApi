using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesApi.Utility;
using System.Data;
using SalesApi.Models;
using SalesApi.mapping;
using Newtonsoft.Json.Linq;
using System.Data.SqlClient;

namespace SalesApi.Repository
{
    public class frameWorkDbRepository
    {

        /*
        public List<MainApplicationModel> getApplicationName(string JSONObject, string connString)
        {
            SqlParameter[] param = { new SqlParameter("@jsonParamIn", JSONObject) };

            return SqlHelper.ExtecuteProcedureReturnData<List<MainApplicationModel>>(connString, "sp_GetDatabyUserName", r => r.userMappingList(), param);
        }*/

        public string getApplicationName(string fdApplicationCode, string connString)
        {

            string applicationName = "";

            List<MainApplicationModel> data = new List<MainApplicationModel>();


            string sql = "select  TOP 1 * from FmsSaMainApplication where fdApplicationCode ='" + fdApplicationCode + "' ";

            data = SqlHelper.ExecuteQueryReturnData<List<MainApplicationModel>>(connString, sql, r => r.MainApplicationMappingList());

            if (data.Count > 0)
            {
                applicationName = data[0].fdApplication;
            }

            return applicationName;

            
        }


        public List<MainApplicationModel> getApplicationByUserName(string fdUserName, string connString)
        {
            SqlParameter[] param = { new SqlParameter("@fdUserName", fdUserName) };

            return SqlHelper.ExtecuteProcedureReturnData<List<MainApplicationModel>>(connString, "SPGetProgramByUserName", r => r.MainApplicationMappingList(), param);
        }

        public List<moduleModel> getSettingByUserName(string fdUserName, string fdApplicationCode, string connString)
        {
            SqlParameter[] param = { new SqlParameter("@fdUserName", fdUserName),
                                     new SqlParameter("@fdApplicationCode",fdApplicationCode)};
            return SqlHelper.ExtecuteProcedureReturnData<List<moduleModel>>(connString, "SPGetSettingByUserName", r => r.ModulMappingList(), param);
        }


        public List<moduleModel> getModuleByUserName(string fdUserName, string fdApplicationCode, string connString)
        {
            SqlParameter[] param = { new SqlParameter("@fdUserName", fdUserName),
                                     new SqlParameter("@fdApplicationCode",fdApplicationCode)};
            return SqlHelper.ExtecuteProcedureReturnData<List<moduleModel>>(connString, "SPGetModuleByUserName", r => r.ModulMappingList(), param);
        }

        


        public List<moduleModel> getModuleEventByUserAndModuleAndModuleEventCode( string fdApplicationCode , string fdModule, string fdUserName, string fdModuleEventCode, string connString)
        {
            SqlParameter[] param = { new SqlParameter("@fdUserName", fdUserName),
                                     new SqlParameter("@fdApplicationCode",fdApplicationCode),
                                     new SqlParameter("@fdModule",fdModule),
                                     new SqlParameter("@fdModuleEventCode",fdModuleEventCode)};
            return SqlHelper.ExtecuteProcedureReturnData<List<moduleModel>>(connString, "spGetModuleEventByUserAndModuleAndModuleEventCode", r => r.ModulMappingList(), param);
        }

        
        public List<moduleModel> getModuleEventByUserAndModule(string fdApplicationCode, string fdModule, string fdUserName, string connString)
        {
            SqlParameter[] param = { new SqlParameter("@fdUserName", fdUserName),
                                     new SqlParameter("@fdApplicationCode",fdApplicationCode),
                                     new SqlParameter("@fdModule",fdModule) };
            return SqlHelper.ExtecuteProcedureReturnData<List<moduleModel>>(connString, "spGetModuleEventByUserAndModule", r => r.ModulMappingList(), param);
        }

        public List<moduleModel> getModuleEventByUserNameAndPage(string fdApplicationCode, string fdModule, string fdUserName, string connString)
        {
            SqlParameter[] param = { new SqlParameter("@fdUserName", fdUserName),
                                     new SqlParameter("@fdApplicationCode",fdApplicationCode),
                                     new SqlParameter("@fdModule",fdModule) };
            return SqlHelper.ExtecuteProcedureReturnData<List<moduleModel>>(connString, "SPGetModuleByUserNameAndPage", r => r.ModulMappingList(), param);
        }


        

    }
}
