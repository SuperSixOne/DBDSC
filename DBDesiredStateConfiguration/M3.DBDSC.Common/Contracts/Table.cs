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
        public List<Column> Columns { get; set; } = new List<Column>();

        [DataMember]
        public List<Key> Keys { get; set; } = new List<Key>();

        [DataMember]
        public List<Constraint> Constraints { get; set; } = new List<Constraint>();
        [DataMember]
        public List<Trigger> Triggers { get; set; } = new List<Trigger>();

        [DataMember]
        public List<Index> Index { get; set; } = new List<Index>();
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

        [DataMember]
        public Boolean AllowNulls { get; set; }
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
