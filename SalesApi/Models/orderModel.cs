using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;


namespace SalesApi.Models
{
    [DataContract]
    public class orderModel
    {
        //fdID, fdNoEntryOrder, fdDepo, fdJenisOrder, fdNoOrder, 
        //fdRevisi, fdTanggalOrder, fdTanggalKirim, fdKodeLangganan, fdAlamatKirim, 
        //fdKodeSF, fdKodeGudang, fdKodeGudangTujuan, fdMataUang, fdNoReferensi, 
        //fdTglReferensi, fdRemarkPO, fdOrderTambahan, fdTransport, fdTerm_Days, 
        //fdTerm, fdDestinationPortID, fdShippingMark, fdIsFixed, fdStatus, 
        //fdReasonNotApprove, fdDisetujuiOleh, fdTglDisetujui, fdKodeEkspedisi, fdNoOrderSFA, 
        //fdTglSFA, fdStatusRecord, fdCreateUserID, fdCreateTS, fdUpdateUserID, 
        //fdUpdateTS, fdNoEntryLama

            


            
            



        [DataMember(Name = "fdID")]
        public Int64  fdID { get; set; }

        [DataMember(Name = "fdNoEntryOrder")]
        public Int64 fdNoEntryOrder { get; set; }

        [DataMember(Name = "fdDepo")]
        public string fdDepo { get; set; }

        [DataMember(Name = "fdJenisOrder")]
        public string fdJenisOrder { get; set; }

        [DataMember(Name = "fdNoOrder")]
        public string fdNoOrder { get; set; }

        [DataMember(Name = "fdRevisi")]
        public int fdRevisi { get; set; }

        [DataMember(Name = "fdTanggalOrder")]
        public Nullable<DateTime> fdTanggalOrder { get; set; }

        [DataMember(Name = "fdTanggalKirim")]
        public Nullable<DateTime> fdTanggalKirim { get; set; }

       

        [DataMember(Name = "fdKodeLangganan")]
        public Int64 fdKodeLangganan { get; set; }

        [DataMember(Name = "fdNamaLangganan")]
        public string fdNamaLangganan { get; set; }


        [DataMember(Name = "fdAlamatKirim")]
        public string fdAlamatKirim { get; set; }
        

        [DataMember(Name = "fdKodeSF")]
        public Int64 fdKodeSF { get; set; }

        [DataMember(Name = "fdNamaSF")]
        public string fdNamaSF { get; set; }


        [DataMember(Name = "fdKodeGudang")]
        public string fdKodeGudang { get; set; }

        [DataMember(Name = "fdKodeGudangTujuan")]
        public string fdKodeGudangTujuan { get; set; }

        [DataMember(Name = "fdMataUang")]
        public string fdMataUang { get; set; }

        [DataMember(Name = "fdNoReferensi")]
        public string fdNoReferensi { get; set; }

        [DataMember(Name = "fdTglReferensi")]
        public Nullable<DateTime> fdTglReferensi { get; set; }

        [DataMember(Name = "fdRemarkPO")]
        public string fdRemarkPO { get; set; }

        [DataMember(Name = "fdOrderTambahan")]
        public int fdOrderTambahan { get; set; }

        [DataMember(Name = "fdTransport")]
        public string fdTransport { get; set; }

        [DataMember(Name = "fdTerm_Days")]
        public int fdTerm_Days { get; set; }

        [DataMember(Name = "fdTerm")]
        public string fdTerm { get; set; }

        [DataMember(Name = "fdDestinationPortID")]
        public string fdDestinationPortID { get; set; }

        [DataMember(Name = "fdShippingMark")]
        public string fdShippingMark { get; set; }

        
        [DataMember(Name = "fdIsFixed")]
        public string fdIsFixed { get; set; }

        [DataMember(Name = "fdStatus")]
        public int fdStatus { get; set; }

        [DataMember(Name = "fdNamaStatus")]
        public string fdNamaStatus { get; set; }


