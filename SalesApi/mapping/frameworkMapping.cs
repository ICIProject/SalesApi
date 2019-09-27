using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesApi.Utility;
using SalesApi.Models;
using System.Data.SqlClient;


namespace SalesApi.mapping
{
    public static class frameworkMapping
    {
        //MAIN APPLICATION
        public static MainApplicationModel MainApplicationMappingfunction(this SqlDataReader reader, bool isList = false)
        {
            if (!isList)
            {
                if (!reader.HasRows)
                    return null;
                reader.Read();
            }

            var mainApplication = new MainApplicationModel();
            if (reader.IsColumnExists("fdApplicationCode"))
                mainApplication.fdApplicationCode = SqlHelper.GetNullableString(reader, "fdApplicationCode");

            if (reader.IsColumnExists("fdApplication"))
                mainApplication.fdApplication = SqlHelper.GetNullableString(reader, "fdApplication");

            if (reader.IsColumnExists("fdIcon"))
                mainApplication.fdIcon = SqlHelper.GetNullableString(reader, "fdIcon");

            if (reader.IsColumnExists("fdUrl"))
                mainApplication.fdUrl = SqlHelper.GetNullableString(reader, "fdUrl");

            //Column Tambahan
            if (reader.IsColumnExists("totalProgram"))
                mainApplication.totalProgram = SqlHelper.GetNullableInt(reader, "totalProgram");




            return mainApplication;

        }

        public static List<MainApplicationModel> MainApplicationMappingList(this SqlDataReader reader)
        {
            var list = new List<MainApplicationModel>();
            while (reader.Read())
            {
                list.Add(MainApplicationMappingfunction(reader, true));
            }
            return list;
        }


        //MODULE

        public static moduleModel ModulMappingfunction(this SqlDataReader reader, bool isList = false)
        {
            if (!isList)
            {
                if (!reader.HasRows)
                    return null;
                reader.Read();
            }
            //fdId, fdApplicationCode, fdModule, fdModuleName, fdModuleEventCode, fdParent, fdSort, fdLink, fdIconCls, fdType, fdNote

            var module = new moduleModel();
            if (reader.IsColumnExists("fdId"))
                module.fdId = SqlHelper.GetNullableInt(reader, "fdId");

            if (reader.IsColumnExists("fdApplicationCode"))
                module.fdApplicationCode = SqlHelper.GetNullableString(reader, "fdApplicationCode");

            if (reader.IsColumnExists("fdModule"))
                module.fdModule = SqlHelper.GetNullableString(reader, "fdModule");

            if (reader.IsColumnExists("fdModuleName"))
                module.fdModuleName = SqlHelper.GetNullableString(reader, "fdModuleName");

            if (reader.IsColumnExists("fdModuleEventCode"))
                module.fdModuleEventCode = SqlHelper.GetNullableString(reader, "fdModuleEventCode");

            if (reader.IsColumnExists("fdParent"))
                module.fdParent = SqlHelper.GetNullableString(reader, "fdParent");

            if (reader.IsColumnExists("fdSort"))
                module.fdSort = SqlHelper.GetNullableInt(reader, "fdSort");

            if (reader.IsColumnExists("fdLink"))
                module.fdLink = SqlHelper.GetNullableString(reader, "fdLink");

            if (reader.IsColumnExists("fdIconCls"))
                module.fdIconCls = SqlHelper.GetNullableString(reader, "fdIconCls");

            if (reader.IsColumnExists("fdType"))
                module.fdType = SqlHelper.GetNullableString(reader, "fdType");

            if (reader.IsColumnExists("fdNote"))
                module.fdNote = SqlHelper.GetNullableString(reader, "fdNote");

            if (reader.IsColumnExists("fdLevel"))
                module.fdLevel = SqlHelper.GetNullableString(reader, "fdLevel");

            if (reader.IsColumnExists("fdModuleEvent"))
                module.fdModuleEvent = SqlHelper.GetNullableString(reader, "fdModuleEvent");

            if (reader.IsColumnExists("fdIconName"))
                module.fdIconName = SqlHelper.GetNullableString(reader, "fdIconName");



            return module;

        }

        public static List<moduleModel> ModulMappingList(this SqlDataReader reader)
        {
            var list = new List<moduleModel>();
            while (reader.Read())
            {
                list.Add(ModulMappingfunction(reader, true));
            }
            return list;
        }


    }
}
