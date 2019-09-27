using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;


namespace SalesApi.Models
{
    [DataContract]
    public class depoModel
    {
        
        [DataMember(Name = "fdID")]
        public Int64 fdID { get; set; }

        [DataMember(Name = "fdDepo")]
        public string fdDepo { get; set; }

        [DataMember(Name = "fdNamaDepo")]
        public string fdNamaDepo { get; set; }

        [DataMember(Name = "fdAlamat")]
        public string fdAlamat { get; set; }

        [DataMember(Name = "fdKota")]
        public string fdKota { get; set; }

        [DataMember(Name = "fdTelepon")]
        public string fdTelepon { get; set; }

        [DataMember(Name = "fdFax")]
        public string fdFax { get; set; }

        [DataMember(Name = "fdDepoInduk")]
        public string fdDepoInduk { get; set; }

        [DataMember(Name = "fdStatusDepo")]
        public string fdStatusDepo { get; set; }

        [DataMember(Name = "fdMaxRecord")]
        public decimal fdMaxRecord { get; set; }

        [DataMember(Name = "fdSistemPiutang")]
        public string fdSistemPiutang { get; set; }
        
        [DataMember(Name = "fdHariTidakAktif")]
        public int fdHariTidakAktif { get; set; }


        [DataMember(Name = "fdHariHapus")]
        public int fdHariHapus { get; set; }

        [DataMember(Name = "fdLastClose")]
        public string fdLastClose { get; set; }

        [DataMember(Name = "fdCost_LastClose")]
        public string fdCost_LastClose { get; set; }

        [DataMember(Name = "fdManager")]
        public string fdManager { get; set; }

        [DataMember(Name = "fdCa")]
        public string fdCa { get; set; }

        [DataMember(Name = "fdAca")]
        public string fdAca { get; set; }

        [DataMember(Name = "fdKasir")]
        public string fdKasir { get; set; }

        [DataMember(Name = "fdAdm")]
        public string fdAdm { get; set; }

        [DataMember(Name = "fdNoPKP")]
        public string fdNoPKP { get; set; }

        [DataMember(Name = "fdTanggalPKP")]
        public Nullable<DateTime> fdTanggalPKP { get; set; }


        [DataMember(Name = "fdNPWP")]
        public string fdNPWP { get; set; }


        [DataMember(Name = "fdKodeCabangFP")]
        public string fdKodeCabangFP { get; set; }


        [DataMember(Name = "fdAktifYN")]
        public string fdAktifYN { get; set; }


        [DataMember(Name = "fdTglNonAktif")]
        public Nullable<DateTime> fdTglNonAktif { get; set; }

        [DataMember(Name = "fdJmlBulanan")]
        public int fdJmlBulanan { get; set; }

        [DataMember(Name = "fdJmlHarian")]
        public int fdJmlHarian { get; set; }

        [DataMember(Name = "fdToleransiLK")]
        public string fdToleransiLK { get; set; }

        [DataMember(Name = "fdCetakSJ")]
        public string fdCetakSJ { get; set; }


        [DataMember(Name = "fdStatusRecord")]
        public int fdStatusRecord { get; set; }


        [DataMember(Name = "fdCreateUserID")]
        public string fdCreateUserID { get; set; }


        [DataMember(Name = "fdUpdateUserID")]
        public string fdUpdateUserID { get; set; }


        [DataMember(Name = "fdCreateTS")]
        public Nullable<DateTime> fdCreateTS { get; set; }
        

        [DataMember(Name = "fdUpdateTS")]
        public Nullable<DateTime> fdUpdateTS { get; set; }

        

    }
}