        [DataMember(Name = "fdReasonNotApprove")]
        public int fdReasonNotApprove { get; set; }

        [DataMember(Name = "fdDisetujuiOleh")]
        public string fdDisetujuiOleh { get; set; }

        [DataMember(Name = "fdTglDisetujui")]
        public Nullable<DateTime>  fdTglDisetujui { get; set; }

        [DataMember(Name = "fdKodeEkspedisi")]
        public string fdKodeEkspedisi { get; set; }

        [DataMember(Name = "fdNoOrderSFA")]
        public string fdNoOrderSFA { get; set; }

        [DataMember(Name = "fdTglSFA")]
        public string fdTglSFA { get; set; }

        [DataMember(Name = "fdStatusRecord")]
        public int fdStatusRecord { get; set; }

        [DataMember(Name = "fdCreateUserID")]
        public string fdCreateUserID { get; set; }

        [DataMember(Name = "fdCreateTS")]
        public Nullable<DateTime> fdCreateTS { get; set; }

        [DataMember(Name = "fdUpdateUserID")]
        public string fdUpdateUserID { get; set; }


        [DataMember(Name = "fdUpdateTS")]
        public Nullable<DateTime> fdUpdateTS { get; set; }

        [DataMember(Name = "fdNoEntryLama")]
        public string fdNoEntryLama { get; set; }

        

    }

    [DataContract]
    public class orderItemModel
    {
        //fdID, fdNoEntryOrder, fdUrutOrder, fdKodeBarang, fdPromosi, 
        //fdJenisSatuan, fdQty, fdUnitPrice, fdBrutto, fdSalesDisc, 
        //fdCashDisc, fdNetto, fdNoPromosi, fdNotes, fdQtyPBE, 
        //fdQtySJ, fdStatusRecord, fdCreateUserID, fdCreateTS, fdUpdateUserID, 
        //fdUpdateTS

            
  

        [DataMember(Name = "fdID")]
        public Int64 fdID { get; set; }

        [DataMember(Name = "fdNoEntryOrder")]
        public Int64 fdNoEntryOrder { get; set; }

        [DataMember(Name = "fdUrutOrder")]
        public int fdUrutOrder { get; set; }

        [DataMember(Name = "fdKodeBarang")]
        public string fdKodeBarang { get; set; }

        [DataMember(Name = "fdPromosi")]
        public string fdPromosi { get; set; }
        
        [DataMember(Name = "fdJenisSatuan")]
        public int fdJenisSatuan { get; set; }

        [DataMember(Name = "fdQty")]
        public decimal fdQty { get; set; }

        [DataMember(Name = "fdUnitPrice")]
        public double fdUnitPrice { get; set; }

        
        [DataMember(Name = "fdBrutto")]
        public decimal fdBrutto { get; set; }

        [DataMember(Name = "fdSalesDisc")]
        public decimal fdSalesDisc { get; set; }
 
        [DataMember(Name = "fdCashDisc")]
        public decimal fdCashDisc { get; set; }

        [DataMember(Name = "fdNetto")]
        public decimal fdNetto { get; set; }

        [DataMember(Name = "fdNoPromosi")]
        public string fdNoPromosi { get; set; }

        [DataMember(Name = "fdNotes")]
        public string fdNotes { get; set; }

        [DataMember(Name = "fdQtyPBE")]
        public decimal fdQtyPBE { get; set; }
        
        [DataMember(Name = "fdQtySJ")]
        public decimal fdQtySJ { get; set; }

        [DataMember(Name = "fdStatusRecord")]
        public int fdStatusRecord { get; set; }

        [DataMember(Name = "fdCreateUserID")]
        public string fdCreateUserID { get; set; }

        [DataMember(Name = "fdCreateTS")]
        public Nullable<DateTime> fdCreateTS { get; set; }

        [DataMember(Name = "fdUpdateUserID")]
        public string fdUpdateUserID { get; set; }

        [DataMember(Name = "fdUpdateTS")]
        public Nullable<DateTime> fdUpdateTS { get; set; }


    }

}
