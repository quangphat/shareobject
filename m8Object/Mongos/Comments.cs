using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using my8ViewObject;
using System;

namespace my8BackendObject.Mongos
{
    public class Comments
    {
        public Comments() { }
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Content { get; set; }
        public Author Author { get; set; }
        public string ArticleId { get; set; }
        public int Likes { get; set; }
        public int Replies { get; set; }
        public bool IsHidden { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime ModifiedTime { get; set; }
        public string ProjectId { get; set; }
    }
}

