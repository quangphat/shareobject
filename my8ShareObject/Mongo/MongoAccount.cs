using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using System;


namespace CoreObject.Mongo
{
    public class MongoAccount
    {
        public MongoAccount() { }
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        [BsonElement("Id")]
        [JsonProperty(PropertyName = "PersonId")]
        public string PersonId { get; set; }
        public string DisplayName { get; set; }
        public string ProfileName { get; set; }
        public string Avatar { get; set; }
        public string WorkAs { get; set; }
        public string Company { get; set; }
        public double Rate { get; set; }//Đánh giá 
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string Token { get; set; }
        public string[] Scopes { get; set; }
        public string ProjectId { get; set; }
        public string[] SkillTags { get; set; }
        public string[] FollowingTags { get; set; }
        public string Salt { get; set; }
        public bool IsBanned { get; set; }
        public DateTime? BannedDate { get; set; }
        public bool IsComfirmEmail { get; set; }
    }
}
