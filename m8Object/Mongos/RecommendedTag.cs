using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace my8BackendObject.Mongos
{
    public class RecommendedTag
    {
        public RecommendedTag() { }
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Tag { get; set; }
        public int RecommendedType { get; set; }
        public int CountUsed { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime ModifiedTime { get; set; }
    }
}

