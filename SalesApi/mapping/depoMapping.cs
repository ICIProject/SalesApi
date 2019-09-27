using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesApi.Utility;
using SalesApi.Models;
using System.Data.SqlClient;


namespace SalesApi.mapping
{
    public static class depoMapping
    {

        public static depoModel depoMappingFunction(this SqlDataReader reader, bool isList = false)
        {

            var order = new depoModel();

            try
            {

                if (!isList)
                {
                    if (!reader.HasRows)
                        return null;
                    reader.Read();
                }

                if (reader.IsColumnExists("fdID"))
                    order.fdID = SqlHelper.GetNullableBigInt(reader, "fdID");
                if (reader.IsColumnExists("fdDepo"))
                    order.fdDepo = SqlHelper.GetNullableString(reader, "fdDepo");
                if (reader.IsColumnExists("fdNamaDepo"))
                    order.fdNamaDepo = SqlHelper.GetNullableString(reader, "fdNamaDepo");
                if (reader.IsColumnExists("fdAlamat"))
                    order.fdAlamat = SqlHelper.GetNullableString(reader, "fdAlamat");
                if (reader.IsColumnExists("fdKota"))
                    order.fdKota = SqlHelper.GetNullableString(reader, "fdKota");



                //fdRevisi, fdTanggalOrder, fdTanggalKirim, fdKodeLangganan, fdAlamatKirim, 
                if (reader.IsColumnExists("fdTelepon"))
                    order.fdTelepon = SqlHelper.GetNullableString(reader, "fdTelepon");
                if (reader.IsColumnExists("fdFax"))
                    order.fdFax = SqlHelper.GetNullableString(reader, "fdFax");
                if (reader.IsColumnExists("fdDepoInduk"))
                    order.fdDepoInduk = SqlHelper.GetNullableString(reader, "fdDepoInduk");
                if (reader.IsColumnExists("fdStatusDepo"))
                    order.fdStatusDepo = SqlHelper.GetNullableString(reader, "fdStatusDepo");
                if (reader.IsColumnExists("fdMaxRecord"))
                    order.fdMaxRecord = SqlHelper.GetNullableNumeric(reader, "fdMaxRecord");
                if (reader.IsColumnExists("fdSistemPiutang"))
                    order.fdSistemPiutang = SqlHelper.GetNullableString(reader, "fdSistemPiutang");



                //fdKodeSF, fdKodeGudang, fdKodeGudangTujuan, fdMataUang, fdNoReferensi,
                if (reader.IsColumnExists("fdHariTidakAktif"))
                    order.fdHariTidakAktif = SqlHelper.GetNullableInt(reader, "fdHariTidakAktif");
                if (reader.IsColumnExists("fdHariHapus"))
                    order.fdHariHapus = SqlHelper.GetNullableInt(reader, "fdHariHapus");
                if (reader.IsColumnExists("fdLastClose"))
                    order.fdLastClose = SqlHelper.GetNullableString(reader, "fdLastClose");
                if (reader.IsColumnExists("fdCost_LastClose"))
                    order.fdCost_LastClose = SqlHelper.GetNullableString(reader, "fdCost_LastClose");
                if (reader.IsColumnExists("fdManager"))
                    order.fdManager = SqlHelper.GetNullableString(reader, "fdManager");



                if (reader.IsColumnExists("fdCa"))
                    order.fdCa = SqlHelper.GetNullableString(reader, "fdCa");
                if (reader.IsColumnExists("fdAca"))
                    order.fdAca = SqlHelper.GetNullableString(reader, "fdAca");
                if (reader.IsColumnExists("fdKasir"))
                    order.fdKasir = SqlHelper.GetNullableString(reader, "fdKasir");
                if (reader.IsColumnExists("fdAdm"))
                    order.fdAdm = SqlHelper.GetNullableString(reader, "fdAdm");
                if (reader.IsColumnExists("fdNoPKP"))
                    order.fdNoPKP = SqlHelper.GetNullableString(reader, "fdNoPKP");

                if (reader.IsColumnExists("fdTanggalPKP"))
                    order.fdTanggalPKP = SqlHelper.GetNullableDatetime(reader, "fdTanggalPKP");
                if (reader.IsColumnExists("fdNPWP"))
                    order.fdNPWP = SqlHelper.GetNullableString(reader, "fdNPWP");
                if (reader.IsColumnExists("fdKodeCabangFP"))
                    order.fdKodeCabangFP = SqlHelper.GetNullableString(reader, "fdKodeCabangFP");
                if (reader.IsColumnExists("fdAktifYN"))
                    order.fdAktifYN = SqlHelper.GetNullableString(reader, "fdAktifYN");
                if (reader.IsColumnExists("fdTglNonAktif"))
                    order.fdTglNonAktif = SqlHelper.GetNullableDatetime(reader, "fdTglNonAktif");

                if (reader.IsColumnExists("fdJmlBulanan"))
                    order.fdJmlBulanan = SqlHelper.GetNullableInt(reader, "fdJmlBulanan");
                if (reader.IsColumnExists("fdJmlHarian"))
                    order.fdJmlHarian = SqlHelper.GetNullableInt(reader, "fdJmlHarian");
                if (reader.IsColumnExists("fdToleransiLK"))
                    order.fdToleransiLK = SqlHelper.GetNullableString(reader, "fdToleransiLK");
                if (reader.IsColumnExists("fdCetakSJ"))
                    order.fdCetakSJ = SqlHelper.GetNullableString(reader, "fdCetakSJ");
                if (reader.IsColumnExists("fdStatusRecord"))
                    order.fdStatusRecord = SqlHelper.GetNullableInt(reader, "fdStatusRecord");

                if (reader.IsColumnExists("fdCreateUserID"))
                    order.fdCreateUserID = SqlHelper.GetNullableString(reader, "fdCreateUserID");
                if (reader.IsColumnExists("fdCreateTS"))
                    order.fdCreateTS = SqlHelper.GetNullableDatetime(reader, "fdCreateTS");
                if (reader.IsColumnExists("fdUpdateUserID"))
                    order.fdUpdateUserID = SqlHelper.GetNullableString(reader, "fdUpdateUserID");
                if (reader.IsColumnExists("fdUpdateTS"))
                    order.fdUpdateTS = SqlHelper.GetNullableDatetime(reader, "fdUpdateTS");
               


            }
            catch (Exception ex)
            {
                throw ex;
            }





            return order;

        }

        public static List<depoModel> depoMappingList(this SqlDataReader reader)
        {
            var list = new List<depoModel>();
            while (reader.Read())
            {
                list.Add(depoMappingFunction(reader, true));
            }
            return list;
        }

      
    }
}
