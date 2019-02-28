using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace M3.DBDSC.Common.Contracts
{
    [DataContract]
    public class Table
    {
        public Guid SerializationId { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public Column[] Columns { get; set; }

        [DataMember]
        public Key[] Keys { get; set; }

        [DataMember]
        public Constraint[] Constraints { get; set; }

        [DataMember]
        public Trigger[] Triggers { get; set; }

        [DataMember]
        public Index[] Index { get; set; }
    }

    #region Supporting Types
    [DataContract]
    public class Column
    {
        public Guid SerializationId { get; set; }

        [DataMember]
        public string Name { get; set;}

        [DataMember]
        public string Type { get; set; }
    }

    [DataContract]
    public class Key
    {
        public Guid SerializationId { get; set; }

        [DataMember]
        public string Name { get; set; }
    }

    [DataContract]
    public class Constraint
    {
        public Guid SerializationId { get; set; }

        [DataMember]
        public string Name { get; set; }
    }

    [DataContract]
    public class Trigger
    {
        public Guid SerializationId { get; set; }

        [DataMember]
        public string Name { get; set; }
    }

    [DataContract]
    public class Index
    {
        public Guid SerializationId { get; set; }

        [DataMember]
        public string Name { get; set; }
    }
    #endregion SupportingTypes
}
