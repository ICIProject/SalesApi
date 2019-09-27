using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesApi.Utility;
using SalesApi.Models;
using System.Data.SqlClient;


namespace SalesApi.mapping
{
    public static class userMapping
    {
        public static userModel userMappingfunction(this SqlDataReader reader, bool isList = false)
        {
            if (!isList)
            {
                if (!reader.HasRows)
                    return null;
                reader.Read();
            }

            var user = new userModel();
            if (reader.IsColumnExists("fdId"))
                user.fdId = SqlHelper.GetNullableInt(reader, "fdId");

            if (reader.IsColumnExists("fdUserName"))
                user.fdUserName = SqlHelper.GetNullableString(reader, "fdUserName");

            if (reader.IsColumnExists("fdPassword"))
                user.fdPassword = SqlHelper.GetNullableString(reader, "fdPassword");

            if (reader.IsColumnExists("fdEmail"))
                user.fdEmail = SqlHelper.GetNullableString(reader, "fdEmail");

            if (reader.IsColumnExists("fdName"))
                user.fdName = SqlHelper.GetNullableString(reader, "fdName");

            if (reader.IsColumnExists("fdNIP"))
                user.fdNIP = SqlHelper.GetNullableString(reader, "fdNIP");
            
            return user;

        }

        public static List<userModel> userMappingList(this SqlDataReader reader)
        {
            var list = new List<userModel>();
            while (reader.Read())
            {
                list.Add(userMappingfunction(reader, true));
            }
            return list;
        }



    }
}
