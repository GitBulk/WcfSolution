using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    [DataContract]
    public class Blog : IExtensibleDataObject
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Url { get; set; }

        [DataMember]
        public string Owner { get; set; }

        public ExtensionDataObject ExtensionData
        {
            get; set;
        }
    }
}
