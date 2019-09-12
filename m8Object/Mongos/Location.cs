using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using my8ShareObject.Enums;
using System;

namespace my8BackendObject.Mongos
{
    public class Location
    {
        public Location() { }
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Code { get; set; }
        public string CountryCode { get; set; }
        public string ProvinceCode { get; set; }
        public string DistrictCode { get; set; }
        public string DisplayName { get; set; }
        public int OrderPoint { get; set; }
        public LocationType LocationType { get; set; }
        public string[] KeySearchs { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime ModifiedTime { get; set; }
    }
}

