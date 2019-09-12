using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace my8BackendObject.Mongos
{
    public class JobFunction
    {
        public JobFunction() { }
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
		public string Id { get; set; }
        public string Code { get; set; }
        public string DisplayName { get; set; }
        public string[] KeySearchs { get; set; }
        public string ProjectId { get; set; }
        public int OrderPoint { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime ModifiedTime { get; set; }
    }
}

