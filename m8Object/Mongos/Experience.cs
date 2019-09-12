using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using my8ViewObject;
using System;

namespace my8BackendObject.Mongos
{
    public class Experience
    {
        public Experience() { }
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Title { get; set; }
        public string CompanyName { get; set; }
        public LocationView Location { get; set; }
        public int StartMonth { get; set; }
        public int StartYear { get; set; }
        public bool IsPresent { get; set; }
        public int? EndMonth { get; set; }
        public int? EndYear { get; set; }
        public JobFunctionView JobFunction { get; set; }
        public string Description { get; set; }
        public string PersonId { get; set; }
        public string ProjectId { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime ModifiedTime { get; set; }
    }
}

