using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    [DataContract]
    public class Article : IExtensibleDataObject
    {

        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Title { get; set; }

        [DataMember]
        public string Contents { get; set; }

        [DataMember]
        public string Author { get; set; }

        [DataMember]
        public string Url { get; set; }

        [DataMember]
        public int BlogId { get; set; }

        [DataMember]
        public int ContentLength
        {
            get
            {
                return this.Contents.Length;
            }
            set { }
        }

        public ExtensionDataObject ExtensionData
        {
            get; set;
        }
    }
}
