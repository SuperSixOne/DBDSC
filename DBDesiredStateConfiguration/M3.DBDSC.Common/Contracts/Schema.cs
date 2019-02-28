using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace M3.DBDSC.Common.Contracts
{
    [DataContract]
    public class Schema
    {
        public Guid SerializationId { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Owner { get; set; }

        [DataMember]
        public List<Table> Tables { get; set; } = new List<Table>();

        [DataMember]
        public List<View> Views { get; set; } = new List<View>();
    }
}
