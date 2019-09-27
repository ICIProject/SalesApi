﻿using System;
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
    public class SalesmanDbRepository
    {
        public DataTable getComboDataSalesmanByUserLogin(string fdUserLogin, string fdSearchTerm, int fdPage, string connString)
        {

            DataTable dt = new DataTable();
            SqlParameter[] param = {
                                        new SqlParameter("@fdUserLogin", fdUserLogin) ,
                                        new SqlParameter("@fdSearchTerm", fdSearchTerm),
                                        new SqlParameter("@fdPage", fdPage)
                                    };
            SqlHelper.ExecuteProcedureReturnDataSet(connString, "SPgetComboDataSalesmanByUserLogin", ref dt, param);
            return dt;

        }


    }
}
