using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace SalesApi.Models
{
    [DataContract]
    public class jsonDataModel
    {
        [DataMember(Name = "header")]
        public string header { get; set; }

        [DataMember(Name = "detail")]
        public string detail { get; set; }

        [DataMember(Name = "fdAction")]
        public string fdAction { get; set; }
        
    }
}
