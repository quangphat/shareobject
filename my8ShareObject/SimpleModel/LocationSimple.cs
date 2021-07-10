using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace my8ShareObject.SimpleModel
{
    [BsonIgnoreExtraElements]
    public class LocationSimple
    {
        public string Id { get; set; }
        public string Code { get; set; }
        public string Display { get; set; }
        public string Address { get; set; }
        public bool IsMain { get; set; }
    }
}
