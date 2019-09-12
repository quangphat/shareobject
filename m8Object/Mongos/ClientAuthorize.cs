using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace my8BackendObject.Mongos
{
    public class ClientAuthorize
    {
        public ClientAuthorize() { }
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Name { get; set; }
        public string ApiKey { get; set; }
        public string SecretKey { get; set; }
        public bool Active { get; set; }
        public bool IsGuest { get; set; } = false;

    }
}

