using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesApi.Utility;
using SalesApi.Models;
using System.Data.SqlClient;


namespace SalesApi.mapping
{
    public static class orderMapping
    {

        public static orderModel orderMappingFunction(this SqlDataReader reader, bool isList = false)
        {

            var order = new orderModel();

            try
            {

                if (!isList)
                {
                    if (!reader.HasRows)
                        return null;
                    reader.Read();
                }

                //fdID, fdNoEntryOrder, fdDepo, fdJenisOrder, fdNoOrder, 
                //fdRevisi, fdTanggalOrder, fdTanggalKirim, fdKodeLangganan, fdAlamatKirim, 
                //fdKodeSF, fdKodeGudang, fdKodeGudangTujuan, fdMataUang, fdNoReferensi, 
                //fdTglReferensi, fdRemarkPO, fdOrderTambahan, fdTransport, fdTerm_Days, 
                //fdTerm, fdDestinationPortID, fdShippingMark, fdIsFixed, fdStatus, 
                //fdReasonNotApprove, fdDisetujuiOleh, fdTglDisetujui, fdKodeEkspedisi, fdNoOrderSFA, 
                //fdTglSFA, fdStatusRecord, fdCreateUserID, fdCreateTS, fdUpdateUserID, 
                //fdUpdateTS, fdNoEntryLama


                if (reader.IsColumnExists("fdID"))
                    order.fdID = SqlHelper.GetNullableBigInt(reader, "fdID");
                if (reader.IsColumnExists("fdNoEntryOrder"))
                    order.fdNoEntryOrder = SqlHelper.GetNullableBigInt(reader, "fdNoEntryOrder");
                if (reader.IsColumnExists("fdDepo"))
                    order.fdDepo = SqlHelper.GetNullableString(reader, "fdDepo");
                if (reader.IsColumnExists("fdJenisOrder"))
                    order.fdJenisOrder = SqlHelper.GetNullableString(reader, "fdJenisOrder");
                if (reader.IsColumnExists("fdNoOrder"))
                    order.fdNoOrder = SqlHelper.GetNullableString(reader, "fdNoOrder");

                //fdRevisi, fdTanggalOrder, fdTanggalKirim, fdKodeLangganan, fdAlamatKirim, 
                if (reader.IsColumnExists("fdRevisi"))
                    order.fdRevisi = SqlHelper.GetNullableInt(reader, "fdRevisi");
                if (reader.IsColumnExists("fdTanggalOrder"))
                    order.fdTanggalOrder = SqlHelper.GetNullableDatetime(reader, "fdTanggalOrder");
                if (reader.IsColumnExists("fdTanggalKirim"))
                    order.fdTanggalKirim = SqlHelper.GetNullableDatetime(reader, "fdTanggalKirim");
                if (reader.IsColumnExists("fdKodeLangganan"))
                    order.fdKodeLangganan = SqlHelper.GetNullableBigInt(reader, "fdKodeLangganan");
                if (reader.IsColumnExists("fdNamaOutlet"))
                    order.fdNamaLangganan = SqlHelper.GetNullableString(reader, "fdNamaOutlet");
                if (reader.IsColumnExists("fdAlamatKirim"))
                    order.fdAlamatKirim = SqlHelper.GetNullableString(reader, "fdAlamatKirim");

                //fdKodeSF, fdKodeGudang, fdKodeGudangTujuan, fdMataUang, fdNoReferensi,
                if (reader.IsColumnExists("fdKodeSF"))
                    order.fdKodeSF = SqlHelper.GetNullableBigInt(reader, "fdKodeSF");
                if (reader.IsColumnExists("fdNama"))
                    order.fdNamaSF = SqlHelper.GetNullableString(reader, "fdNama");
                if (reader.IsColumnExists("fdKodeGudang"))
                    order.fdKodeGudang = SqlHelper.GetNullableString(reader, "fdKodeGudang");
                if (reader.IsColumnExists("fdKodeGudangTujuan"))
                    order.fdKodeGudangTujuan = SqlHelper.GetNullableString(reader, "fdKodeGudangTujuan");
                if (reader.IsColumnExists("fdMataUang"))
                    order.fdMataUang = SqlHelper.GetNullableString(reader, "fdMataUang");
                if (reader.IsColumnExists("fdNoReferensi"))
                    order.fdNoReferensi = SqlHelper.GetNullableString(reader, "fdNoReferensi");

                //fdTglReferensi, fdRemarkPO, fdOrderTambahan, fdTransport, fdTerm_Days, 
                if (reader.IsColumnExists("fdTglReferensi"))
                    order.fdTglReferensi = SqlHelper.GetNullableDatetime(reader, "fdTglReferensi");
                if (reader.IsColumnExists("fdRemarkPO"))
                    order.fdRemarkPO = SqlHelper.GetNullableString(reader, "fdRemarkPO");
                if (reader.IsColumnExists("fdOrderTambahan"))
                    order.fdOrderTambahan = SqlHelper.GetNullableInt(reader, "fdOrderTambahan");
                if (reader.IsColumnExists("fdTransport"))
                    order.fdTransport = SqlHelper.GetNullableString(reader, "fdTransport");
                if (reader.IsColumnExists("fdTerm_Days"))
                    order.fdTerm_Days = SqlHelper.GetNullableInt(reader, "fdTerm_Days");

                //fdTerm, fdDestinationPortID, fdShippingMark, fdIsFixed, fdStatus, 
                if (reader.IsColumnExists("fdTerm"))
                    order.fdTerm = SqlHelper.GetNullableString(reader, "fdTerm");
                if (reader.IsColumnExists("fdDestinationPortID"))
                    order.fdDestinationPortID = SqlHelper.GetNullableString(reader, "fdDestinationPortID");
                if (reader.IsColumnExists("fdShippingMark"))
                    order.fdShippingMark = SqlHelper.GetNullableString(reader, "fdShippingMark");
                if (reader.IsColumnExists("fdIsFixed"))
                    order.fdIsFixed = SqlHelper.GetNullableString(reader, "fdIsFixed");
                if (reader.IsColumnExists("fdStatus"))
                    order.fdStatus = SqlHelper.GetNullableInt(reader, "fdStatus");
                if (reader.IsColumnExists("fdNamaStatus"))
                    order.fdNamaStatus = SqlHelper.GetNullableString(reader, "fdNamaStatus");


                //fdReasonNotApprove, fdDisetujuiOleh, fdTglDisetujui, fdKodeEkspedisi, fdNoOrderSFA, 
                if (reader.IsColumnExists("fdReasonNotApprove"))
                    order.fdReasonNotApprove = SqlHelper.GetNullableInt(reader, "fdReasonNotApprove");
                if (reader.IsColumnExists("fdDisetujuiOleh"))
                    order.fdDisetujuiOleh = SqlHelper.GetNullableString(reader, "fdDisetujuiOleh");
                if (reader.IsColumnExists("fdTglDisetujui"))
                    order.fdTglDisetujui = SqlHelper.GetNullableDatetime(reader, "fdTglDisetujui");
                if (reader.IsColumnExists("fdKodeEkspedisi"))
                    order.fdKodeEkspedisi = SqlHelper.GetNullableString(reader, "fdKodeEkspedisi");
                if (reader.IsColumnExists("fdNoOrderSFA"))
                    order.fdNoOrderSFA = SqlHelper.GetNullableString(reader, "fdNoOrderSFA");

                //fdTglSFA, fdStatusRecord, fdCreateUserID, fdCreateTS, fdUpdateUserID, 
                if (reader.IsColumnExists("fdTglSFA"))
                    order.fdTglSFA = SqlHelper.GetNullableString(reader, "fdTglSFA");
                if (reader.IsColumnExists("fdStatusRecord"))
                    order.fdStatusRecord = SqlHelper.GetNullableInt(reader, "fdStatusRecord");
                if (reader.IsColumnExists("fdCreateUserID"))
                    order.fdCreateUserID = SqlHelper.GetNullableString(reader, "fdCreateUserID");
                if (reader.IsColumnExists("fdCreateTS"))
                    order.fdCreateTS = SqlHelper.GetNullableDatetime(reader, "fdCreateTS");
                if (reader.IsColumnExists("fdUpdateUserID"))
                    order.fdUpdateUserID = SqlHelper.GetNullableString(reader, "fdUpdateUserID");


                //fdUpdateTS, fdNoEntryLama
                if (reader.IsColumnExists("fdUpdateTS"))
                    order.fdUpdateTS = SqlHelper.GetNullableDatetime(reader, "fdUpdateTS");
                if (reader.IsColumnExists("fdNoEntryLama"))
                    order.fdNoEntryLama = SqlHelper.GetNullableString(reader, "fdNoEntryLama");


            }
            catch (Exception ex)
            {
                throw ex;
            }



            

            return order;

        }

