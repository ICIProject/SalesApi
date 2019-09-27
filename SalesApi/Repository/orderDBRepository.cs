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
    public class orderDBRepository
    {


        public List<orderModel> getAllDataOrder( string connString)
        {

    
            List<orderModel> data = new List<orderModel>();

                string sql = " select top 20 O.*, L.fdNamaOutlet , SF.fdNama , S.fdNamaStatus " +
                            " from FTrSaOrder O " +
                            " INNER JOIN FMsSaLangganan L on L.fdKodeLangganan = O.fdKodeLangganan and L.fdDepo = O.fdDepo " +
                            " INNER JOIN FMsSaSalesForce SF on SF.fdKodeSF = O.fdKodeSF and SF.fdKodeSF = O.fdKodeSF " +
                            " INNER JOIN vwStatus S on S.fdkodeStatus = O.fdStatus " +
                            " order by O.fdID desc ";

            return SqlHelper.ExecuteQueryReturnData<List<orderModel>>(connString, sql, r => r.orderMappingList());

    

        }

        public DataTable getAllDataOrderWithPaging( string fdUserLogin, string pageIndex, string pagingSize, string filtering, string connString)
        {

            DataTable dt = new DataTable();
            SqlParameter[] param = { 
                                     new SqlParameter("@fdUserLogin", fdUserLogin),
                                     new SqlParameter("@pageIndex", pageIndex),
                                     new SqlParameter("@pageSize",pagingSize),
                                     new SqlParameter("@filtering",filtering)};
             SqlHelper.ExecuteProcedureReturnDataSet (connString, "SPgetAllDataOrderWithPaging", ref dt ,param);
            return dt;

        }

        public DataTable getDataTransaksiSOByNoEntryOrder(string fdNoEntryOrder, string fdDepo,  string connString)
        {

            DataTable dt = new DataTable();
            SqlParameter[] param = { new SqlParameter("@fdNoEntryOrder", fdNoEntryOrder),
                                     new SqlParameter("@fdDepo",fdDepo) };
            SqlHelper.ExecuteProcedureReturnDataSet(connString, "SPgetDataTransaksiSOByNoEntryOrder", ref dt, param);
            return dt;

        }



        public DataTable GetDataNotifYTDSO( string connString)
        {
            DataTable dt = new DataTable();
            SqlHelper.ExecuteProcedureReturnDataSet (connString, "SPGetDataNotifYTDSO", ref dt);
            return dt;

        }

    }
}
