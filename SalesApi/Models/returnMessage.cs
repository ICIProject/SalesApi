using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;
namespace SalesApi.Models
{
    [DataContract]
    public class returnMessage
    {
        [DataMember(Name = "isSuccess")]
        public bool isSuccess { get; set; }

        [DataMember(Name = "message")]
        public string message { get; set; }


        [DataMember(Name = "data")]
        public string data { get; set; }
    }
}