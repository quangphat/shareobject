using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace my8ShareObject.SimpleModel
{
    [BsonIgnoreExtraElements]
    public class IndustrySimple
    {
        public long Id { get; set; }
        public string Value { get; set; }
        public string Label { get; set; }
        public int OrderPoint { get; set; }
    }
}