        public static List<orderModel> orderMappingList(this SqlDataReader reader)
        {
            var list = new List<orderModel>();
            while (reader.Read())
            {
                list.Add(orderMappingFunction(reader, true));
            }
            return list;
        }

        public static orderItemModel orderItemMappingFunction(this SqlDataReader reader, bool isList = false)
        {
            if (!isList)
            {
                if (!reader.HasRows)
                    return null;
                reader.Read();
            }

            //fdID, fdNoEntryOrder, fdUrutOrder, fdKodeBarang, fdPromosi, 
            //fdJenisSatuan, fdQty, fdUnitPrice, fdBrutto, fdSalesDisc, 
            //fdCashDisc, fdNetto, fdNoPromosi, fdNotes, fdQtyPBE, 
            //fdQtySJ, fdStatusRecord, fdCreateUserID, fdCreateTS, fdUpdateUserID, 
            //fdUpdateTS

            //fdID, fdNoEntryOrder, fdUrutOrder, fdKodeBarang, fdPromosi, 
            var orderItem = new orderItemModel();
            if (reader.IsColumnExists("fdID"))
                orderItem.fdID = SqlHelper.GetNullableBigInt(reader, "fdID");
            if (reader.IsColumnExists("fdNoEntryOrder"))
                orderItem.fdNoEntryOrder = SqlHelper.GetNullableBigInt(reader, "fdNoEntryOrder");
            if (reader.IsColumnExists("fdUrutOrder"))
                orderItem.fdUrutOrder = SqlHelper.GetNullableInt(reader, "fdUrutOrder");
            if (reader.IsColumnExists("fdKodeBarang"))
                orderItem.fdKodeBarang = SqlHelper.GetNullableString(reader, "fdKodeBarang");
            if (reader.IsColumnExists("fdPromosi"))
                orderItem.fdPromosi = SqlHelper.GetNullableString(reader, "fdPromosi");

            //fdJenisSatuan, fdQty, fdUnitPrice, fdBrutto, fdSalesDisc, 
            if (reader.IsColumnExists("fdJenisSatuan"))
                orderItem.fdJenisSatuan = SqlHelper.GetNullableInt(reader, "fdJenisSatuan");
            if (reader.IsColumnExists("fdQty"))
                orderItem.fdQty =SqlHelper.GetNullableNumeric(reader, "fdQty");
            if (reader.IsColumnExists("fdUnitPrice"))
                orderItem.fdUnitPrice =SqlHelper.GetNullableFloat(reader, "fdUnitPrice");
            if (reader.IsColumnExists("fdBrutto"))
                orderItem.fdBrutto = SqlHelper.GetNullableMoney(reader, "fdBrutto");
            if (reader.IsColumnExists("fdSalesDisc"))
                orderItem.fdSalesDisc = SqlHelper.GetNullableMoney(reader, "fdSalesDisc");

            //fdCashDisc, fdNetto, fdNoPromosi, fdNotes, fdQtyPBE,
            if (reader.IsColumnExists("fdCashDisc"))
                orderItem.fdCashDisc = SqlHelper.GetNullableMoney(reader, "fdCashDisc");
            if (reader.IsColumnExists("fdNetto"))
                orderItem.fdNetto = SqlHelper.GetNullableMoney(reader, "fdNetto");
            if (reader.IsColumnExists("fdNoPromosi"))
                orderItem.fdNoPromosi = SqlHelper.GetNullableString(reader, "fdNoPromosi");
            if (reader.IsColumnExists("fdNotes"))
                orderItem.fdNotes = SqlHelper.GetNullableString(reader, "fdNotes");
            if (reader.IsColumnExists("fdQtyPBE"))
                orderItem.fdQtyPBE = SqlHelper.GetNullableNumeric(reader, "fdQtyPBE");


            //fdQtySJ, fdStatusRecord, fdCreateUserID, fdCreateTS, fdUpdateUserID, 
            //fdUpdateTS
            if (reader.IsColumnExists("fdQtySJ"))
                orderItem.fdQtySJ =SqlHelper.GetNullableNumeric(reader, "fdQtySJ");
            if (reader.IsColumnExists("fdStatusRecord"))
                orderItem.fdStatusRecord = SqlHelper.GetNullableInt(reader, "fdStatusRecord");
            if (reader.IsColumnExists("fdCreateUserID"))
                orderItem.fdCreateUserID = SqlHelper.GetNullableString(reader, "fdCreateUserID");
            if (reader.IsColumnExists("fdCreateTS"))
                orderItem.fdCreateTS = SqlHelper.GetNullableDatetime(reader, "fdCreateTS");
            if (reader.IsColumnExists("fdUpdateUserID"))
                orderItem.fdUpdateUserID = SqlHelper.GetNullableString(reader, "fdUpdateUserID");
            if (reader.IsColumnExists("fdUpdateTS"))
                orderItem.fdUpdateTS =  SqlHelper.GetNullableDatetime(reader, "fdUpdateTS");
           

            return orderItem;

        }

        public static List<orderItemModel> orderItemMappingList(this SqlDataReader reader)
        {
            var list = new List<orderItemModel>();
            while (reader.Read())
            {
                list.Add(orderItemMappingFunction(reader, true));
            }
            return list;
        }


    }
}
