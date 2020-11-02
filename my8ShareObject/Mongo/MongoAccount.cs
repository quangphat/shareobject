using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using my8ShareObject.Enums;
using my8ShareObject.Mongo;
using Newtonsoft.Json;
using System;


namespace CoreObject.Mongo
{
    public class Account : MongoBaseModel
    {
        public Account() { }
        public string DisplayName { get; set; }
        public string ProfileName { get; set; }
        public string Avatar { get; set; }
        public string WorkAs { get; set; }
        public string CompanyId { get; set; }
        public double Rate { get; set; }//Đánh giá 
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string Token { get; set; }
        public string[] Scopes { get; set; }
        public string[] SkillTags { get; set; }
        public string[] FollowingTags { get; set; }
        public string Salt { get; set; }
        public bool IsBanned { get; set; }
        public DateTime? BannedDate { get; set; }
        public bool IsComfirmEmail { get; set; }
        public string RefreshToken { get; set; }
        public AccountType AccountType { get; set; }
    }
}
