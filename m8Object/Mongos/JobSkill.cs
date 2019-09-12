using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace my8BackendObject.Mongos
{
    public class JobSkill
    {
        public JobSkill() { }
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
		public string Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string ProjectId { get; set; }
        public int OrderPoint { get; set; }
    }
}

