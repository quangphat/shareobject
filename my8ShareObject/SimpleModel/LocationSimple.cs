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
        public string Value { get; set; }
        public string Label { get; set; }
        public string Address { get; set; }
        public bool IsMain { get; set; }
        public string FlagUrl { get; set; }
    }
}
