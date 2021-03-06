﻿using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace M3.DBDSC.Common.Contracts
{
    [DataContract]
    public class Type
    {
        public Guid SerializationId { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public Type DataType { get; set; }

        [DataMember]
        public int Precision { get; set; }

        [DataMember]
        public Boolean AllowNulls { get; set; }
    }
}
