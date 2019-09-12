using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace my8BackendObject.Mongos
{
    public class UserLike
    {
        public UserLike() { }
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string PersonId { get; set; }
        public string TargetId { get; set; }
        public int TargetType {get;set;}
        public string ProjectId { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime ModifiedTime { get; set; }
    }
}

