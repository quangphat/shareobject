using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace my8ShareObject.SimpleModel
{
    [BsonIgnoreExtraElements]
    public class SelectItem
    {
        public string Label { get; set; }
        public string Value { get; set; }
    }
}
