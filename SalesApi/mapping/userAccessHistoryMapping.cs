using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesApi.Utility;
using SalesApi.Models;
using System.Data.SqlClient;

namespace SalesApi.mapping
{
    public static class userAccessHistoryMapping
    {
        public static userAccessHistoryModel userAccessHistoryMappingfunction(this SqlDataReader reader, bool isList = false)
        {
            if (!isList)
            {
                if (!reader.HasRows)
                    return null;
                reader.Read();
            }

            //fdID, fdApplicationCode, fdUserID, fdModuleName, fdDateTime

            var userAccessHistory = new userAccessHistoryModel();
            if (reader.IsColumnExists("fdId"))
                userAccessHistory.fdId = SqlHelper.GetNullableInt(reader, "fdId");

            if (reader.IsColumnExists("fdApplicationCode"))
                userAccessHistory.fdApplicationCode = SqlHelper.GetNullableString(reader, "fdApplicationCode");

            if (reader.IsColumnExists("fdUserID"))
                userAccessHistory.fdUserID = SqlHelper.GetNullableString(reader, "fdUserID");

            if (reader.IsColumnExists("fdModuleName"))
                userAccessHistory.fdModuleName = SqlHelper.GetNullableString(reader, "fdModuleName");

            if (reader.IsColumnExists("fdDateTime"))
                userAccessHistory.fdDateTime = Convert.ToDateTime( SqlHelper.GetNullableString(reader, "fdDateTime")) ;

           

            return userAccessHistory;

        }

        public static List<userAccessHistoryModel> userAccessHistoryMappingList(this SqlDataReader reader)
        {
            var list = new List<userAccessHistoryModel>();
            while (reader.Read())
            {
                list.Add(userAccessHistoryMappingfunction(reader, true));
            }
            return list;
        }


    }
}
