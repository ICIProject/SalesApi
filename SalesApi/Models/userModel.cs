using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace SalesApi.Models
{
    [DataContract]
    public class userModel
    {
        [DataMember(Name = "fdId")]
        public Int64  fdId { get; set; }

        [DataMember(Name = "fdUserName")]
        public string fdUserName { get; set; }

        [DataMember(Name = "fdPassword")]
        public string fdPassword { get; set; }

        [DataMember(Name = "fdEmail")]
        public string fdEmail { get; set; }

        [DataMember(Name = "fdName")]
        public string fdName { get; set; }

        [DataMember(Name = "fdNIP")]
        public string fdNIP { get; set; }



    }


}
