using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using my8ViewObject;
using System;

namespace my8BackendObject.Mongos
{
    [BsonIgnoreExtraElements]
    public class Article
    {
        public Article() { }
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
		public string Id { get; set; }
	    public string Title { get; set; }
        public string Preview { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime ModifiedTime { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public string Content { get; set; }
        public string ImageUrl { get; set; }
        public bool IsDelete { get; set; }
        public int Likes { get; set; }
        public int Views { get; set; }
        public int Comments { get; set; }
        public int Shares { get; set; }
        public Author Author { get; set; }
        public string ProjectId { get; set; }
        public string FriendlyUrl { get; set; }
        public int Status { get; set; }
        public string[] Tags { get; set; }
        public bool IsSerie { get; set; }
        public string LastPartId { get; set; }
        public int PartNumber { get; set; }
        public DateTime StatusDate { get; set; }
    }
}

