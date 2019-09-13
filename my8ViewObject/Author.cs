using MongoDB.Bson.Serialization.Attributes;

namespace my8ViewObject
{
    [BsonIgnoreExtraElements]
    public class Author
    {
        public Author() { }
        [BsonId]
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string DisplayName { get; set; }
        public string ProfileName { get; set; }
        public string LastName { get; set; }
        public string Avatar { get; set; }
        public string Email { get; set; }
        public string ProjectId { get; set; }
        public string[] SkillTags { get; set; }
        public string[] FollowingTags { get; set; }
    }
}
