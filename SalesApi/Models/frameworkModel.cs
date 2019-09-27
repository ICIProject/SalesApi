using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace SalesApi.Models
{
        [DataContract]
        public class MainApplicationModel
        {
            [DataMember(Name = "fdApplicationCode")]
            public string fdApplicationCode { get; set; }

            [DataMember(Name = "fdApplication")]
            public string fdApplication { get; set; }

            [DataMember(Name = "fdIcon")]
            public string fdIcon { get; set; }

            [DataMember(Name = "fdUrl")]
            public string fdUrl { get; set; }

            //Column tambahan
            [DataMember(Name = "totalProgram")]
            public int totalProgram { get; set; }

        }


    [DataContract]
    public class moduleModel
    {
        [DataMember(Name = "fdId")]
        public Int64 fdId { get; set; }

        [DataMember(Name = "fdSort")]
        public int fdSort { get; set; }

        [DataMember(Name = "fdApplicationCode")]
        public string fdApplicationCode { get; set; }

        [DataMember(Name = "fdModule")]
        public string fdModule { get; set; }

        [DataMember(Name = "fdModuleName")]
        public string fdModuleName { get; set; }

        [DataMember(Name = "fdModuleEventCode")]
        public string fdModuleEventCode { get; set; }

        [DataMember(Name = "fdParent")]
        public string fdParent { get; set; }

        [DataMember(Name = "fdLink")]
        public string fdLink { get; set; }

        [DataMember(Name = "fdIconCls")]
        public string fdIconCls { get; set; }

        [DataMember(Name = "fdType")]
        public string fdType { get; set; }

        [DataMember(Name = "fdNote")]
        public string fdNote { get; set; }

        [DataMember(Name = "fdLevel")]
        public string fdLevel { get; set; }

        [DataMember(Name = "fdModuleEvent")]
        public string fdModuleEvent { get; set; }

        [DataMember(Name = "fdIconName")]
        public string fdIconName { get; set; }

    }
}
