using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using my8ViewObject;
using System;

namespace my8BackendObject.Mongos
{
    public class SearchModel
    {
        public SearchModel() { }
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string FeedId { get; set; }
        public int ObjectType { get; set; }
        public string Title { get; set; }
        public string[] Tags { get; set; }
        public string ProjectId { get; set; }
        public int Likes { get; set; }
        public int Views { get; set; }
        public int Comments { get; set; }
        public int Shares { get; set; }
        public DateTime CreatedTime { get; set; }
        public string FriendlyUrl { get; set; }
        public string Preview { get; set; }
        public Author Author { get; set; }
    }
}

