using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace SalesApi.Models
{
    [DataContract]
    public class userAccessHistoryModel
    {
        [DataMember(Name = "fdId")]
        public Int64 fdId
        {
            get; set;
        }

        [DataMember(Name = "fdApplicationCode")]
        public string fdApplicationCode
        {
            get; set;
        }

        [DataMember(Name = "fdUserID")]
        public string fdUserID
        {
            get; set;
        }

        [DataMember(Name = "fdModuleName")]
        public string fdModuleName
        {
            get; set;
        }

        [DataMember(Name = "fdDateTime")]
        public DateTime fdDateTime
        {
            get; set;
        }

        
    }
}
