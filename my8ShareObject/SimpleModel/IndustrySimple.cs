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
        public string Code { get; set; }
        public string Display { get; set; }
        public int OrderPoint { get; set; }
    }
}
