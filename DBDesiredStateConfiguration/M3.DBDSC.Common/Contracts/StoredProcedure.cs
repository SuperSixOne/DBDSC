using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace M3.DBDSC.Common.Contracts
{
    [DataContract]
    public class StoredProcedure
    {
        public Guid SerializationId { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Text { get; set; }
    }
}
