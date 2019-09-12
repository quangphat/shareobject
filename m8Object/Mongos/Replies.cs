using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using my8ViewObject;
using System;

namespace my8BackendObject.Mongos
{
    public class Replies
    {
        public Replies() { }
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string CommentId { get; set; }
        public string ArticleId { get; set; }
        public string Content { get; set; }
        public Author Author { get; set; }
        public int Likes { get; set; }
        public bool IsHidden { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime ModifiedTime { get; set; }
        public string ProjectId { get; set; }
    }
}

